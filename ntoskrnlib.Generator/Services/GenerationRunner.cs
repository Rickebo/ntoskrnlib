using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using ntoskrnlib.Abstractions;
using ntoskrnlib.Gen;
using ntoskrnlib.Options;
using ntoskrnlib.Symbols;
using YamlDotNet.Serialization;

namespace ntoskrnlib.Services;

internal interface IGenerationRunner
{
    int Run(GenerationOptions opts);
}

internal sealed class GenerationRunner : IGenerationRunner
{
    private readonly ILogger<GenerationRunner> _log;
    private readonly ISymbolSessionFactory _sessionFactory;
    private readonly ICodeGeneratorFactory _codeGenFactory;
    private readonly IUdtEmitterFactory _emitterFactory;
    private readonly IDiaInspectorFactory _diaFactory;

    public GenerationRunner(
        ILogger<GenerationRunner> log,
        ISymbolSessionFactory sessionFactory,
        ICodeGeneratorFactory codeGenFactory,
        IUdtEmitterFactory emitterFactory,
        IDiaInspectorFactory diaFactory)
    {
        _log = log;
        _sessionFactory = sessionFactory;
        _codeGenFactory = codeGenFactory;
        _emitterFactory = emitterFactory;
        _diaFactory = diaFactory;
    }

