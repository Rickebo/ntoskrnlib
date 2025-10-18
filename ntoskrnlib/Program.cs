using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ntoskrnlib.Options;
using ntoskrnlib.Services;

namespace ntoskrnlib;

internal static class Program
{
    [SupportedOSPlatform("windows")]
    private static int Main(string[] args)
    {
        try
        {
            var (module, types, all, output, flatten, configPath, deps) = ParseArgs(args);

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
            };
            return runner.Run(opts);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.ToString());
            Console.Error.WriteLine();
            PrintUsage();
            return 1;
        }
    }

    private static (string module, List<string> types, bool all, string output, bool flatten, string? configPath, bool deps) ParseArgs(string[] args)
    {
        string module = GetDefaultNtPath();
        var types = new List<string>();
        bool all = false;
        string output = Path.Combine(Environment.CurrentDirectory, "out");
        bool flatten = false;
        string? config = null;
        bool deps = false;

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--module":
                case "-m":
                    module = args[++i];
                    break;
                case "--types":
                case "-t":
                    types.AddRange(args[++i].Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                    break;
                case "--all":
                case "-a":
                    all = true;
                    break;
                case "--out":
                case "-o":
                    output = args[++i];
                    break;
                case "--flatten":
                    flatten = true;
                    break;
                case "--deps":
                case "-d":
                    deps = true;
                    break;
                case "--config":
                case "-c":
                    config = args[++i];
                    break;
                case "--help":
                case "-h":
                    throw new InvalidOperationException("help");
                default:
                    throw new ArgumentException($"Unknown arg: {args[i]}");
            }
        }

        if (string.IsNullOrEmpty(config) && !all && types.Count == 0)
        {
            // Default to _EPROCESS only if nothing specified
            types.Add("_EPROCESS");
            flatten = true; // keep it to a single file by default
        }

        return (module, types, all, output, flatten, config, deps);
    }

    private static void PrintUsage()
    {
        Console.WriteLine("ntoskrnlib symbol-to-C# generator");
        Console.WriteLine();
        Console.WriteLine("Usage:");
        Console.WriteLine("  dotnet run -- -m <modulePath> -t <type1,type2,...> -o <outDir>");
        Console.WriteLine("  dotnet run -- -m <modulePath> --all -o <outDir>");
        Console.WriteLine("  dotnet run -- --config config\\types.yml -o ntoskrnlib.Types\\Generated");
        Console.WriteLine();
        Console.WriteLine("Examples:");
        Console.WriteLine("  dotnet run -- -m C\\\\Windows\\\\System32\\\\ntoskrnl.exe -t _EPROCESS --flatten -o gen");
        Console.WriteLine("  dotnet run -- -m C\\\\Windows\\\\System32\\\\ntdll.dll -t _PEB -o gen");
        Console.WriteLine("  dotnet run --            (defaults to _EPROCESS with --flatten)");
    }

    private static string GetDefaultNtPath()
    {
        var windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        var sys32 = Path.Combine(windir, "System32");
        var nt = Path.Combine(sys32, "ntoskrnl.exe");
        return nt;
    }
}
