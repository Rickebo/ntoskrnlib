using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=52992)]
public struct _KPRCB
{
    [FieldOffset(0)]
    public uint MxCsr;
    [FieldOffset(4)]
    public byte LegacyNumber;
    [FieldOffset(5)]
    public byte ReservedMustBeZero;
    [FieldOffset(6)]
    public byte InterruptRequest;
    [FieldOffset(7)]
    public byte IdleHalt;
    [FieldOffset(8)]
    public IntPtr CurrentThread;
    [FieldOffset(16)]
    public IntPtr NextThread;
    [FieldOffset(24)]
    public IntPtr IdleThread;
    [FieldOffset(32)]
    public byte NestingLevel;
    [FieldOffset(33)]
    public byte ClockOwner;
    [FieldOffset(34)]
    public byte PendingTickFlags;
    [FieldOffset(35)]
    public byte IdleState;
    [FieldOffset(36)]
    public uint Number;
    [FieldOffset(40)]
    public ulong RspBase;
    [FieldOffset(48)]
    public ulong PrcbLock;
    [FieldOffset(56)]
    public IntPtr PriorityState;
    [FieldOffset(64)]
    public sbyte CpuType;
    [FieldOffset(65)]
    public sbyte CpuID;
    [FieldOffset(66)]
    public ushort CpuStep;
    [FieldOffset(66)]
    public byte CpuStepping;
    [FieldOffset(67)]
    public byte CpuModel;
    [FieldOffset(68)]
    public uint MHz;
    [FieldOffset(72)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public ulong[] HalReserved;
    [FieldOffset(136)]
    public ushort MinorVersion;
    [FieldOffset(138)]
    public ushort MajorVersion;
    [FieldOffset(140)]
    public byte BuildType;
    [FieldOffset(141)]
    public byte CpuVendor;
    [FieldOffset(142)]
    public byte LegacyCoresPerPhysicalProcessor;
    [FieldOffset(143)]
    public byte LegacyLogicalProcessorsPerCore;
    [FieldOffset(144)]
    public ulong TscFrequency;
    [FieldOffset(152)]
    public IntPtr TracepointLog;
    [FieldOffset(160)]
    public uint CoresPerPhysicalProcessor;
    [FieldOffset(164)]
    public uint LogicalProcessorsPerCore;
    [FieldOffset(168)]
    public uint SelfIpiRequestSummary;
    [FieldOffset(172)]
    public byte QpcToTscIncrementShift;
    [FieldOffset(173)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] PrcbPad03;
    [FieldOffset(176)]
    public ulong QpcToTscIncrement;
    [FieldOffset(184)]
    public ulong PrcbPad04;
    [FieldOffset(192)]
    public IntPtr SchedulerSubNode;
    [FieldOffset(200)]
    public ulong GroupSetMember;
    [FieldOffset(208)]
    public byte Group;
    [FieldOffset(209)]
    public byte GroupIndex;
    [FieldOffset(210)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] PrcbPad05;
    [FieldOffset(212)]
    public uint InitialApicId;
    [FieldOffset(216)]
    public uint ScbOffset;
    [FieldOffset(220)]
    public uint ApicMask;
    [FieldOffset(224)]
    public IntPtr AcpiReserved;
    [FieldOffset(232)]
    public uint CFlushSize;
    [FieldOffset(236)]
    public _KPRCBFLAG PrcbFlags;
    [FieldOffset(236)]
    public uint PrcbFlagsReserved;
    [FieldOffset(240)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ulong[] PrcbPad11;
    [FieldOffset(256)]
    public _KPROCESSOR_STATE ProcessorState;
    [FieldOffset(1728)]
    public IntPtr ExtendedSupervisorState;
    [FieldOffset(1736)]
    public uint ProcessorSignature;
    [FieldOffset(1740)]
    public uint ProcessorFlags;
    [FieldOffset(1744)]
    public ulong TrappedSecurityDomain;
    [FieldOffset(1752)]
    public _KPRCB_BPB_STATE BpbState;
    [FieldOffset(1754)]
    public _KPRCB_BPB_STATE BpbTrappedBpbState;
    [FieldOffset(1756)]
    public _KPRCB_BPB_FEATURES BpbFeatures;
    [FieldOffset(1757)]
    public byte PrcbPad12b;
    [FieldOffset(1758)]
    public _KPRCB_BPB_RETPOLINE_STATE BpbRetpolineState;
    [FieldOffset(1759)]
    public byte BpbRetpolineStateOverflow;
    [FieldOffset(1760)]
    public short PairRegister;
    [FieldOffset(1762)]
    public ushort BpbRetpolineExitSpecCtrl;
    [FieldOffset(1764)]
    public ushort BpbTrappedRetpolineExitSpecCtrl;
    [FieldOffset(1766)]
    public ushort BpbCurrentSpecCtrl;
    [FieldOffset(1768)]
    public ushort BpbKernelSpecCtrl;
    [FieldOffset(1770)]
    public ushort BpbNmiSpecCtrl;
    [FieldOffset(1772)]
    public ushort BpbUserSpecCtrl;
    [FieldOffset(1774)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ushort[] PrcbPad12c;
    [FieldOffset(1744)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ulong[] PrcbPad12a;
    [FieldOffset(1776)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=17)]
    public byte[] LockQueue;
    [FieldOffset(2048)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] PPLookasideList;
    [FieldOffset(2304)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] PPNxPagedLookasideList;
    [FieldOffset(5376)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] PPNPagedLookasideList;
    [FieldOffset(8448)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] PPPagedLookasideList;
    [FieldOffset(11520)]
    public ulong MsrIa32TsxCtrl;
    [FieldOffset(11528)]
    public _SINGLE_LIST_ENTRY DeferredReadyListHead;
    [FieldOffset(11536)]
    public int MmPageFaultCount;
    [FieldOffset(11540)]
    public int MmCopyOnWriteCount;
    [FieldOffset(11544)]
    public int MmTransitionCount;
    [FieldOffset(11548)]
    public int MmDemandZeroCount;
    [FieldOffset(11552)]
    public int MmPageReadCount;
    [FieldOffset(11556)]
    public int MmPageReadIoCount;
    [FieldOffset(11560)]
    public int MmDirtyPagesWriteCount;
    [FieldOffset(11564)]
    public int MmDirtyWriteIoCount;
    [FieldOffset(11568)]
    public int MmMappedPagesWriteCount;
    [FieldOffset(11572)]
    public int MmMappedWriteIoCount;
    [FieldOffset(11576)]
    public uint KeSystemCalls;
    [FieldOffset(11580)]
    public uint KeContextSwitches;
    [FieldOffset(11584)]
    public uint PrcbPad40;
    [FieldOffset(11588)]
    public uint CcFastReadNoWait;
    [FieldOffset(11592)]
    public uint CcFastReadWait;
    [FieldOffset(11596)]
    public uint CcFastReadNotPossible;
    [FieldOffset(11600)]
    public uint CcCopyReadNoWait;
    [FieldOffset(11604)]
    public uint CcCopyReadWait;
    [FieldOffset(11608)]
    public uint CcCopyReadNoWaitMiss;
    [FieldOffset(11612)]
    public int IoReadOperationCount;
    [FieldOffset(11616)]
    public int IoWriteOperationCount;
    [FieldOffset(11620)]
    public int IoOtherOperationCount;
    [FieldOffset(11624)]
    public _LARGE_INTEGER IoReadTransferCount;
    [FieldOffset(11632)]
    public _LARGE_INTEGER IoWriteTransferCount;
    [FieldOffset(11640)]
    public _LARGE_INTEGER IoOtherTransferCount;
    [FieldOffset(11648)]
    public int PacketBarrier;
    [FieldOffset(11652)]
    public int TargetCount;
    [FieldOffset(11656)]
    public uint IpiFrozen;
    [FieldOffset(11660)]
    public uint PrcbPad30;
    [FieldOffset(11664)]
    public IntPtr IsrDpcStats;
    [FieldOffset(11672)]
    public uint DeviceInterrupts;
    [FieldOffset(11676)]
    public int LookasideIrpFloat;
    [FieldOffset(11680)]
    public uint InterruptLastCount;
    [FieldOffset(11684)]
    public uint InterruptRate;
    [FieldOffset(11688)]
    public ulong PrcbPad31;
    [FieldOffset(11696)]
    public IntPtr PairPrcb;
    [FieldOffset(11704)]
    public _KSTATIC_AFFINITY_BLOCK StaticAffinity;
    [FieldOffset(13784)]
    public _KSOFTWARE_INTERRUPT_BATCH DeferredDispatchInterrupts;
    [FieldOffset(14312)]
    public IntPtr StaticRescheduleContext;
    [FieldOffset(14320)]
    public IntPtr CpuPartition;
    [FieldOffset(14328)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ulong[] PrcbPad35;
    [FieldOffset(14336)]
    public _SLIST_HEADER InterruptObjectPool;
    [FieldOffset(14352)]
    public IntPtr DpcRuntimeHistoryHashTable;
    [FieldOffset(14360)]
    public IntPtr DpcRuntimeHistoryHashTableCleanupDpc;
    [FieldOffset(14368)]
    public IntPtr CurrentDpcRoutine;
    [FieldOffset(14376)]
    public ulong CurrentDpcRuntimeHistoryCached;
    [FieldOffset(14384)]
    public ulong CurrentDpcStartTime;
    [FieldOffset(14392)]
    public IntPtr DpcDelegateThread;
    [FieldOffset(14400)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] DpcData;
    [FieldOffset(14496)]
    public IntPtr DpcStack;
    [FieldOffset(14504)]
    public int MaximumDpcQueueDepth;
    [FieldOffset(14508)]
    public uint DpcRequestRate;
    [FieldOffset(14512)]
    public uint MinimumDpcRate;
    [FieldOffset(14516)]
    public uint DpcLastCount;
    [FieldOffset(14520)]
    public byte ThreadDpcEnable;
    [FieldOffset(14521)]
    public byte QuantumEnd;
    [FieldOffset(14522)]
    public byte DpcRoutineActive;
    [FieldOffset(14523)]
    public byte IdleSchedule;
    [FieldOffset(14524)]
    public int DpcRequestSummary;
    [FieldOffset(14524)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public short[] DpcRequestSlot;
    [FieldOffset(14524)]
    public short NormalDpcState;
    [FieldOffset(14526)]
    public short ThreadDpcState;
    [FieldOffset(14528)]
    public uint LastTick;
    [FieldOffset(14532)]
    public uint ClockInterrupts;
    [FieldOffset(14536)]
    public uint ReadyScanTick;
    [FieldOffset(14540)]
    public uint SingleDpcSoftTimeLimitTicks;
    [FieldOffset(14544)]
    public IntPtr SingleDpcSoftTimeoutEventInfo;
    [FieldOffset(14552)]
    public uint CumulativeDpcSoftTimeLimitTicks;
    [FieldOffset(14556)]
    public uint DpcWatchdogProfileBufferSize;
    [FieldOffset(14560)]
    public _KE_PRCB_RCU_DATA RcuData;
    [FieldOffset(14592)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=256)]
    public byte[] InterruptObject;
    [FieldOffset(16640)]
    public _KTIMER_TABLE TimerTable;
    [FieldOffset(33560)]
    public IntPtr DpcLog;
    [FieldOffset(33568)]
    public uint DpcLogIndex;
    [FieldOffset(33572)]
    public uint DpcLogBufferSize;
    [FieldOffset(33576)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
    public uint[] PrcbPad92;
    [FieldOffset(33600)]
    public _KGATE DpcGate;
    [FieldOffset(33624)]
    public IntPtr PrcbPad52;
    [FieldOffset(33632)]
    public _KDPC CallDpc;
    [FieldOffset(33696)]
    public int ClockKeepAlive;
    [FieldOffset(33700)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] PrcbPad60;
    [FieldOffset(33702)]
    public byte NmiActive;
    [FieldOffset(33703)]
    public byte MceActive;
    [FieldOffset(33702)]
    public ushort CombinedNmiMceActive;
    [FieldOffset(33704)]
    public int DpcWatchdogPeriodTicks;
    [FieldOffset(33708)]
    public int DpcWatchdogCount;
    [FieldOffset(33712)]
    public int KeSpinLockOrdering;
    [FieldOffset(33716)]
    public uint DpcWatchdogProfileCumulativeDpcThresholdTicks;
    [FieldOffset(33720)]
    public IntPtr CachedPtes;
    [FieldOffset(33728)]
    public _LIST_ENTRY WaitListHead;
    [FieldOffset(33744)]
    public ulong WaitLock;
    [FieldOffset(33752)]
    public uint ReadySummary;
    [FieldOffset(33756)]
    public int AffinitizedSelectionMask;
    [FieldOffset(33760)]
    public uint QueueIndex;
    [FieldOffset(33764)]
    public uint NormalPriorityQueueIndex;
    [FieldOffset(33768)]
    public uint NormalPriorityReadyScanTick;
    [FieldOffset(33772)]
    public uint DpcWatchdogSequenceNumber;
    [FieldOffset(33776)]
    public _KDPC TimerExpirationDpc;
    [FieldOffset(33840)]
    public _RTL_RB_TREE ScbQueue;
    [FieldOffset(33856)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] DispatcherReadyListHead;
    [FieldOffset(34368)]
    public uint InterruptCount;
    [FieldOffset(34372)]
    public uint KernelTime;
    [FieldOffset(34376)]
    public uint UserTime;
    [FieldOffset(34380)]
    public uint DpcTime;
    [FieldOffset(34384)]
    public uint InterruptTime;
    [FieldOffset(34388)]
    public uint AdjustDpcThreshold;
    [FieldOffset(34392)]
    public byte DebuggerSavedIRQL;
    [FieldOffset(34393)]
    public byte GroupSchedulingOverQuota;
    [FieldOffset(34394)]
    public byte DeepSleep;
    [FieldOffset(34395)]
    public byte PrcbPad80;
    [FieldOffset(34396)]
    public uint DpcTimeCount;
    [FieldOffset(34400)]
    public uint DpcTimeLimitTicks;
    [FieldOffset(34404)]
    public uint PeriodicCount;
    [FieldOffset(34408)]
    public uint PeriodicBias;
    [FieldOffset(34412)]
    public uint AvailableTime;
    [FieldOffset(34416)]
    public uint KeExceptionDispatchCount;
    [FieldOffset(34420)]
    public uint ReadyThreadCount;
    [FieldOffset(34424)]
    public ulong ReadyQueueExpectedRunTime;
    [FieldOffset(34432)]
    public ulong StartCycles;
    [FieldOffset(34440)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ulong[] TaggedCycles;
    [FieldOffset(34472)]
    public ulong AffinitizedCycles;
    [FieldOffset(34480)]
    public IntPtr CyclesByThreadType;
    [FieldOffset(34488)]
    public uint CpuCycleScalingFactor;
    [FieldOffset(34492)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public ushort[] PerformanceScoreByClass;
    [FieldOffset(34508)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public ushort[] EfficiencyScoreByClass;
    [FieldOffset(34524)]
    public byte CycleAccumulationInitialized;
    [FieldOffset(34525)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] PrcbPad83;
    [FieldOffset(34528)]
    public _KMCE_RECOVERY_CONTEXT MceRecoveryContext;
    [FieldOffset(34544)]
    public IntPtr ForceParkDutyCycleData;
    [FieldOffset(34552)]
    public ulong StartCyclesQpc;
    [FieldOffset(34560)]
    public ulong CycleTimeQpc;
    [FieldOffset(34568)]
    public ulong NumberOfSecureFaults;
    [FieldOffset(34576)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public uint[] PrcbPad84;
    [FieldOffset(34608)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] CachedStacks;
    [FieldOffset(34624)]
    public uint DpcWatchdogProfileSingleDpcThresholdTicks;
    [FieldOffset(34628)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public int[] PrcbPad82;
    [FieldOffset(34640)]
    public uint PageColor;
    [FieldOffset(34644)]
    public uint NodeColor;
    [FieldOffset(34648)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public uint[] PrcbPad87;
    [FieldOffset(34656)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] PrcbPad81;
    [FieldOffset(34661)]
    public byte SystemWorkKickInProgress;
    [FieldOffset(34662)]
    public byte ExceptionStackActive;
    [FieldOffset(34663)]
    public byte TbFlushListActive;
    [FieldOffset(34664)]
    public IntPtr ExceptionStack;
    [FieldOffset(34672)]
    public long MmSpinLockOrdering;
    [FieldOffset(34680)]
    public ulong CycleTime;
    [FieldOffset(34688)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] Cycles;
    [FieldOffset(34752)]
    public uint CcFastMdlReadNoWait;
    [FieldOffset(34756)]
    public uint CcFastMdlReadWait;
    [FieldOffset(34760)]
    public uint CcFastMdlReadNotPossible;
    [FieldOffset(34764)]
    public uint CcMapDataNoWait;
    [FieldOffset(34768)]
    public uint CcMapDataWait;
    [FieldOffset(34772)]
    public uint CcPinMappedDataCount;
    [FieldOffset(34776)]
    public uint CcPinReadNoWait;
    [FieldOffset(34780)]
    public uint CcPinReadWait;
    [FieldOffset(34784)]
    public uint CcMdlReadNoWait;
    [FieldOffset(34788)]
    public uint CcMdlReadWait;
    [FieldOffset(34792)]
    public uint CcLazyWriteHotSpots;
    [FieldOffset(34796)]
    public uint CcLazyWriteIos;
    [FieldOffset(34800)]
    public uint CcLazyWritePages;
    [FieldOffset(34804)]
    public uint CcDataFlushes;
    [FieldOffset(34808)]
    public uint CcDataPages;
    [FieldOffset(34812)]
    public uint CcLostDelayedWrites;
    [FieldOffset(34816)]
    public uint CcFastReadResourceMiss;
    [FieldOffset(34820)]
    public uint CcCopyReadWaitMiss;
    [FieldOffset(34824)]
    public uint CcFastMdlReadResourceMiss;
    [FieldOffset(34828)]
    public uint CcMapDataNoWaitMiss;
    [FieldOffset(34832)]
    public uint CcMapDataWaitMiss;
    [FieldOffset(34836)]
    public uint CcPinReadNoWaitMiss;
    [FieldOffset(34840)]
    public uint CcPinReadWaitMiss;
    [FieldOffset(34844)]
    public uint CcMdlReadNoWaitMiss;
    [FieldOffset(34848)]
    public uint CcMdlReadWaitMiss;
    [FieldOffset(34852)]
    public uint CcReadAheadIos;
    [FieldOffset(34856)]
    public int MmCacheTransitionCount;
    [FieldOffset(34860)]
    public int MmCacheReadCount;
    [FieldOffset(34864)]
    public int MmCacheIoCount;
    [FieldOffset(34868)]
    public uint PrcbPad91;
    [FieldOffset(34872)]
    public IntPtr MmInternal;
    [FieldOffset(34880)]
    public _PROCESSOR_POWER_STATE PowerState;
    [FieldOffset(35448)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ulong[] PrcbPad96;
    [FieldOffset(35456)]
    public IntPtr PrcbPad90;
    [FieldOffset(35464)]
    public _LIST_ENTRY ScbList;
    [FieldOffset(35480)]
    public _KDPC ForceIdleDpc;
    [FieldOffset(35544)]
    public _KDPC DpcWatchdogDpc;
    [FieldOffset(35608)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public ulong[] PrcbPad98;
    [FieldOffset(35664)]
    public IntPtr VmInternal;
    [FieldOffset(35672)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] Cache;
    [FieldOffset(35732)]
    public uint CacheCount;
    [FieldOffset(35736)]
    public uint CachedCommit;
    [FieldOffset(35740)]
    public uint CachedResidentAvailable;
    [FieldOffset(35744)]
    public IntPtr WheaInfo;
    [FieldOffset(35752)]
    public IntPtr EtwSupport;
    [FieldOffset(35760)]
    public IntPtr ExSaPageArray;
    [FieldOffset(35768)]
    public uint KeAlignmentFixupCount;
    [FieldOffset(35772)]
    public uint PrcbPad95;
    [FieldOffset(35776)]
    public _SLIST_HEADER HypercallPageList;
    [FieldOffset(35792)]
    public IntPtr StatisticsPage;
    [FieldOffset(35800)]
    public ulong GenerationTarget;
    [FieldOffset(35808)]
    public _LARGE_INTEGER VirtualApicAssistPage;
    [FieldOffset(35816)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public ulong[] PrcbPad85;
    [FieldOffset(35840)]
    public IntPtr HypercallCachedPages;
    [FieldOffset(35848)]
    public IntPtr VirtualApicAssist;
    [FieldOffset(35856)]
    public _KAFFINITY_EX PackageProcessorSet;
    [FieldOffset(36120)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ulong[] PrcbPad86;
    [FieldOffset(36376)]
    public uint ProcessorId;
    [FieldOffset(36380)]
    public uint CoreId;
    [FieldOffset(36384)]
    public uint ModuleId;
    [FieldOffset(36388)]
    public uint DieId;
    [FieldOffset(36392)]
    public uint PackageId;
    [FieldOffset(36376)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public uint[] TopologyId;
    [FieldOffset(36396)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public uint[] NodeRelativeTopologyIndex;
    [FieldOffset(36416)]
    public ulong SharedReadyQueueMask;
    [FieldOffset(36424)]
    public IntPtr SharedReadyQueue;
    [FieldOffset(36432)]
    public uint SharedQueueScanOwner;
    [FieldOffset(36436)]
    public uint ScanSiblingIndex;
    [FieldOffset(36440)]
    public IntPtr CoreControlBlock;
    [FieldOffset(36448)]
    public ulong CoreProcessorSet;
    [FieldOffset(36456)]
    public ulong ScanSiblingMask;
    [FieldOffset(36464)]
    public ulong LLCMask;
    [FieldOffset(36472)]
    public ulong GroupModuleProcessorSet;
    [FieldOffset(36480)]
    public IntPtr SmtIsolationThread;
    [FieldOffset(36488)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ulong[] PrcbPad97;
    [FieldOffset(36504)]
    public IntPtr ProcessorProfileControlArea;
    [FieldOffset(36512)]
    public IntPtr ProfileEventIndexAddress;
    [FieldOffset(36520)]
    public IntPtr DpcWatchdogProfile;
    [FieldOffset(36528)]
    public IntPtr DpcWatchdogProfileCurrentEmptyCapture;
    [FieldOffset(36536)]
    public IntPtr SchedulerAssist;
    [FieldOffset(36544)]
    public _SYNCH_COUNTERS SynchCounters;
    [FieldOffset(36728)]
    public ulong PrcbPad94;
    [FieldOffset(36736)]
    public _FILESYSTEM_DISK_COUNTERS FsCounters;
    [FieldOffset(36752)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=13)]
    public byte[] VendorString;
    [FieldOffset(36765)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] PrcbPad100;
    [FieldOffset(36768)]
    public ulong FeatureBits;
    [FieldOffset(36776)]
    public _LARGE_INTEGER UpdateSignature;
    [FieldOffset(36784)]
    public ulong PteBitCache;
    [FieldOffset(36792)]
    public uint PteBitOffset;
    [FieldOffset(36796)]
    public uint PrcbPad105;
    [FieldOffset(36800)]
    public IntPtr Context;
    [FieldOffset(36808)]
    public uint ContextFlagsInit;
    [FieldOffset(36812)]
    public uint PrcbPad115;
    [FieldOffset(36816)]
    public IntPtr ExtendedState;
    [FieldOffset(36824)]
    public IntPtr IsrStack;
    [FieldOffset(36832)]
    public _KENTROPY_TIMING_STATE EntropyTimingState;
    [FieldOffset(37176)]
    public _unnamed_tag_ StibpPairingTrace;
    [FieldOffset(37232)]
    public _SINGLE_LIST_ENTRY AbSelfIoBoostsList;
    [FieldOffset(37240)]
    public _SINGLE_LIST_ENTRY AbPropagateBoostsList;
    [FieldOffset(37248)]
    public _KDPC AbDpc;
    [FieldOffset(37312)]
    public _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE SymCryptEntropyAccumulatorState;
    [FieldOffset(37696)]
    public _IOP_IRP_STACK_PROFILER IoIrpStackProfilerCurrent;
    [FieldOffset(37780)]
    public _IOP_IRP_STACK_PROFILER IoIrpStackProfilerPrevious;
    [FieldOffset(37864)]
    public _KSECURE_FAULT_INFORMATION SecureFault;
    [FieldOffset(37888)]
    public IntPtr LocalSharedReadyQueue;
    [FieldOffset(37896)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] LocalSearchContexts;
    [FieldOffset(37912)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] SearchContexts;
    [FieldOffset(37928)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] SearchGenerations;
    [FieldOffset(37944)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ulong[] PrcbPad125;
    [FieldOffset(37952)]
    public uint TimerExpirationTraceCount;
    [FieldOffset(37956)]
    public uint PrcbPad127;
    [FieldOffset(37960)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] TimerExpirationTrace;
    [FieldOffset(38216)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public ulong[] PrcbPad128;
    [FieldOffset(38272)]
    public _KCLOCK_TIMER_STATE ClockTimerState;
    [FieldOffset(39576)]
    public IntPtr IpiFrame;
    [FieldOffset(39584)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] PrcbPad129;
    [FieldOffset(39616)]
    public IntPtr Mailbox;
    [FieldOffset(39624)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public ulong[] PrcbPad130;
    [FieldOffset(39680)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] McheckContext;
    [FieldOffset(39840)]
    public ulong TransitionShadowStack;
    [FieldOffset(39848)]
    public ulong KernelShadowStackInitial;
    [FieldOffset(39856)]
    public IntPtr IstShadowStacksTable;
    [FieldOffset(39864)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] HiberSwapShadowStacks;
    [FieldOffset(39904)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] HiberSwapShadowStackBases;
    [FieldOffset(39944)]
    public IntPtr MmFaultCompletionInfo;
    [FieldOffset(39952)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
    public ulong[] PrcbPad132;
    [FieldOffset(40000)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] SelfmapLockHandle;
    [FieldOffset(40096)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ulong[] PrcbPad134b;
    [FieldOffset(40128)]
    public _KAFFINITY_EX DieProcessorSet;
    [FieldOffset(40392)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ulong[] PrcbPad135;
    [FieldOffset(40648)]
    public uint CoresPerPhysicalDie;
    [FieldOffset(40652)]
    public uint LogicalProcessorsPerModule;
    [FieldOffset(40656)]
    public _KDPC FreezeForRecoveryDpc;
    [FieldOffset(40720)]
    public _KAFFINITY_EX ModuleProcessorSet;
    [FieldOffset(40984)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ulong[] PrcbPad136;
    [FieldOffset(41240)]
    public _KCORE_CONTROL_BLOCK LocalCoreControlBlock;
    [FieldOffset(41288)]
    public ulong PrcbPad137a;
    [FieldOffset(41296)]
    public _KDPC KstackFreeDpc;
    [FieldOffset(41360)]
    public _KDPC SlistRollbackDpc;
    [FieldOffset(41424)]
    public _SLIST_HEADER KstackFreeList;
    [FieldOffset(41440)]
    public uint IsrStackNesting;
    [FieldOffset(41444)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3228)]
    public byte[] PrcbPad138;
    [FieldOffset(44672)]
    public ulong KernelDirectoryTableBase;
    [FieldOffset(44680)]
    public ulong RspBaseShadow;
    [FieldOffset(44688)]
    public ulong UserRspShadow;
    [FieldOffset(44696)]
    public uint ShadowFlags;
    [FieldOffset(44700)]
    public uint PrcbPad138b;
    [FieldOffset(44704)]
    public ulong PrcbPad138c;
    [FieldOffset(44712)]
    public ushort PrcbPad138d;
    [FieldOffset(44714)]
    public ushort VerwSelector;
    [FieldOffset(44716)]
    public uint DbgMceNestingLevel;
    [FieldOffset(44720)]
    public uint DbgMceFlags;
    [FieldOffset(44724)]
    public uint CoreControlBlockIndex;
    [FieldOffset(44728)]
    public IntPtr CoreControlBlockShadow;
    [FieldOffset(44736)]
    public _KCORE_CONTROL_BLOCK_SHADOW LocalCoreControlBlockShadow;
    [FieldOffset(44800)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] CacheProcessorSet;
    [FieldOffset(46120)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=160)]
    public ulong[] PrcbPad139;
    [FieldOffset(47400)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=171)]
    public ulong[] PrcbPad140;
    [FieldOffset(48768)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public ulong[] PrcbPad140a;
    [FieldOffset(48832)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=512)]
    public ulong[] PrcbPad141;
    [FieldOffset(52928)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] RequestMailbox;
}
