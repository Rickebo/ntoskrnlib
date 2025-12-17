#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 6264)]
    public partial struct _TEB64
    {
        [FieldOffset(0)]
        public _NT_TIB64 NtTib;
        [FieldOffset(56)]
        public ulong EnvironmentPointer;
        [FieldOffset(64)]
        public _CLIENT_ID64 ClientId;
        [FieldOffset(80)]
        public ulong ActiveRpcHandle;
        [FieldOffset(88)]
        public ulong ThreadLocalStoragePointer;
        [FieldOffset(96)]
        public ulong ProcessEnvironmentBlock;
        [FieldOffset(104)]
        public uint LastErrorValue;
        [FieldOffset(108)]
        public uint CountOfOwnedCriticalSections;
        [FieldOffset(112)]
        public ulong CsrClientThread;
        [FieldOffset(120)]
        public ulong Win32ThreadInfo;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public uint[] User32Reserved;
        [FieldOffset(232)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] UserReserved;
        [FieldOffset(256)]
        public ulong WOW32Reserved;
        [FieldOffset(264)]
        public uint CurrentLocale;
        [FieldOffset(268)]
        public uint FpSoftwareStatusRegister;
        [FieldOffset(272)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ulong[] ReservedForDebuggerInstrumentation;
        [FieldOffset(400)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
        public ulong[] SystemReserved1;
        [FieldOffset(600)]
        public ulong HeapFlsData;
        [FieldOffset(608)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] RngState;
        [FieldOffset(640)]
        public sbyte PlaceholderCompatibilityMode;
        [FieldOffset(641)]
        public byte PlaceholderHydrationAlwaysExplicit;
        [FieldOffset(642)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public sbyte[] PlaceholderReserved;
        [FieldOffset(652)]
        public uint ProxiedProcessId;
        [FieldOffset(656)]
        public _ACTIVATION_CONTEXT_STACK64 _ActivationStack;
        [FieldOffset(696)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] WorkingOnBehalfTicket;
        [FieldOffset(704)]
        public int ExceptionCode;
        [FieldOffset(708)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding0;
        [FieldOffset(712)]
        public ulong ActivationContextStackPointer;
        [FieldOffset(720)]
        public ulong InstrumentationCallbackSp;
        [FieldOffset(728)]
        public ulong InstrumentationCallbackPreviousPc;
        [FieldOffset(736)]
        public ulong InstrumentationCallbackPreviousSp;
        [FieldOffset(744)]
        public uint TxFsContext;
        [FieldOffset(748)]
        public byte InstrumentationCallbackDisabled;
        [FieldOffset(749)]
        public byte UnalignedLoadStoreExceptions;
        [FieldOffset(750)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Padding1;
        [FieldOffset(752)]
        public _GDI_TEB_BATCH64 GdiTebBatch;
        [FieldOffset(2008)]
        public _CLIENT_ID64 RealClientId;
        [FieldOffset(2024)]
        public ulong GdiCachedProcessHandle;
        [FieldOffset(2032)]
        public uint GdiClientPID;
        [FieldOffset(2036)]
        public uint GdiClientTID;
        [FieldOffset(2040)]
        public ulong GdiThreadLocalInfo;
        [FieldOffset(2048)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62)]
        public ulong[] Win32ClientInfo;
        [FieldOffset(2544)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 233)]
        public ulong[] glDispatchTable;
        [FieldOffset(4408)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 29)]
        public ulong[] glReserved1;
        [FieldOffset(4640)]
        public ulong glReserved2;
        [FieldOffset(4648)]
        public ulong glSectionInfo;
        [FieldOffset(4656)]
        public ulong glSection;
        [FieldOffset(4664)]
        public ulong glTable;
        [FieldOffset(4672)]
        public ulong glCurrentRC;
        [FieldOffset(4680)]
        public ulong glContext;
        [FieldOffset(4688)]
        public uint LastStatusValue;
        [FieldOffset(4692)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding2;
        [FieldOffset(4696)]
        public _STRING64 StaticUnicodeString;
        [FieldOffset(4712)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 261)]
        public short[] StaticUnicodeBuffer;
        [FieldOffset(5234)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Padding3;
        [FieldOffset(5240)]
        public ulong DeallocationStack;
        [FieldOffset(5248)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ulong[] TlsSlots;
        [FieldOffset(5760)]
        public LIST_ENTRY64 TlsLinks;
        [FieldOffset(5776)]
        public ulong Vdm;
        [FieldOffset(5784)]
        public ulong ReservedForNtRpc;
        [FieldOffset(5792)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] DbgSsReserved;
        [FieldOffset(5808)]
        public uint HardErrorMode;
        [FieldOffset(5812)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding4;
        [FieldOffset(5816)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public ulong[] Instrumentation;
        [FieldOffset(5904)]
        public _GUID ActivityId;
        [FieldOffset(5920)]
        public ulong SubProcessTag;
        [FieldOffset(5928)]
        public ulong PerflibData;
        [FieldOffset(5936)]
        public ulong EtwTraceData;
        [FieldOffset(5944)]
        public ulong WinSockData;
        [FieldOffset(5952)]
        public uint GdiBatchCount;
        [FieldOffset(5956)]
        public _PROCESSOR_NUMBER CurrentIdealProcessor;
        [FieldOffset(5956)]
        public uint IdealProcessorValue;
        [FieldOffset(5956)]
        public byte ReservedPad0;
        [FieldOffset(5957)]
        public byte ReservedPad1;
        [FieldOffset(5958)]
        public byte ReservedPad2;
        [FieldOffset(5959)]
        public byte IdealProcessor;
        [FieldOffset(5960)]
        public uint GuaranteedStackBytes;
        [FieldOffset(5964)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding5;
        [FieldOffset(5968)]
        public ulong ReservedForPerf;
        [FieldOffset(5976)]
        public ulong ReservedForOle;
        [FieldOffset(5984)]
        public uint WaitingOnLoaderLock;
        [FieldOffset(5988)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding6;
        [FieldOffset(5992)]
        public ulong SavedPriorityState;
        [FieldOffset(6000)]
        public ulong ReservedForCodeCoverage;
        [FieldOffset(6008)]
        public ulong ThreadPoolData;
        [FieldOffset(6016)]
        public ulong TlsExpansionSlots;
        [FieldOffset(6024)]
        public ulong ChpeV2CpuAreaInfo;
        [FieldOffset(6032)]
        public ulong Unused;
        [FieldOffset(6040)]
        public uint MuiGeneration;
        [FieldOffset(6044)]
        public uint IsImpersonating;
        [FieldOffset(6048)]
        public ulong NlsCache;
        [FieldOffset(6056)]
        public ulong pShimData;
        [FieldOffset(6064)]
        public uint HeapData;
        [FieldOffset(6068)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding7;
        [FieldOffset(6072)]
        public ulong CurrentTransactionHandle;
        [FieldOffset(6080)]
        public ulong ActiveFrame;
        [FieldOffset(6088)]
        public ulong FlsData;
        [FieldOffset(6096)]
        public ulong PreferredLanguages;
        [FieldOffset(6104)]
        public ulong UserPrefLanguages;
        [FieldOffset(6112)]
        public ulong MergedPrefLanguages;
        [FieldOffset(6120)]
        public uint MuiImpersonation;
        [FieldOffset(6124)]
        public ushort CrossTebFlags;
        [FieldOffset(6124)]
        public ushort SpareCrossTebBits;
        [FieldOffset(6126)]
        public ushort SameTebFlags;
        [FieldOffset(6126)]
        public ushort SafeThunkCall;
        [FieldOffset(6126)]
        public ushort InDebugPrint;
        [FieldOffset(6126)]
        public ushort HasFiberData;
        [FieldOffset(6126)]
        public ushort SkipThreadAttach;
        [FieldOffset(6126)]
        public ushort WerInShipAssertCode;
        [FieldOffset(6126)]
        public ushort RanProcessInit;
        [FieldOffset(6126)]
        public ushort ClonedThread;
        [FieldOffset(6126)]
        public ushort SuppressDebugMsg;
        [FieldOffset(6126)]
        public ushort DisableUserStackWalk;
        [FieldOffset(6126)]
        public ushort RtlExceptionAttached;
        [FieldOffset(6126)]
        public ushort InitialThread;
        [FieldOffset(6126)]
        public ushort SessionAware;
        [FieldOffset(6126)]
        public ushort LoadOwner;
        [FieldOffset(6126)]
        public ushort LoaderWorker;
        [FieldOffset(6126)]
        public ushort SkipLoaderInit;
        [FieldOffset(6126)]
        public ushort SkipFileAPIBrokering;
        [FieldOffset(6128)]
        public ulong TxnScopeEnterCallback;
        [FieldOffset(6136)]
        public ulong TxnScopeExitCallback;
        [FieldOffset(6144)]
        public ulong TxnScopeContext;
        [FieldOffset(6152)]
        public uint LockCount;
        [FieldOffset(6156)]
        public int WowTebOffset;
        [FieldOffset(6160)]
        public ulong ResourceRetValue;
        [FieldOffset(6168)]
        public ulong ReservedForWdf;
        [FieldOffset(6176)]
        public ulong ReservedForCrt;
        [FieldOffset(6184)]
        public _GUID EffectiveContainerId;
        [FieldOffset(6200)]
        public ulong LastSleepCounter;
        [FieldOffset(6208)]
        public uint SpinCallCount;
        [FieldOffset(6212)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding8;
        [FieldOffset(6216)]
        public ulong ExtendedFeatureDisableMask;
        [FieldOffset(6224)]
        public ulong SchedulerSharedDataSlot;
        [FieldOffset(6232)]
        public ulong HeapWalkContext;
        [FieldOffset(6240)]
        public _GROUP_AFFINITY64 PrimaryGroupAffinity;
        [FieldOffset(6256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Rcu;
    }
}