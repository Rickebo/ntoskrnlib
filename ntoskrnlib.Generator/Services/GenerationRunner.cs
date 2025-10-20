using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Logging;
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
        if (!string.IsNullOrEmpty(opts.ConfigPath))
            return RunFromConfig(opts.ConfigPath!, opts.Output);

        Directory.CreateDirectory(opts.Output);

        using var session = _sessionFactory.Create(opts.Module);
        var insp = new TypeInspector(session);
        var (moduleId, ns) = DeriveModuleInfo(opts.Module);
        var gen = _codeGenFactory.Create(insp, opts.Flatten, ns);
        var emitter = _emitterFactory.Create(insp, gen);
        var outRoot = opts.Output;
        var outDir = Path.Combine(outRoot, moduleId);
        Directory.CreateDirectory(outDir);

        var targets = new List<(uint typeId, string name)>();
        if (opts.All)
        {
            _log.LogInformation("Enumerating UDTs from {module}", opts.Module);
            bool usedDbgHelp = false;
            try
            {
                var udts = new List<(uint typeId, string name)>(insp.EnumerateUdts());
                if (udts.Count > 0)
                {
                    targets.AddRange(udts);
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
                var dia = _diaFactory.TryCreate(opts.Module, SymbolSession.BuildDefaultSymbolPath());
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
            foreach (var t in opts.Types)
            {
                var name = t;
                if (!insp.TryGetTypeIdByName(name, out var typeId))
                {
                    _log.LogWarning("Type not found via DbgHelp: {name}; trying DIA...", name);
                    var dia = _diaFactory.TryCreate(opts.Module, SymbolSession.BuildDefaultSymbolPath());
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
            }
        }

        int written = 0;
        foreach (var (typeId, name) in targets)
        {
            try
            {
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

    private static (string moduleId, string ns) DeriveModuleInfo(string module)
    {
        var baseName = Path.GetFileNameWithoutExtension(module).ToLowerInvariant();
        string moduleId = baseName switch
        {
            "ntkrnlmp" or "ntkrnlpa" => "ntoskrnl",
            _ => baseName
        };
        string ns = $"ntoskrnlib.{moduleId}";
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
    }

    private int RunFromConfig(string configPath, string output)
    {
        var yaml = File.ReadAllText(configPath);
        var y = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
        var root = y.Deserialize<ConfigRoot>(yaml);
        if (root == null || root.Types == null)
        {
            _log.LogError("Invalid config: 'types' not found");
            return 2;
        }
        int total = 0;
        foreach (var ce in root.Types)
        {
            var module = ce.Module.Replace("ntoskrnlib_placeholder.exe", "ntoskrnl.exe");
            using var session = _sessionFactory.Create(module);
            var insp = new TypeInspector(session);
            var (moduleId, ns) = DeriveModuleInfo(module);
            var gen = _codeGenFactory.Create(insp, ce.Flatten, ns);
            var emitter = _emitterFactory.Create(insp, gen);
            var outDir = Path.Combine(output, moduleId);
            Directory.CreateDirectory(outDir);

            if (ce.All)
            {
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
                    var dia = _diaFactory.TryCreate(module, SymbolSession.BuildDefaultSymbolPath());
                    if (dia != null)
                    {
                        var emitterDia = new DiaEmitter(dia, ns);
                        foreach (var name in dia.EnumerateUdts())
                        {
                            try { total += emitterDia.GenerateWithDependencies(name, outDir, ce.Flatten); }
                            catch (Exception genEx) { _log.LogWarning(genEx, "Failed generating {name} via DIA", name); }
                        }
                    }
                    else
                    {
                        _log.LogError("DIA not available; cannot enumerate UDTs for module {module}", module);
                    }
                }
                continue;
            }

            foreach (var name in ce.Names)
            {
                if (insp.TryGetTypeIdByName(name, out var typeId))
                {
                    total += emitter.GenerateWithDependencies(typeId, outDir, ce.Flatten);
                    continue;
                }

                // Fallback to DIA like the direct CLI path
                _log.LogWarning("Type not found via DbgHelp: {name}; trying DIA...", name);
                var dia = _diaFactory.TryCreate(module, SymbolSession.BuildDefaultSymbolPath());
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
        _log.LogInformation("Generated {count} file(s) into '{output}'", total, output);
        return 0;
    }
}
