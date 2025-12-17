using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace ntoskrnlib.Interop;

[SupportedOSPlatform("windows")]
internal static class DbgHelp
{
    // Options flags for SymSetOptions
    [Flags]
    internal enum SymOptions : uint
    {
        SYMOPT_CASE_INSENSITIVE = 0x00000001,
        SYMOPT_UNDNAME = 0x00000002,
        SYMOPT_DEFERRED_LOADS = 0x00000004,
        SYMOPT_NO_CPP = 0x00000008,
        SYMOPT_LOAD_LINES = 0x00000010,
        SYMOPT_OMAP_FIND_NEAREST = 0x00000020,
        SYMOPT_LOAD_ANYTHING = 0x00000040,
        SYMOPT_IGNORE_CVREC = 0x00000080,
        SYMOPT_NO_UNQUALIFIED_LOADS = 0x00000100,
        SYMOPT_FAIL_CRITICAL_ERRORS = 0x00000200,
        SYMOPT_EXACT_SYMBOLS = 0x00000400,
        SYMOPT_ALLOW_ABSOLUTE_SYMBOLS = 0x00000800,
        SYMOPT_IGNORE_NT_SYMPATH = 0x00001000,
        SYMOPT_INCLUDE_32BIT_MODULES = 0x00002000,
        SYMOPT_PUBLICS_ONLY = 0x00004000,
        SYMOPT_NO_PUBLICS = 0x00008000,
        SYMOPT_AUTO_PUBLICS = 0x00010000,
        SYMOPT_NO_IMAGE_SEARCH = 0x00020000,
        SYMOPT_SECURE = 0x00040000,
        SYMOPT_NO_PROMPTS = 0x00080000,
        SYMOPT_OVERWRITE = 0x00100000,
        SYMOPT_IGNORE_IMAGEDIR = 0x00200000,
        SYMOPT_FLAT_DIRECTORY = 0x00400000,
        SYMOPT_FAVOR_COMPRESSED = 0x00800000,
        SYMOPT_ALLOW_ZERO_ADDRESS = 0x01000000,
        SYMOPT_DISABLE_SYMSRV_AUTODETECT = 0x02000000,
        SYMOPT_DEBUG = 0x80000000,
    }

    internal enum SymTag : uint
    {
        Null,
        Exe,
        Compiland,
        CompilandDetails,
        CompilandEnv,
        Function,
        Block,
        Data,
        Annotation,
        Label,
        PublicSymbol,
        UDT,
        Enum,
        FunctionType,
        PointerType,
        ArrayType,
        BaseType,
        Typedef,
        BaseClass,
        Friend,
        FunctionArgType,
        FuncDebugStart,
        FuncDebugEnd,
        UsingNamespace,
        VTableShape,
        VTable,
        Custom,
        Thunk,
        CustomType,
        ManagedType,
        Dimension,
        CallSite,
        InlineSite,
        BaseInterface,
        VectorType,
        MatrixType,
        HLSLType,
        Caller,
        Callee,
        Export,
        HeapAllocationSite,
        CoffGroup,
        Inlinee,
        Max
    }

    internal enum SymType : uint
    {
        SymNone = 0,
        SymCoff,
        SymCv,
        SymPdb,
        SymExport,
        SymDeferred,
        SymSym,
        SymDia,
        SymVirtual,
    }

    internal enum BasicType : uint
    {
        btNoType = 0,
        btVoid = 1,
        btChar = 2,
        btWChar = 3,
        btInt = 6,
        btUInt = 7,
        btFloat = 8,
        btBCD = 9,
        btBool = 10,
        btLong = 13,
        btULong = 14,
        btCurrency = 25,
        btDate = 26,
        btVariant = 27,
        btComplex = 28,
        btBit = 29,
        btBSTR = 30,
        btHresult = 31
    }

