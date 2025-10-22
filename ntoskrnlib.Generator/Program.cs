using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ntoskrnlib.Options;
using ntoskrnlib.Services;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace ntoskrnlib;

internal static class Program
{
    [SupportedOSPlatform("windows")]
    private static int Main(string[] args)
    {
        var moduleOpt = new Option<string>(new[] {"--module","-m"})
        {
            Arity = ArgumentArity.ZeroOrOne
        };
        moduleOpt.Description = "Path to module (DLL/EXE) whose PDB to use.";
        moduleOpt.SetDefaultValue(GetDefaultNtPath());

        var typesOpt = new Option<string[]>(new[] {"--types","-t"})
        {
            Arity = ArgumentArity.ZeroOrMore
        };
        typesOpt.Description = "Type names to generate (repeat or comma-separate).";

        var allOpt = new Option<bool>(new[] {"--all","-a"});
        allOpt.Description = "Generate all UDTs in the module.";
        var outOpt = new Option<string>(new[] {"--out","-o"})
        {
            Arity = ArgumentArity.ExactlyOne
        };
        outOpt.Description = "Output directory for .g.cs files.";
        outOpt.SetDefaultValue(Path.Combine(Environment.CurrentDirectory, "out"));

        var flattenOpt = new Option<bool>("--flatten");
        flattenOpt.Description = "Flatten nested UDTs into byte[] fields (single-file friendliness).";
        var depsOpt = new Option<bool>(new[] {"--deps","-d"});
        depsOpt.Description = "Also emit dependent UDTs (when not using --flatten).";
        var configOpt = new Option<string?>(new[] {"--config","-c"})
        {
            Arity = ArgumentArity.ZeroOrOne
        };
        configOpt.Description = "YAML config path (overrides other selectors).";

        var winverOpt = new Option<string?>(new[] {"--winver","-w"})
        {
            Arity = ArgumentArity.ZeroOrOne
        };
        winverOpt.Description = "Windows version label (e.g. Win25H2). Used for output subdir and namespace prefix.";

        var dynOpt = new Option<bool>(new[] {"--emit-dynamic"}, () => true, "Also emit DynamicStructure wrappers.");

        var root = new RootCommand("ntoskrnlib symbol-to-C# generator")
        {
            moduleOpt, typesOpt, allOpt, outOpt, flattenOpt, depsOpt, configOpt, winverOpt, dynOpt
        };

        // Parse and execute inline to avoid handler API differences across RCs
        var parseResult = root.Parse(args);

        string module = parseResult.GetValueForOption(moduleOpt) ?? GetDefaultNtPath();
        var types = new List<string>();
        var rawTypes = parseResult.GetValueForOption(typesOpt);
        if (rawTypes != null)
        {
            foreach (var r in rawTypes)
            {
                if (string.IsNullOrWhiteSpace(r)) continue;
                if (r.Contains(',')) types.AddRange(r.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                else types.Add(r.Trim());
            }
        }
        bool all = parseResult.GetValueForOption(allOpt);
        string output = parseResult.GetValueForOption(outOpt) ?? Path.Combine(Environment.CurrentDirectory, "out");
        bool flatten = parseResult.GetValueForOption(flattenOpt);
        bool deps = parseResult.GetValueForOption(depsOpt);
        string? configPath = parseResult.GetValueForOption(configOpt);
        var verArg = parseResult.GetValueForOption(winverOpt);
        string? versionLabel = string.IsNullOrWhiteSpace(verArg) ? null : verArg;
        bool emitDynamic = parseResult.GetValueForOption(dynOpt);

        if (string.IsNullOrEmpty(configPath) && !all && types.Count == 0)
        {
            types.Add("_EPROCESS");
            flatten = true;
        }

        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddLogging(cfg => cfg.AddSimpleConsole(o => o.SingleLine = true));
        builder.Services.AddSingleton<Abstractions.ISymbolSessionFactory, Services.SymbolSessionFactory>();
        builder.Services.AddSingleton<Abstractions.ICodeGeneratorFactory, Services.CodeGeneratorFactory>();
        builder.Services.AddSingleton<Abstractions.IUdtEmitterFactory, Services.UdtEmitterFactory>();
        builder.Services.AddSingleton<Abstractions.IDiaInspectorFactory, Services.DiaInspectorFactory>();
        builder.Services.AddSingleton<Services.IGenerationRunner, Services.GenerationRunner>();
        using var host = builder.Build();

        var runner = host.Services.GetRequiredService<IGenerationRunner>();
        var opts = new GenerationOptions
        {
            Module = module,
            Types = types,
            All = all,
            Output = output,
            Flatten = flatten,
            ConfigPath = configPath,
            Deps = deps,
            VersionLabel = versionLabel,
            EmitDynamic = emitDynamic,
        };
        try
        {
            return runner.Run(opts);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.ToString());
            return 1;
        }
    }

    

    private static string GetDefaultNtPath()
    {
        var windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        var sys32 = Path.Combine(windir, "System32");
        var nt = Path.Combine(sys32, "ntoskrnl.exe");
        return nt;
    }
}