    public int Run(GenerationOptions opts)
    {
        _log.LogInformation("Starting generation workflow");
        _log.LogDebug("Resolved options: {options}", DescribeOptions(opts));

        if (!string.IsNullOrEmpty(opts.ConfigPath))
        {
            _log.LogInformation("Running generation from configuration file {config}", opts.ConfigPath);
            return RunFromConfig(opts.ConfigPath!, opts.Output, opts.VersionLabel);
        }

        _log.LogInformation("Ensuring output root exists at {output}", opts.Output);
        Directory.CreateDirectory(opts.Output);

        var symbolPath = SymbolSession.BuildDefaultSymbolPath();
        _log.LogDebug("Using symbol search path: {path}", symbolPath);
        var symbolPrefetched = SymbolDownloader.EnsureSymbolsAvailable(opts.Module, symbolPath, _log);
        _log.LogDebug("Symbol prefetch status for {module}: {status}", opts.Module, symbolPrefetched ? "downloaded" : "cached/skip");

        _log.LogInformation("Opening symbol session for {module}", opts.Module);
        using var session = _sessionFactory.Create(opts.Module, symbolPath);
        var insp = new TypeInspector(session);
        var versionId = NormalizeVersionLabel(opts.VersionLabel);
        if (string.IsNullOrWhiteSpace(versionId))
        {
            _log.LogInformation("No version label provided; attempting to detect from host OS");
            versionId = DetectWindowsVersionLabel();
        }
        _log.LogInformation("Using version label {version}", versionId);
        var (moduleId, ns) = DeriveModuleInfo(opts.Module, versionId);
        _log.LogInformation("Derived module info: moduleId={moduleId}, namespace={namespace}", moduleId, ns);
        var gen = _codeGenFactory.Create(insp, opts.Flatten, ns);
        DynamicWrapperGenerator? dyn = opts.EmitDynamic ? new DynamicWrapperGenerator(insp) : null;
        string moduleSym = moduleId; // simple prefix; DbgHelp often aliases 'nt' but this is for metadata only
        var emitter = _emitterFactory.Create(insp, gen, dyn, ns, moduleSym);
        var outRoot = opts.Output;
        var versionDir = Path.Combine(outRoot, versionId);
        // Clean current version directory to avoid stale files without touching other versions
        _log.LogDebug("Cleaning version-specific output at {dir}", versionDir);
        TryCleanDirectory(versionDir);
        var outDir = Path.Combine(versionDir, moduleId);
        _log.LogInformation("Emitting files to {dir}", outDir);
        Directory.CreateDirectory(outDir);

        var targets = new List<(uint typeId, string name)>();
        if (opts.All)
        {
            _log.LogInformation("Enumerating all UDTs from {module}", opts.Module);
            bool usedDbgHelp = false;
            try
            {
                var udts = new List<(uint typeId, string name)>(insp.EnumerateUdts());
                if (udts.Count > 0)
                {
                    targets.AddRange(udts);
                    _log.LogInformation("Queued {count} UDTs for generation via DbgHelp", udts.Count);
                    usedDbgHelp = true;
                }
                else
                {
                    _log.LogWarning("DbgHelp enumeration returned 0 UDTs; trying DIA fallback");
                }
            }
            catch (Exception ex)
            {
                _log.LogWarning(ex, "DbgHelp enumeration failed; trying DIA fallback");
            }

            if (!usedDbgHelp)
            {
                var dia = _diaFactory.TryCreate(opts.Module, symbolPath);
                if (dia != null)
                {
                    var emitterDia = new DiaEmitter(dia, ns);
                    int total = 0;
                    foreach (var name in dia.EnumerateUdts())
                    {
                        try { total += emitterDia.GenerateWithDependencies(name, outDir, opts.Flatten); }
                        catch (Exception genEx) { _log.LogWarning(genEx, "Failed generating {name} via DIA", name); }
                    }
                    _log.LogInformation("Generated {count} file(s) into '{output}'", total, outDir);
                    return 0;
                }
                _log.LogError("DIA not available; cannot enumerate UDTs");
                return 2;
            }
        }
        else
        {
            _log.LogInformation("Resolving {count} requested type(s) for generation", opts.Types.Count);
            foreach (var t in opts.Types)
            {
                var name = t;
                if (!insp.TryGetTypeIdByName(name, out var typeId))
                {
                    _log.LogWarning("Type not found via DbgHelp: {name}; trying DIA...", name);
                    var dia = _diaFactory.TryCreate(opts.Module, symbolPath);
                    if (dia == null)
                    {
                        _log.LogError("DIA not available; cannot resolve {name}", name);
                        continue;
                    }
                    if (opts.Flatten)
                    {
                        var udt = dia.FindUdt(name);
                        if (udt == null)
                        {
                            _log.LogError("Type not found via DIA: {name}", name);
                            continue;
                        }
                        var code = ProgramHelpers.GenerateFromDia(name, dia, udt, opts.Flatten, ns);
                        File.WriteAllText(Path.Combine(outDir, ProgramHelpers.Sanitize(name) + ".g.cs"), code);
                    }
                    else
                    {
                        var emitterDia = new DiaEmitter(dia, ns);
                        var count = emitterDia.GenerateWithDependencies(name, outDir, opts.Flatten);
                        _log.LogInformation("DIA emitted {count} file(s) for {name}", count, name);
                    }
                    continue;
                }
                targets.Add((typeId, name));
                _log.LogDebug("Queued {name} ({id}) for emission", name, typeId);
            }
        }

        if (targets.Count == 0 && !opts.All)
        {
            _log.LogWarning("No UDTs resolved via DbgHelp; ensure requested types exist or rely on DIA fallback logs above");
        }

        int written = 0;
        _log.LogInformation("Starting emission for {count} target type(s)", targets.Count);
        foreach (var (typeId, name) in targets)
        {
            try
            {
                _log.LogDebug("Generating files for {name} ({id})", name, typeId);
                written += emitter.GenerateWithDependencies(typeId, outDir, opts.Flatten);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Failed generating {name}", name);
            }
        }
        _log.LogInformation("Generated {count} file(s) into '{output}'", written, outDir);
        return 0;
    }

    private static (string moduleId, string ns) DeriveModuleInfo(string module, string versionId)
    {
        var baseName = Path.GetFileNameWithoutExtension(module).ToLowerInvariant();
        string moduleId = baseName switch
        {
            "ntkrnlmp" or "ntkrnlpa" => "ntoskrnl",
            _ => baseName
        };
        string ns = string.IsNullOrWhiteSpace(versionId)
            ? $"ntoskrnlib.{moduleId}"
            : $"ntoskrnlib.{versionId}.{moduleId}";
        return (moduleId, ns);
    }

