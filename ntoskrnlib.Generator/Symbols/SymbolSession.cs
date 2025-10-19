using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using ntoskrnlib.Interop;

namespace ntoskrnlib.Symbols;

[SupportedOSPlatform("windows")]
internal sealed class SymbolSession : IDisposable
{
    private readonly IntPtr _process;
    private bool _initialized;
    public ulong ModuleBase { get; private set; }
    public string ModulePath { get; }

    public SymbolSession(string modulePath, string? symbolPath = null)
    {
        if (string.IsNullOrWhiteSpace(modulePath)) throw new ArgumentNullException(nameof(modulePath));
        if (!File.Exists(modulePath)) throw new FileNotFoundException("Module not found", modulePath);
        ModulePath = modulePath;
        _process = Process.GetCurrentProcess().Handle;

        // Hint the loader to find symsrv/dbghelp in Debugging Tools if installed
        TryAddDebuggersToDllSearchPath();

        var opts = DbgHelp.SymGetOptions();
        opts |= DbgHelp.SymOptions.SYMOPT_UNDNAME | DbgHelp.SymOptions.SYMOPT_DEFERRED_LOADS | DbgHelp.SymOptions.SYMOPT_EXACT_SYMBOLS;
        DbgHelp.SymSetOptions(opts);

        symbolPath ??= BuildDefaultSymbolPath();

        if (!DbgHelp.SymInitialize(_process, symbolPath, false))
            throw new InvalidOperationException($"SymInitialize failed: {DbgHelp.GetLastErrorMessage()}");
        _initialized = true;

        if (!DbgHelp.SymSetSearchPath(_process, symbolPath))
            throw new InvalidOperationException($"SymSetSearchPath failed: {DbgHelp.GetLastErrorMessage()}");

        ModuleBase = DbgHelp.SymLoadModuleEx(_process, IntPtr.Zero, modulePath, null, 0, 0, IntPtr.Zero, 0);
        if (ModuleBase == 0)
        {
            throw new InvalidOperationException($"SymLoadModuleEx failed for '{modulePath}': {DbgHelp.GetLastErrorMessage()}");
        }

        var modInfo = new DbgHelp.IMAGEHLP_MODULEW64 { SizeOfStruct = (uint)Marshal.SizeOf<DbgHelp.IMAGEHLP_MODULEW64>() };
        if (DbgHelp.SymGetModuleInfo64(_process, ModuleBase, ref modInfo))
        {
            Console.WriteLine($"[Symbols] Loaded {modInfo.ModuleName} (SymType={modInfo.SymType}, TypeInfo={modInfo.TypeInfo})");
            Console.WriteLine($"[Symbols] PDB: {modInfo.LoadedPdbName}");
            if (!modInfo.TypeInfo)
            {
                Console.WriteLine("[Symbols] Warning: no PDB/type info loaded. Symbol server downloads require symsrv.dll.");
                Console.WriteLine("[Symbols] Install 'Debugging Tools for Windows' (part of Windows SDK) and add its Debuggers\\x64 folder to PATH.");
                Console.WriteLine("[Symbols] Or set _NT_SYMBOL_PATH to an existing local cache containing the PDB.");
            }
        }
    }

    private static void TryAddDebuggersToDllSearchPath()
    {
        try
        {
            var pf86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            var pf = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            var candidates = new[]
            {
                System.IO.Path.Combine(pf86, "Windows Kits", "10", "Debuggers", "x64"),
                System.IO.Path.Combine(pf, "Windows Kits", "10", "Debuggers", "x64"),
                System.IO.Path.Combine(pf86, "Windows Kits", "10", "Debuggers", "x86"),
            };
            foreach (var c in candidates)
            {
                if (System.IO.Directory.Exists(c))
                {
                    DbgHelp.SetDllDirectory(c);
                    var dbghelp = System.IO.Path.Combine(c, "dbghelp.dll");
                    if (System.IO.File.Exists(dbghelp))
                    {
                        DbgHelp.LoadLibrary(dbghelp);
                    }
                    var symsrv = System.IO.Path.Combine(c, "symsrv.dll");
                    if (System.IO.File.Exists(symsrv))
                    {
                        DbgHelp.LoadLibrary(symsrv);
                    }
                }
            }
        }
        catch { }
    }

    public static string BuildDefaultSymbolPath()
    {
        var env = Environment.GetEnvironmentVariable("_NT_SYMBOL_PATH");
        var cache = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "symbols");
        Directory.CreateDirectory(cache);
        var defaultSrv = $"srv*{cache}*https://msdl.microsoft.com/download/symbols";
        if (!string.IsNullOrWhiteSpace(env))
        {
            // Prepend user's _NT_SYMBOL_PATH entries
            return env + ";" + defaultSrv;
        }
        return defaultSrv;
    }

    public void Dispose()
    {
        if (ModuleBase != 0)
        {
            DbgHelp.SymUnloadModule64(_process, ModuleBase);
            ModuleBase = 0;
        }
        if (_initialized)
        {
            DbgHelp.SymCleanup(_process);
            _initialized = false;
        }
    }
}
