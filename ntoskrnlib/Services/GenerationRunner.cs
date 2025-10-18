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
        var ns = DeriveNamespaceFromModule(opts.Module);
        var gen = _codeGenFactory.Create(insp, opts.Flatten, ns);
        var emitter = _emitterFactory.Create(insp, gen);

        var targets = new List<(uint typeId, string name)>();
        if (opts.All)
        {
            _log.LogInformation("Enumerating UDTs from {module}", opts.Module);
            targets.AddRange(insp.EnumerateUdts());
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
                        var code = ProgramHelpers.GenerateFromDia(name, dia, udt, opts.Flatten);
                        File.WriteAllText(Path.Combine(opts.Output, ProgramHelpers.Sanitize(name) + ".g.cs"), code);
                    }
                    else
                    {
                        var emitterDia = new DiaEmitter(dia);
                        var count = emitterDia.GenerateWithDependencies(name, opts.Output, opts.Flatten);
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
                written += emitter.GenerateWithDependencies(typeId, opts.Output, opts.Flatten);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Failed generating {name}", name);
            }
        }
        _log.LogInformation("Generated {count} file(s) into '{output}'", written, opts.Output);
        return 0;
    }

    private static string DeriveNamespaceFromModule(string module)
    {
        var baseName = Path.GetFileNameWithoutExtension(module).ToLowerInvariant();
        return baseName switch
        {
            "ntoskrnl" or "ntkrnlmp" or "ntkrnlpa" => "Windows.Nt",
            "ntdll" => "Windows.Ntdll",
            _ => "Windows"
        };
    }

    private sealed class ConfigEntry
    {
        [YamlMember(Alias = "module")] public string Module { get; set; } = string.Empty;
        [YamlMember(Alias = "flatten")] public bool Flatten { get; set; }
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
            var ns = DeriveNamespaceFromModule(module);
            var gen = _codeGenFactory.Create(insp, ce.Flatten, ns);
            var emitter = _emitterFactory.Create(insp, gen);
            Directory.CreateDirectory(output);
            foreach (var name in ce.Names)
            {
                if (!insp.TryGetTypeIdByName(name, out var typeId))
                {
                    _log.LogWarning("Type not found: {name} in {module}", name, module);
                    continue;
                }
                total += emitter.GenerateWithDependencies(typeId, output, ce.Flatten);
            }
        }
        _log.LogInformation("Generated {count} file(s) into '{output}'", total, output);
        return 0;
    }
}