    private sealed class ConfigEntry
    {
        [YamlMember(Alias = "module")] public string Module { get; set; } = string.Empty;
        [YamlMember(Alias = "flatten")] public bool Flatten { get; set; }
        [YamlMember(Alias = "all")] public bool All { get; set; }
        [YamlMember(Alias = "names")] public List<string> Names { get; set; } = new();
    }
    private sealed class ConfigRoot
    {
        [YamlMember(Alias = "types")] public List<ConfigEntry> Types { get; set; } = new();
        [YamlMember(Alias = "version_label")] public string? VersionLabel { get; set; }
        [YamlMember(Alias = "versions")] public List<ConfigVersion> Versions { get; set; } = new();
    }

    private sealed class ConfigVersion
    {
        [YamlMember(Alias = "label")] public string Label { get; set; } = string.Empty;
        [YamlMember(Alias = "types")] public List<ConfigEntry> Types { get; set; } = new();
    }

    private int RunFromConfig(string configPath, string output, string? cliVersionLabel)
    {
        _log.LogInformation("Reading generation configuration from {config}", configPath);
        var yaml = File.ReadAllText(configPath);
        var y = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
        var root = y.Deserialize<ConfigRoot>(yaml);
        if (root == null)
        {
            _log.LogError("Invalid config: 'types' not found");
            return 2;
        }
        _log.LogDebug("Configuration loaded with {count} top-level type entries", root.Types?.Count ?? 0);
        int total = 0;
        var symbolPath = SymbolSession.BuildDefaultSymbolPath();
        _log.LogDebug("Using symbol search path: {path}", symbolPath);

        // If multi-version is provided, iterate each and generate into its own subdir/namespace
        if (root.Versions != null && root.Versions.Count > 0)
        {
            foreach (var v in root.Versions)
            {
                var versionId = NormalizeVersionLabel(v.Label);
                _log.LogInformation("Processing configuration block for version {version}", versionId);
                total += RunOneConfigTypesSet(v.Types, output, versionId, symbolPath);
            }
            _log.LogInformation("Generated {count} file(s) into '{output}'", total, output);
            return 0;
        }

        // Fallback: single-version root list, possibly with a version label
        var singleVersionId = NormalizeVersionLabel(cliVersionLabel ?? root.VersionLabel);
        if (string.IsNullOrWhiteSpace(singleVersionId))
            singleVersionId = DetectWindowsVersionLabel();
        // Clean per-version root once before generating all entries for this version
        _log.LogDebug("Cleaning configuration output for version {version} at {dir}", singleVersionId, Path.Combine(output, singleVersionId));
        TryCleanDirectory(Path.Combine(output, singleVersionId));
        total += RunOneConfigTypesSet(root.Types, output, singleVersionId, symbolPath);
        _log.LogInformation("Generated {count} file(s) into '{output}'", total, output);
        return 0;
    }