    internal enum DataKind : uint
    {
        DataIsUnknown,
        DataIsLocal,
        DataIsStaticLocal,
        DataIsParam,
        DataIsObjectPtr,
        DataIsFileStatic,
        DataIsGlobal,
        DataIsMember,
        DataIsStaticMember,
        DataIsConstant
    }

    internal enum UdtKind : uint
    {
        UdtStruct,
        UdtClass,
        UdtUnion
    }

    // IMAGEHLP_SYMBOL_TYPE_INFO (dbghelp.h) values are sequential starting at 0.
    // Only define the ones used by this project.
    internal const uint TI_GET_SYMTAG = 0;          // TI_GET_SYMTAG
    internal const uint TI_GET_NAME = 1;            // TI_GET_SYMNAME
    internal const uint TI_GET_LENGTH = 2;          // TI_GET_LENGTH
    internal const uint TI_GET_TYPEID = 4;          // TI_GET_TYPEID
    internal const uint TI_GET_BASETYPE = 5;        // TI_GET_BASETYPE
    internal const uint TI_GET_ARRAYINDEXTYPEID = 6;// TI_GET_ARRAYINDEXTYPEID
    internal const uint TI_FINDCHILDREN = 7;        // TI_FINDCHILDREN
    internal const uint TI_GET_DATAKIND = 8;        // TI_GET_DATAKIND
    internal const uint TI_GET_OFFSET = 10;         // TI_GET_OFFSET
    internal const uint TI_GET_ARRAYCOUNT = 12;     // TI_GET_COUNT
    internal const uint TI_GET_CHILDRENCOUNT = 13;  // TI_GET_CHILDRENCOUNT
    internal const uint TI_GET_BITPOSITION = 14;    // TI_GET_BITPOSITION
    internal const uint TI_GET_UDTKIND = 24;        // TI_GET_UDTKIND

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct SYMBOL_INFO
    {
        public uint SizeOfStruct;      // set to (uint)Marshal.SizeOf<SYMBOL_INFO>()
        public uint TypeIndex;         // type id
        public fixed ulong Reserved[2];
        public uint Index;
        public uint Size;
        public ulong ModBase;
        public uint Flags;
        public ulong Value;
        public ulong Address;
        public uint Register;
        public uint Scope;
        public uint Tag;
        public uint NameLen;
        public uint MaxNameLen;
        public byte Name; // first char of ANSI name (flexible array)
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct TI_FINDCHILDREN_PARAMS
    {
        public uint Count;
        public uint Start;
        // Followed by Count uints of ChildId
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct IMAGEHLP_MODULEW64
    {
        public uint SizeOfStruct;
        public ulong BaseOfImage;
        public uint ImageSize;
        public uint TimeDateStamp;
        public uint CheckSum;
        public uint NumSyms;
        public SymType SymType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ModuleName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string ImageName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string LoadedImageName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string LoadedPdbName;
        public uint CVSig;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 780)]
        public string CVData;
        public uint PdbSig;
        public Guid PdbSig70;
        public uint PdbAge;
        [MarshalAs(UnmanagedType.Bool)]
        public bool PdbUnmatched;
        [MarshalAs(UnmanagedType.Bool)]
        public bool DbgUnmatched;
        [MarshalAs(UnmanagedType.Bool)]
        public bool LineNumbers;
        [MarshalAs(UnmanagedType.Bool)]
        public bool GlobalSymbols;
        [MarshalAs(UnmanagedType.Bool)]
        public bool TypeInfo;
        [MarshalAs(UnmanagedType.Bool)]
        public bool SourceIndexed;
        [MarshalAs(UnmanagedType.Bool)]
        public bool Publics;
        public uint MachineType;
        public uint Reserved;
    }

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal unsafe delegate bool SymEnumTypesProc(SYMBOL_INFO* pSymInfo, uint SymbolSize, IntPtr UserContext);

    [DllImport("dbghelp.dll", SetLastError = true)]
    internal static extern SymOptions SymGetOptions();

