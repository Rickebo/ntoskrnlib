#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 6264)]
    public partial struct _TEB
    {
        [FieldOffset(0)]
        public _NT_TIB NtTib;
        [FieldOffset(56)]
        public IntPtr EnvironmentPointer;
        [FieldOffset(64)]
        public _CLIENT_ID ClientId;
        [FieldOffset(80)]
        public IntPtr ActiveRpcHandle;
        [FieldOffset(88)]
        public IntPtr ThreadLocalStoragePointer;
        [FieldOffset(96)]
        public IntPtr ProcessEnvironmentBlock;
        [FieldOffset(104)]
        public uint LastErrorValue;
        [FieldOffset(108)]
        public uint CountOfOwnedCriticalSections;
        [FieldOffset(112)]
        public IntPtr CsrClientThread;
        [FieldOffset(120)]
        public IntPtr Win32ThreadInfo;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public uint[] User32Reserved;
        [FieldOffset(232)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] UserReserved;
        [FieldOffset(256)]
        public IntPtr WOW32Reserved;
        [FieldOffset(264)]
        public uint CurrentLocale;
        [FieldOffset(268)]
        public uint FpSoftwareStatusRegister;
        [FieldOffset(272)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public IntPtr[] ReservedForDebuggerInstrumentation;
        [FieldOffset(400)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
        public IntPtr[] SystemReserved1;
        [FieldOffset(600)]
        public IntPtr HeapFlsData;
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
        public _ACTIVATION_CONTEXT_STACK _ActivationStack;
        [FieldOffset(696)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] WorkingOnBehalfTicket;
        [FieldOffset(704)]
        public int ExceptionCode;
        [FieldOffset(708)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding0;
        [FieldOffset(712)]
        public IntPtr ActivationContextStackPointer;
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
        public _GDI_TEB_BATCH GdiTebBatch;
        [FieldOffset(2008)]
        public _CLIENT_ID RealClientId;
        [FieldOffset(2024)]
        public IntPtr GdiCachedProcessHandle;
        [FieldOffset(2032)]
        public uint GdiClientPID;
        [FieldOffset(2036)]
        public uint GdiClientTID;
        [FieldOffset(2040)]
        public IntPtr GdiThreadLocalInfo;
        [FieldOffset(2048)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62)]
        public ulong[] Win32ClientInfo;
        [FieldOffset(2544)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 233)]
        public IntPtr[] glDispatchTable;
        [FieldOffset(4408)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 29)]
        public ulong[] glReserved1;
        [FieldOffset(4640)]
        public IntPtr glReserved2;
        [FieldOffset(4648)]
        public IntPtr glSectionInfo;
        [FieldOffset(4656)]
        public IntPtr glSection;
        [FieldOffset(4664)]
        public IntPtr glTable;
        [FieldOffset(4672)]
        public IntPtr glCurrentRC;
        [FieldOffset(4680)]
        public IntPtr glContext;
        [FieldOffset(4688)]
        public uint LastStatusValue;
        [FieldOffset(4692)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding2;
        [FieldOffset(4696)]
        public _UNICODE_STRING StaticUnicodeString;
        [FieldOffset(4712)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 261)]
        public short[] StaticUnicodeBuffer;
        [FieldOffset(5234)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Padding3;
        [FieldOffset(5240)]
        public IntPtr DeallocationStack;
        [FieldOffset(5248)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public IntPtr[] TlsSlots;
        [FieldOffset(5760)]
        public _LIST_ENTRY TlsLinks;
        [FieldOffset(5776)]
        public IntPtr Vdm;
        [FieldOffset(5784)]
        public IntPtr ReservedForNtRpc;
        [FieldOffset(5792)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] DbgSsReserved;
        [FieldOffset(5808)]
        public uint HardErrorMode;
        [FieldOffset(5812)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding4;
        [FieldOffset(5816)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public IntPtr[] Instrumentation;
        [FieldOffset(5904)]
        public _GUID ActivityId;
        [FieldOffset(5920)]
        public IntPtr SubProcessTag;
        [FieldOffset(5928)]
        public IntPtr PerflibData;
        [FieldOffset(5936)]
        public IntPtr EtwTraceData;
        [FieldOffset(5944)]
        public IntPtr WinSockData;
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
        public IntPtr ReservedForPerf;
        [FieldOffset(5976)]
        public IntPtr ReservedForOle;
        [FieldOffset(5984)]
        public uint WaitingOnLoaderLock;
        [FieldOffset(5988)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding6;
        [FieldOffset(5992)]
        public IntPtr SavedPriorityState;
        [FieldOffset(6000)]
        public ulong ReservedForCodeCoverage;
        [FieldOffset(6008)]
        public IntPtr ThreadPoolData;
        [FieldOffset(6016)]
        public IntPtr TlsExpansionSlots;
        [FieldOffset(6024)]
        public IntPtr ChpeV2CpuAreaInfo;
        [FieldOffset(6032)]
        public IntPtr Unused;
        [FieldOffset(6040)]
        public uint MuiGeneration;
        [FieldOffset(6044)]
        public uint IsImpersonating;
        [FieldOffset(6048)]
        public IntPtr NlsCache;
        [FieldOffset(6056)]
        public IntPtr pShimData;
        [FieldOffset(6064)]
        public uint HeapData;
        [FieldOffset(6068)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding7;
        [FieldOffset(6072)]
        public IntPtr CurrentTransactionHandle;
        [FieldOffset(6080)]
        public IntPtr ActiveFrame;
        [FieldOffset(6088)]
        public IntPtr FlsData;
        [FieldOffset(6096)]
        public IntPtr PreferredLanguages;
        [FieldOffset(6104)]
        public IntPtr UserPrefLanguages;
        [FieldOffset(6112)]
        public IntPtr MergedPrefLanguages;
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
        public IntPtr TxnScopeEnterCallback;
        [FieldOffset(6136)]
        public IntPtr TxnScopeExitCallback;
        [FieldOffset(6144)]
        public IntPtr TxnScopeContext;
        [FieldOffset(6152)]
        public uint LockCount;
        [FieldOffset(6156)]
        public int WowTebOffset;
        [FieldOffset(6160)]
        public IntPtr ResourceRetValue;
        [FieldOffset(6168)]
        public IntPtr ReservedForWdf;
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
        public IntPtr SchedulerSharedDataSlot;
        [FieldOffset(6232)]
        public IntPtr HeapWalkContext;
        [FieldOffset(6240)]
        public _GROUP_AFFINITY PrimaryGroupAffinity;
        [FieldOffset(6256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Rcu;
    }
}