    private int RunOneConfigTypesSet(List<ConfigEntry> entries, string output, string versionId, string symbolPath)
    {
        if (entries == null)
            return 0;
        int total = 0;
        _log.LogInformation("Starting configuration-driven generation for version {version} with {count} module entry(ies)", versionId, entries.Count);
        foreach (var ce in entries)
        {
            var module = ce.Module.Replace("ntoskrnlib_placeholder.exe", "ntoskrnl.exe");
            _log.LogInformation("Ensuring symbols and session for module {module} (all={all}, flatten={flatten})", module, ce.All, ce.Flatten);
            SymbolDownloader.EnsureSymbolsAvailable(module, symbolPath, _log);
            using var session = _sessionFactory.Create(module, symbolPath);
            var insp = new TypeInspector(session);
            var (moduleId, ns) = DeriveModuleInfo(module, versionId);
            _log.LogDebug("Derived module info for config entry: moduleId={moduleId}, namespace={namespace}", moduleId, ns);
            var gen = _codeGenFactory.Create(insp, ce.Flatten, ns);
            DynamicWrapperGenerator? dyn = new DynamicWrapperGenerator(insp);
            string moduleSym = moduleId;
            var emitter = _emitterFactory.Create(insp, gen, dyn, ns, moduleSym);
            var outDir = Path.Combine(output, versionId, moduleId);
            _log.LogInformation("Emitting configuration output for module {module} into {dir}", module, outDir);
            Directory.CreateDirectory(outDir);

            if (ce.All)
            {
                _log.LogInformation("Configuration requests all UDTs for module {module}", module);
                bool usedDbgHelp = false;
                try
                {
                    var udts = new List<(uint typeId, string name)>(insp.EnumerateUdts());
                    if (udts.Count > 0)
                    {
                        foreach (var (typeId, name) in udts)
                        {
                            try { total += emitter.GenerateWithDependencies(typeId, outDir, ce.Flatten); }
                            catch (Exception ex) { _log.LogWarning(ex, "Failed generating {name}", name); }
                        }
                        _log.LogInformation("DbgHelp emitted {count} UDT(s) for module {module}", udts.Count, module);
                        usedDbgHelp = true;
                    }
                    else
                    {
                        _log.LogWarning("DbgHelp enumeration returned 0 UDTs; trying DIA fallback (config all)");
                    }
                }
                catch (Exception ex)
                {
                    _log.LogWarning(ex, "DbgHelp enumeration failed; trying DIA fallback (config all)");
                }

                if (!usedDbgHelp)
                {
                    var dia = _diaFactory.TryCreate(module, symbolPath);
                    if (dia != null)
                    {
                        var emitterDia = new DiaEmitter(dia, ns, moduleSym);
                        int emittedViaDia = 0;
                        foreach (var name in dia.EnumerateUdts())
                        {
                            try { total += emitterDia.GenerateWithDependencies(name, outDir, ce.Flatten); emittedViaDia++; }
                            catch (Exception genEx) { _log.LogWarning(genEx, "Failed generating {name} via DIA", name); }
                        }
                        _log.LogInformation("DIA emitted {count} UDT(s) for module {module}", emittedViaDia, module);
                    }
                    else
                    {
                        _log.LogError("DIA not available; cannot enumerate UDTs for module {module}", module);
                    }
                }
                continue;
            }

            _log.LogInformation("Configuration requests {count} specific type(s) for module {module}", ce.Names.Count, module);
            foreach (var name in ce.Names)
            {
                if (insp.TryGetTypeIdByName(name, out var typeId))
                {
                    _log.LogDebug("Config entry resolved {name} ({id}) via DbgHelp", name, typeId);
                    total += emitter.GenerateWithDependencies(typeId, outDir, ce.Flatten);
                    continue;
                }

                // Fallback to DIA like the direct CLI path
                _log.LogWarning("Type not found via DbgHelp: {name}; trying DIA...", name);
                var dia = _diaFactory.TryCreate(module, symbolPath);
                if (dia == null)
                {
                    _log.LogError("DIA not available; cannot resolve {name}", name);
                    continue;
                }
                if (ce.Flatten)
                {
                    var udt = dia.FindUdt(name);
                    if (udt == null)
                    {
                        _log.LogError("Type not found via DIA: {name}", name);
                        continue;
                    }
                    var code = ProgramHelpers.GenerateFromDia(name, dia, udt, ce.Flatten, ns);
                    File.WriteAllText(Path.Combine(outDir, ProgramHelpers.Sanitize(name) + ".g.cs"), code);
                    total += 1;
                }
                else
                {
                    var emitterDia = new DiaEmitter(dia, ns);
                    var count = emitterDia.GenerateWithDependencies(name, outDir, ce.Flatten);
                    _log.LogInformation("DIA emitted {count} file(s) for {name}", count, name);
                    total += count;
                }
            }
        }

        // Generate registry file for managed classes
        _log.LogInformation("Generating structure registry for version {version}", versionId);
        GenerateStructureRegistry(output, versionId);

        return total;
    }