    [DllImport("dbghelp.dll", SetLastError = true)]
    internal static extern SymOptions SymSetOptions(SymOptions SymOptions);

    [DllImport("dbghelp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern bool SymInitialize(IntPtr hProcess, string? UserSearchPath, bool fInvadeProcess);

    [DllImport("dbghelp.dll", SetLastError = true)]
    internal static extern bool SymCleanup(IntPtr hProcess);

    [DllImport("dbghelp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern bool SymSetSearchPath(IntPtr hProcess, string SearchPath);

    [DllImport("dbghelp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern ulong SymLoadModuleEx(
        IntPtr hProcess,
        IntPtr hFile,
        string ImageName,
        string? ModuleName,
        ulong BaseOfDll,
        uint DllSize,
        IntPtr Data,
        uint Flags);

    [DllImport("dbghelp.dll", SetLastError = true)]
    internal static extern bool SymUnloadModule64(IntPtr hProcess, ulong BaseOfDll);

    [DllImport("dbghelp.dll", CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "SymGetModuleInfoW64")]
    internal static extern bool SymGetModuleInfo64(
        IntPtr hProcess,
        ulong qwAddr,
        ref IMAGEHLP_MODULEW64 ModuleInfo
    );

    [DllImport("dbghelp.dll", CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "SymGetTypeFromNameW")]
    internal static extern unsafe bool SymGetTypeFromName(
        IntPtr hProcess,
        ulong BaseOfDll,
        string name,
        IntPtr pSymbolInfo // pointer to SYMBOL_INFO buffer with SizeOfStruct/MaxNameLen set
    );

    [DllImport("dbghelp.dll", SetLastError = true)]
    internal static extern unsafe bool SymEnumTypes(
        IntPtr hProcess,
        ulong BaseOfDll,
        SymEnumTypesProc enumSymbolsCallback,
        IntPtr UserContext);

    [DllImport("dbghelp.dll", CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "SymEnumTypesByNameW")]
    internal static extern unsafe bool SymEnumTypesByName(
        IntPtr hProcess,
        ulong BaseOfDll,
        string mask,
        SymEnumTypesProc enumSymbolsCallback,
        IntPtr UserContext);

    private enum SymGetTypeInfoEntryPoint
    {
        Unknown = 0,
        Wide = 1,
        Plain = 2,
        Ansi = 3
    }

    private static volatile SymGetTypeInfoEntryPoint _symGetTypeInfoEntryPoint = SymGetTypeInfoEntryPoint.Unknown;
    private static readonly object SymGetTypeInfoLock = new();

    internal static bool SymGetTypeInfoReturnsUnicodeStrings
        => ResolveSymGetTypeInfoEntryPoint() != SymGetTypeInfoEntryPoint.Ansi;

    private static SymGetTypeInfoEntryPoint ResolveSymGetTypeInfoEntryPoint()
    {
        var cached = _symGetTypeInfoEntryPoint;
        if (cached != SymGetTypeInfoEntryPoint.Unknown)
        {
            return cached;
        }

        lock (SymGetTypeInfoLock)
        {
            cached = _symGetTypeInfoEntryPoint;
            if (cached != SymGetTypeInfoEntryPoint.Unknown)
            {
                return cached;
            }

            // Ensure dbghelp.dll is loaded. SymbolSession will usually load it first, but this keeps DbgHelp robust.
            var hDbgHelp = GetModuleHandle("dbghelp.dll");
            if (hDbgHelp == IntPtr.Zero)
            {
                hDbgHelp = LoadLibrary("dbghelp.dll");
            }

            if (hDbgHelp != IntPtr.Zero)
            {
                if (GetProcAddress(hDbgHelp, "SymGetTypeInfoW") != IntPtr.Zero)
                {
                    cached = SymGetTypeInfoEntryPoint.Wide;
                }
                else if (GetProcAddress(hDbgHelp, "SymGetTypeInfo") != IntPtr.Zero)
                {
                    cached = SymGetTypeInfoEntryPoint.Plain;
                }
                else if (GetProcAddress(hDbgHelp, "SymGetTypeInfoA") != IntPtr.Zero)
                {
                    cached = SymGetTypeInfoEntryPoint.Ansi;
                }
                else
                {
                    // Best-effort: fall back to plain and let P/Invoke surface any issues.
                    cached = SymGetTypeInfoEntryPoint.Plain;
                }
            }
            else
            {
                cached = SymGetTypeInfoEntryPoint.Plain;
            }

            _symGetTypeInfoEntryPoint = cached;
            return cached;
        }
    }

    [DllImport("dbghelp.dll", SetLastError = true, EntryPoint = "SymGetTypeInfo")]
    private static extern bool SymGetTypeInfoPlain(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        IntPtr pInfo);

    [DllImport("dbghelp.dll", SetLastError = true, EntryPoint = "SymGetTypeInfoW")]
    private static extern bool SymGetTypeInfoWide(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        IntPtr pInfo);

    [DllImport("dbghelp.dll", SetLastError = true, EntryPoint = "SymGetTypeInfoA")]
    private static extern bool SymGetTypeInfoAnsi(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        IntPtr pInfo);

    private static bool SymGetTypeInfoRaw(
        IntPtr hProcess,
        ulong modBase,
        uint typeId,
        uint getWhat,
        IntPtr pInfo)
    {
        return ResolveSymGetTypeInfoEntryPoint() switch
        {
            SymGetTypeInfoEntryPoint.Wide => SymGetTypeInfoWide(hProcess, modBase, typeId, getWhat, pInfo),
            SymGetTypeInfoEntryPoint.Ansi => SymGetTypeInfoAnsi(hProcess, modBase, typeId, getWhat, pInfo),
            _ => SymGetTypeInfoPlain(hProcess, modBase, typeId, getWhat, pInfo)
        };
    }

    internal static unsafe bool SymGetTypeInfo(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        out ulong pInfo)
    {
        ulong value = 0;
        var ok = SymGetTypeInfoRaw(hProcess, ModBase, TypeId, GetWhat, (IntPtr)(&value));
        pInfo = value;
        return ok;
    }

    internal static unsafe bool SymGetTypeInfo(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        out uint pInfo)
    {
        uint value = 0;
        var ok = SymGetTypeInfoRaw(hProcess, ModBase, TypeId, GetWhat, (IntPtr)(&value));
        pInfo = value;
        return ok;
    }

    internal static unsafe bool SymGetTypeInfo(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        out int pInfo)
    {
        int value = 0;
        var ok = SymGetTypeInfoRaw(hProcess, ModBase, TypeId, GetWhat, (IntPtr)(&value));
        pInfo = value;
        return ok;
    }

    internal static unsafe bool SymGetTypeInfo(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        out IntPtr pInfo)
    {
        IntPtr value = IntPtr.Zero;
        var ok = SymGetTypeInfoRaw(hProcess, ModBase, TypeId, GetWhat, (IntPtr)(&value));
        pInfo = value;
        return ok;
    }

    internal static bool SymGetTypeInfo(
        IntPtr hProcess,
        ulong ModBase,
        uint TypeId,
        uint GetWhat,
        IntPtr pInfo)
    {
        return SymGetTypeInfoRaw(hProcess, ModBase, TypeId, GetWhat, pInfo);
    }

    [DllImport("kernel32.dll")]
    internal static extern IntPtr LocalFree(IntPtr hMem);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern bool SetDllDirectory(string lpPathName);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern IntPtr LoadLibrary(string lpFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    internal static string GetLastErrorMessage()
    {
        var err = Marshal.GetLastWin32Error();
        return new Win32Exception(err).Message + $" (0x{err:X})";
    }
}
