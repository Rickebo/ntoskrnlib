#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4152)]
    public partial struct _TEB32
    {
        [FieldOffset(0)]
        public _NT_TIB32 NtTib;
        [FieldOffset(28)]
        public uint EnvironmentPointer;
        [FieldOffset(32)]
        public _CLIENT_ID32 ClientId;
        [FieldOffset(40)]
        public uint ActiveRpcHandle;
        [FieldOffset(44)]
        public uint ThreadLocalStoragePointer;
        [FieldOffset(48)]
        public uint ProcessEnvironmentBlock;
        [FieldOffset(52)]
        public uint LastErrorValue;
        [FieldOffset(56)]
        public uint CountOfOwnedCriticalSections;
        [FieldOffset(60)]
        public uint CsrClientThread;
        [FieldOffset(64)]
        public uint Win32ThreadInfo;
        [FieldOffset(68)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public uint[] User32Reserved;
        [FieldOffset(172)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] UserReserved;
        [FieldOffset(192)]
        public uint WOW32Reserved;
        [FieldOffset(196)]
        public uint CurrentLocale;
        [FieldOffset(200)]
        public uint FpSoftwareStatusRegister;
        [FieldOffset(204)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] ReservedForDebuggerInstrumentation;
        [FieldOffset(268)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public uint[] SystemReserved1;
        [FieldOffset(352)]
        public uint HeapFlsData;
        [FieldOffset(356)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] RngState;
        [FieldOffset(372)]
        public sbyte PlaceholderCompatibilityMode;
        [FieldOffset(373)]
        public byte PlaceholderHydrationAlwaysExplicit;
        [FieldOffset(374)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public sbyte[] PlaceholderReserved;
        [FieldOffset(384)]
        public uint ProxiedProcessId;
        [FieldOffset(388)]
        public _ACTIVATION_CONTEXT_STACK32 _ActivationStack;
        [FieldOffset(412)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] WorkingOnBehalfTicket;
        [FieldOffset(420)]
        public int ExceptionCode;
        [FieldOffset(424)]
        public uint ActivationContextStackPointer;
        [FieldOffset(428)]
        public uint InstrumentationCallbackSp;
        [FieldOffset(432)]
        public uint InstrumentationCallbackPreviousPc;
        [FieldOffset(436)]
        public uint InstrumentationCallbackPreviousSp;
        [FieldOffset(440)]
        public byte InstrumentationCallbackDisabled;
        [FieldOffset(441)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 23)]
        public byte[] SpareBytes;
        [FieldOffset(464)]
        public uint TxFsContext;
        [FieldOffset(468)]
        public _GDI_TEB_BATCH32 GdiTebBatch;
        [FieldOffset(1716)]
        public _CLIENT_ID32 RealClientId;
        [FieldOffset(1724)]
        public uint GdiCachedProcessHandle;
        [FieldOffset(1728)]
        public uint GdiClientPID;
        [FieldOffset(1732)]
        public uint GdiClientTID;
        [FieldOffset(1736)]
        public uint GdiThreadLocalInfo;
        [FieldOffset(1740)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62)]
        public uint[] Win32ClientInfo;
        [FieldOffset(1988)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 233)]
        public uint[] glDispatchTable;
        [FieldOffset(2920)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 29)]
        public uint[] glReserved1;
        [FieldOffset(3036)]
        public uint glReserved2;
        [FieldOffset(3040)]
        public uint glSectionInfo;
        [FieldOffset(3044)]
        public uint glSection;
        [FieldOffset(3048)]
        public uint glTable;
        [FieldOffset(3052)]
        public uint glCurrentRC;
        [FieldOffset(3056)]
        public uint glContext;
        [FieldOffset(3060)]
        public uint LastStatusValue;
        [FieldOffset(3064)]
        public _STRING32 StaticUnicodeString;
        [FieldOffset(3072)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 261)]
        public short[] StaticUnicodeBuffer;
        [FieldOffset(3596)]
        public uint DeallocationStack;
        [FieldOffset(3600)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] TlsSlots;
        [FieldOffset(3856)]
        public LIST_ENTRY32 TlsLinks;
        [FieldOffset(3864)]
        public uint Vdm;
        [FieldOffset(3868)]
        public uint ReservedForNtRpc;
        [FieldOffset(3872)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] DbgSsReserved;
        [FieldOffset(3880)]
        public uint HardErrorMode;
        [FieldOffset(3884)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public uint[] Instrumentation;
        [FieldOffset(3920)]
        public _GUID ActivityId;
        [FieldOffset(3936)]
        public uint SubProcessTag;
        [FieldOffset(3940)]
        public uint PerflibData;
        [FieldOffset(3944)]
        public uint EtwTraceData;
        [FieldOffset(3948)]
        public uint WinSockData;
        [FieldOffset(3952)]
        public uint GdiBatchCount;
        [FieldOffset(3956)]
        public _PROCESSOR_NUMBER CurrentIdealProcessor;
        [FieldOffset(3956)]
        public uint IdealProcessorValue;
        [FieldOffset(3956)]
        public byte ReservedPad0;
        [FieldOffset(3957)]
        public byte ReservedPad1;
        [FieldOffset(3958)]
        public byte ReservedPad2;
        [FieldOffset(3959)]
        public byte IdealProcessor;
        [FieldOffset(3960)]
        public uint GuaranteedStackBytes;
        [FieldOffset(3964)]
        public uint ReservedForPerf;
        [FieldOffset(3968)]
        public uint ReservedForOle;
        [FieldOffset(3972)]
        public uint WaitingOnLoaderLock;
        [FieldOffset(3976)]
        public uint SavedPriorityState;
        [FieldOffset(3980)]
        public uint ReservedForCodeCoverage;
        [FieldOffset(3984)]
        public uint ThreadPoolData;
        [FieldOffset(3988)]
        public uint TlsExpansionSlots;
        [FieldOffset(3992)]
        public uint MuiGeneration;
        [FieldOffset(3996)]
        public uint IsImpersonating;
        [FieldOffset(4000)]
        public uint NlsCache;
        [FieldOffset(4004)]
        public uint pShimData;
        [FieldOffset(4008)]
        public uint HeapData;
        [FieldOffset(4012)]
        public uint CurrentTransactionHandle;
        [FieldOffset(4016)]
        public uint ActiveFrame;
        [FieldOffset(4020)]
        public uint FlsData;
        [FieldOffset(4024)]
        public uint PreferredLanguages;
        [FieldOffset(4028)]
        public uint UserPrefLanguages;
        [FieldOffset(4032)]
        public uint MergedPrefLanguages;
        [FieldOffset(4036)]
        public uint MuiImpersonation;
        [FieldOffset(4040)]
        public ushort CrossTebFlags;
        [FieldOffset(4040)]
        public ushort SpareCrossTebBits;
        [FieldOffset(4042)]
        public ushort SameTebFlags;
        [FieldOffset(4042)]
        public ushort SafeThunkCall;
        [FieldOffset(4042)]
        public ushort InDebugPrint;
        [FieldOffset(4042)]
        public ushort HasFiberData;
        [FieldOffset(4042)]
        public ushort SkipThreadAttach;
        [FieldOffset(4042)]
        public ushort WerInShipAssertCode;
        [FieldOffset(4042)]
        public ushort RanProcessInit;
        [FieldOffset(4042)]
        public ushort ClonedThread;
        [FieldOffset(4042)]
        public ushort SuppressDebugMsg;
        [FieldOffset(4042)]
        public ushort DisableUserStackWalk;
        [FieldOffset(4042)]
        public ushort RtlExceptionAttached;
        [FieldOffset(4042)]
        public ushort InitialThread;
        [FieldOffset(4042)]
        public ushort SessionAware;
        [FieldOffset(4042)]
        public ushort LoadOwner;
        [FieldOffset(4042)]
        public ushort LoaderWorker;
        [FieldOffset(4042)]
        public ushort SkipLoaderInit;
        [FieldOffset(4042)]
        public ushort SkipFileAPIBrokering;
        [FieldOffset(4044)]
        public uint TxnScopeEnterCallback;
        [FieldOffset(4048)]
        public uint TxnScopeExitCallback;
        [FieldOffset(4052)]
        public uint TxnScopeContext;
        [FieldOffset(4056)]
        public uint LockCount;
        [FieldOffset(4060)]
        public int WowTebOffset;
        [FieldOffset(4064)]
        public uint ResourceRetValue;
        [FieldOffset(4068)]
        public uint ReservedForWdf;
        [FieldOffset(4072)]
        public ulong ReservedForCrt;
        [FieldOffset(4080)]
        public _GUID EffectiveContainerId;
        [FieldOffset(4096)]
        public ulong LastSleepCounter;
        [FieldOffset(4104)]
        public uint SpinCallCount;
        [FieldOffset(4112)]
        public ulong ExtendedFeatureDisableMask;
        [FieldOffset(4120)]
        public uint SchedulerSharedDataSlot;
        [FieldOffset(4124)]
        public uint HeapWalkContext;
        [FieldOffset(4128)]
        public _GROUP_AFFINITY32 PrimaryGroupAffinity;
        [FieldOffset(4140)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Rcu;
    }
}