    private void GenerateStructureRegistry(string output, string versionId)
    {
        try
        {
            // Find all Managed directories
            var versionDir = Path.Combine(output, versionId);
            _log.LogDebug("Scanning for managed types under {dir}", versionDir);
            if (!Directory.Exists(versionDir))
            {
                _log.LogDebug("Version directory {dir} not found; skipping structure registry", versionDir);
                return;
            }

            var managedDirs = Directory.GetDirectories(versionDir, "Managed", SearchOption.AllDirectories);
            if (managedDirs.Length == 0)
            {
                _log.LogDebug("No Managed directories found beneath {dir}; skipping structure registry", versionDir);
                return;
            }

            foreach (var managedDir in managedDirs)
            {
                var classFiles = Directory.GetFiles(managedDir, "*.managed.g.cs");
                if (classFiles.Length == 0)
                {
                    _log.LogTrace("No managed class files found in {dir}; skipping", managedDir);
                    continue;
                }

                // Extract class names from filenames (<Class>.managed.g.cs). Exclude the registry file itself.
                var classNames = classFiles
                    .Select(f =>
                    {
                        var file = Path.GetFileName(f);
                        if (string.Equals(file, "StructureRegistry.managed.g.cs", StringComparison.OrdinalIgnoreCase))
                            return null;

                        const string suffix = ".managed.g.cs";
                        if (file.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
                            return file.Substring(0, file.Length - suffix.Length);

                        // Fallback for unexpected filenames
                        return Path.GetFileNameWithoutExtension(f);
                    })
                    .Where(n => !string.IsNullOrWhiteSpace(n))
                    .OrderBy(n => n)
                    .ToList();

                if (classNames.Count == 0)
                {
                    _log.LogTrace("No registerable managed class files found in {dir}; skipping", managedDir);
                    continue;
                }

                // Determine namespace from parent directory
                var moduleDir = Path.GetFileName(Path.GetDirectoryName(managedDir)!);
                var ns = $"ntoskrnlib.{versionId}.{moduleDir}";

            // Generate registry file via Roslyn
                var cu = SyntaxFactory.CompilationUnit()
                    .WithUsings(SyntaxFactory.List(new UsingDirectiveSyntax[]
                    {
                        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")),
                        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("ntoskrnlib.Structure"))
                    }));

                var classDecl = SyntaxFactory.ClassDeclaration("StructureRegistry")
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                                   SyntaxFactory.Token(SyntaxKind.StaticKeyword));

                // public static void RegisterAll() { <Class>.Register(); ... }
                var statements = new System.Collections.Generic.List<StatementSyntax>();
                foreach (var className in classNames)
                {
                    var invoke = SyntaxFactory.ExpressionStatement(
                        SyntaxFactory.InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName(className),
                                SyntaxFactory.IdentifierName("Register"))))
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
                    statements.Add(invoke);
                }

                var registerAll = SyntaxFactory.MethodDeclaration(
                        SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)),
                        "RegisterAll")
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                                   SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                    .WithBody(SyntaxFactory.Block(statements));

                classDecl = classDecl.AddMembers(registerAll);

                var nsDecl = SyntaxFactory.NamespaceDeclaration(
                    SyntaxFactory.ParseName(ns)).AddMembers(classDecl);
                cu = cu.AddMembers(nsDecl);

                var registryFile = Path.Combine(managedDir, "StructureRegistry.managed.g.cs");
                File.WriteAllText(registryFile, cu.NormalizeWhitespace().ToFullString());
                _log.LogInformation("Generated structure registry: {file}", registryFile);
            }
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Failed to generate structure registry");
        }
    }

    private static string DescribeOptions(GenerationOptions opts)
    {
        var typeSummary = (opts.Types?.Count ?? 0) == 0 ? "(none)" : string.Join(", ", opts.Types);
        return $"Module={opts.Module}, Output={opts.Output}, Config={opts.ConfigPath ?? "(none)"}, VersionLabel={opts.VersionLabel ?? "(auto)"}, Flatten={opts.Flatten}, All={opts.All}, Types={typeSummary}, IncludeDeps={opts.Deps}, EmitDynamic={opts.EmitDynamic}";
    }

    private static string NormalizeVersionLabel(string? label)
    {
        if (string.IsNullOrWhiteSpace(label)) return string.Empty;
        var s = label.Trim();
        // Prefer patterns like 24H2/25H2
        try
        {
            var idx = s.IndexOf("H", StringComparison.OrdinalIgnoreCase);
            if (idx > 0 && idx + 1 < s.Length)
            {
                // Capture preceding two digits and H[12]
                var start = Math.Max(0, idx - 2);
                var maybe = s.Substring(start, Math.Min(3, s.Length - start));
                // e.g., "25H", extend one more char if possible
                if (maybe.Length == 3 && start + 3 < s.Length)
                    maybe += s[start + 3];
                if (maybe.Length >= 3 && char.IsDigit(maybe[0]) && char.IsDigit(maybe[1]) && (maybe[2] == 'H' || maybe[2] == 'h'))
                {
                    var h2 = (maybe.Length >= 4 && (maybe[3] == '1' || maybe[3] == '2')) ? maybe[3].ToString() : "";
                    return "Win" + char.ToUpperInvariant(maybe[0]) + char.ToUpperInvariant(maybe[1]) + "H" + (string.IsNullOrEmpty(h2) ? "" : h2);
                }
            }
        }
        catch { /* best-effort */ }

        // Generic sanitize: remove non-alnum and ensure starts with Win
        var chars = new System.Text.StringBuilder();
        foreach (var ch in s)
        {
            if (char.IsLetterOrDigit(ch)) chars.Append(ch);
        }
        var core = chars.ToString();
        if (core.StartsWith("Win", StringComparison.OrdinalIgnoreCase))
            return core;
        return "Win" + core;
    }

    private static string DetectWindowsVersionLabel()
    {
        try
        {
            using var cv = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            if (cv != null)
            {
                var displayVersion = cv.GetValue("DisplayVersion") as string;
                if (!string.IsNullOrWhiteSpace(displayVersion))
                {
                    var norm = NormalizeVersionLabel("Win" + displayVersion);
                    if (!string.IsNullOrWhiteSpace(norm)) return norm;
                }
                var releaseId = cv.GetValue("ReleaseId") as string;
                if (!string.IsNullOrWhiteSpace(releaseId))
                {
                    var norm = NormalizeVersionLabel("Win" + releaseId);
                    if (!string.IsNullOrWhiteSpace(norm)) return norm;
                }
                var build = (cv.GetValue("CurrentBuild") as string) ?? (cv.GetValue("CurrentBuildNumber") as string) ?? string.Empty;
                var ubrObj = cv.GetValue("UBR");
                var ubr = ubrObj != null ? Convert.ToString(ubrObj) : string.Empty;
                if (!string.IsNullOrWhiteSpace(build))
                {
                    var core = string.IsNullOrWhiteSpace(ubr) ? build : ($"{build}.{ubr}");
                    return NormalizeVersionLabel("WinBuild" + core);
                }
            }
        }
        catch { /* best-effort */ }
        return "WinCurrent";
    }

    private static void TryCleanDirectory(string dir)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(dir)) return;
            if (Directory.Exists(dir)) Directory.Delete(dir, recursive: true);
        }
        catch { /* non-fatal */ }
    }
}
