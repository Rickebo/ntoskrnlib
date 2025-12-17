using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPRCB")]
    public sealed class _KPRCB : DynamicStructure
    {
        public uint MxCsr { get; }
        public byte LegacyNumber { get; }
        public byte ReservedMustBeZero { get; }
        public byte InterruptRequest { get; }
        public byte IdleHalt { get; }
        public IntPtr CurrentThread { get; }
        public IntPtr NextThread { get; }
        public IntPtr IdleThread { get; }
        public byte NestingLevel { get; }
        public byte ClockOwner { get; }
        public byte PendingTickFlags { get; }
        public byte PendingTick { get; }
        public byte PendingBackupTick { get; }
        public byte IdleState { get; }
        public uint Number { get; }
        public ulong RspBase { get; }
        public ulong PrcbLock { get; }
        public IntPtr PriorityState { get; }
        public sbyte CpuType { get; }
        public sbyte CpuID { get; }
        public ushort CpuStep { get; }
        public byte CpuStepping { get; }
        public byte CpuModel { get; }
        public uint MHz { get; }
        public ulong[] HalReserved { get; }
        public ushort MinorVersion { get; }
        public ushort MajorVersion { get; }
        public byte BuildType { get; }
        public byte CpuVendor { get; }
        public byte LegacyCoresPerPhysicalProcessor { get; }
        public byte LegacyLogicalProcessorsPerCore { get; }
        public ulong TscFrequency { get; }
        public IntPtr TracepointLog { get; }
        public uint CoresPerPhysicalProcessor { get; }
        public uint LogicalProcessorsPerCore { get; }
        public uint SelfIpiRequestSummary { get; }
        public byte QpcToTscIncrementShift { get; }
        public byte[] PrcbPad03 { get; }
        public ulong QpcToTscIncrement { get; }
        public ulong PrcbPad04 { get; }
        public IntPtr SchedulerSubNode { get; }
        public ulong GroupSetMember { get; }
        public byte Group { get; }
        public byte GroupIndex { get; }
        public byte[] PrcbPad05 { get; }
        public uint InitialApicId { get; }
        public uint ScbOffset { get; }
        public uint ApicMask { get; }
        public IntPtr AcpiReserved { get; }
        public uint CFlushSize { get; }
        public _KPRCBFLAG PrcbFlags { get; }
        public uint PrcbFlagsReserved { get; }
        public ulong[] PrcbPad11 { get; }
        public _KPROCESSOR_STATE ProcessorState { get; }
        public IntPtr ExtendedSupervisorState { get; }
        public uint ProcessorSignature { get; }
        public uint ProcessorFlags { get; }
        public ulong TrappedSecurityDomain { get; }
        public _KPRCB_BPB_STATE BpbState { get; }
        public _KPRCB_BPB_STATE BpbTrappedBpbState { get; }
        public _KPRCB_BPB_FEATURES BpbFeatures { get; }
        public byte PrcbPad12b { get; }
        public _KPRCB_BPB_RETPOLINE_STATE BpbRetpolineState { get; }
        public byte BpbRetpolineStateOverflow { get; }
        public short PairRegister { get; }
        public ushort BpbRetpolineExitSpecCtrl { get; }
        public ushort BpbTrappedRetpolineExitSpecCtrl { get; }
        public ushort BpbCurrentSpecCtrl { get; }
        public ushort BpbKernelSpecCtrl { get; }
        public ushort BpbNmiSpecCtrl { get; }
        public ushort BpbUserSpecCtrl { get; }
        public ushort[] PrcbPad12c { get; }
        public ulong[] PrcbPad12a { get; }
        public byte[] LockQueue { get; }
        public byte[] PPLookasideList { get; }
        public byte[] PPNxPagedLookasideList { get; }
        public byte[] PPNPagedLookasideList { get; }
        public byte[] PPPagedLookasideList { get; }
        public ulong PrcbPad20 { get; }
        public _SINGLE_LIST_ENTRY DeferredReadyListHead { get; }
        public int MmPageFaultCount { get; }
        public int MmCopyOnWriteCount { get; }
        public int MmTransitionCount { get; }
        public int MmDemandZeroCount { get; }
        public int MmPageReadCount { get; }
        public int MmPageReadIoCount { get; }
        public int MmDirtyPagesWriteCount { get; }
        public int MmDirtyWriteIoCount { get; }
        public int MmMappedPagesWriteCount { get; }
        public int MmMappedWriteIoCount { get; }
        public uint KeSystemCalls { get; }
        public uint KeContextSwitches { get; }
        public uint PrcbPad40 { get; }
        public uint CcFastReadNoWait { get; }
        public uint CcFastReadWait { get; }
        public uint CcFastReadNotPossible { get; }
        public uint CcCopyReadNoWait { get; }
        public uint CcCopyReadWait { get; }
        public uint CcCopyReadNoWaitMiss { get; }
        public int IoReadOperationCount { get; }
        public int IoWriteOperationCount { get; }
        public int IoOtherOperationCount { get; }
        public _LARGE_INTEGER IoReadTransferCount { get; }
        public _LARGE_INTEGER IoWriteTransferCount { get; }
        public _LARGE_INTEGER IoOtherTransferCount { get; }
        public int PacketBarrier { get; }
        public int TargetCount { get; }
        public uint IpiFrozen { get; }
        public uint PrcbPad30 { get; }
        public IntPtr IsrDpcStats { get; }
        public uint DeviceInterrupts { get; }
        public int LookasideIrpFloat { get; }
        public uint InterruptLastCount { get; }
        public uint InterruptRate { get; }
        public ulong PrcbPad31 { get; }
        public IntPtr PairPrcb { get; }
        public _KSTATIC_AFFINITY_BLOCK StaticAffinity { get; }
        public _KSOFTWARE_INTERRUPT_BATCH DeferredDispatchInterrupts { get; }
        public IntPtr StaticRescheduleContext { get; }
        public IntPtr CpuPartition { get; }
        public ulong[] PrcbPad35 { get; }
        public _SLIST_HEADER InterruptObjectPool { get; }
        public IntPtr DpcRuntimeHistoryHashTable { get; }
        public IntPtr DpcRuntimeHistoryHashTableCleanupDpc { get; }
        public IntPtr CurrentDpcRoutine { get; }
        public ulong CurrentDpcRuntimeHistoryCached { get; }
        public ulong CurrentDpcStartTime { get; }
        public IntPtr DpcDelegateThread { get; }
        public byte[] DpcData { get; }
        public IntPtr DpcStack { get; }
        public int MaximumDpcQueueDepth { get; }
        public uint DpcRequestRate { get; }
        public uint MinimumDpcRate { get; }
        public uint DpcLastCount { get; }
        public byte ThreadDpcEnable { get; }
        public byte QuantumEnd { get; }
        public byte DpcRoutineActive { get; }
        public byte IdleSchedule { get; }
        public int DpcRequestSummary { get; }
        public short[] DpcRequestSlot { get; }
        public short NormalDpcState { get; }
        public short ThreadDpcState { get; }
        public uint DpcNormalProcessingActive { get; }
        public uint DpcNormalProcessingRequested { get; }
        public uint DpcNormalThreadSignal { get; }
        public uint DpcNormalTimerExpiration { get; }
        public uint DpcNormalDpcPresent { get; }
        public uint DpcNormalLocalInterrupt { get; }
        public uint DpcNormalPriorityAntiStarvation { get; }
        public uint DpcNormalSwapToDpcDelegate { get; }
        public uint DpcNormalSpare { get; }
        public uint DpcThreadActive { get; }
        public uint DpcThreadRequested { get; }
        public uint DpcThreadSpare { get; }
        public uint LastTick { get; }
        public uint ClockInterrupts { get; }
        public uint ReadyScanTick { get; }
        public uint SingleDpcSoftTimeLimitTicks { get; }
        public IntPtr SingleDpcSoftTimeoutEventInfo { get; }
        public uint CumulativeDpcSoftTimeLimitTicks { get; }
        public uint DpcWatchdogProfileBufferSize { get; }
        public _KE_PRCB_RCU_DATA RcuData { get; }
        public byte[] InterruptObject { get; }
        public _KTIMER_TABLE TimerTable { get; }
        public IntPtr DpcLog { get; }
        public uint DpcLogIndex { get; }
        public uint DpcLogBufferSize { get; }
        public uint[] PrcbPad92 { get; }
        public _KGATE DpcGate { get; }
        public IntPtr PrcbPad52 { get; }
        public _KDPC CallDpc { get; }
        public int ClockKeepAlive { get; }
        public byte[] PrcbPad60 { get; }
        public byte NmiActive { get; }
        public byte MceActive { get; }
        public ushort CombinedNmiMceActive { get; }
        public int DpcWatchdogPeriodTicks { get; }
        public int DpcWatchdogCount { get; }
        public int KeSpinLockOrdering { get; }
        public uint DpcWatchdogProfileCumulativeDpcThresholdTicks { get; }
        public IntPtr CachedPtes { get; }
        public _LIST_ENTRY WaitListHead { get; }
        public ulong WaitLock { get; }
        public uint ReadySummary { get; }
        public int AffinitizedSelectionMask { get; }
        public uint QueueIndex { get; }
        public uint NormalPriorityQueueIndex { get; }
        public uint NormalPriorityReadyScanTick { get; }
        public uint DpcWatchdogSequenceNumber { get; }
        public _KDPC TimerExpirationDpc { get; }
        public _RTL_RB_TREE ScbQueue { get; }
        public byte[] DispatcherReadyListHead { get; }
        public uint InterruptCount { get; }
        public uint KernelTime { get; }
        public uint UserTime { get; }
        public uint DpcTime { get; }
        public uint InterruptTime { get; }
        public uint AdjustDpcThreshold { get; }
        public byte DebuggerSavedIRQL { get; }
        public byte GroupSchedulingOverQuota { get; }
        public byte DeepSleep { get; }
        public byte PrcbPad80 { get; }
        public uint DpcTimeCount { get; }
        public uint DpcTimeLimitTicks { get; }
        public uint PeriodicCount { get; }
        public uint PeriodicBias { get; }
        public uint AvailableTime { get; }
        public uint KeExceptionDispatchCount { get; }
        public uint ReadyThreadCount { get; }
        public ulong ReadyQueueExpectedRunTime { get; }
        public ulong StartCycles { get; }
        public ulong[] TaggedCycles { get; }
        public ulong AffinitizedCycles { get; }
        public IntPtr CyclesByThreadType { get; }
        public uint CpuCycleScalingFactor { get; }
        public ushort[] PerformanceScoreByClass { get; }
        public ushort[] EfficiencyScoreByClass { get; }
        public byte CycleAccumulationInitialized { get; }
        public byte[] PrcbPad83 { get; }
        public _KMCE_RECOVERY_CONTEXT MceRecoveryContext { get; }
        public IntPtr ForceParkDutyCycleData { get; }
        public ulong StartCyclesQpc { get; }
        public ulong CycleTimeQpc { get; }
        public ulong NumberOfSecureFaults { get; }
        public uint[] PrcbPad84 { get; }
        public byte[] CachedStacks { get; }
        public uint DpcWatchdogProfileSingleDpcThresholdTicks { get; }
        public int[] PrcbPad82 { get; }
        public uint PageColor { get; }
        public uint NodeColor { get; }
        public uint[] PrcbPad87 { get; }
        public byte[] PrcbPad81 { get; }
        public byte SystemWorkKickInProgress { get; }
        public byte ExceptionStackActive { get; }
        public byte TbFlushListActive { get; }
        public IntPtr ExceptionStack { get; }
        public long MmSpinLockOrdering { get; }
        public ulong CycleTime { get; }
        public byte[] Cycles { get; }
        public uint CcFastMdlReadNoWait { get; }
        public uint CcFastMdlReadWait { get; }
        public uint CcFastMdlReadNotPossible { get; }
        public uint CcMapDataNoWait { get; }
        public uint CcMapDataWait { get; }
        public uint CcPinMappedDataCount { get; }
        public uint CcPinReadNoWait { get; }
        public uint CcPinReadWait { get; }
        public uint CcMdlReadNoWait { get; }
        public uint CcMdlReadWait { get; }
        public uint CcLazyWriteHotSpots { get; }
        public uint CcLazyWriteIos { get; }
        public uint CcLazyWritePages { get; }
        public uint CcDataFlushes { get; }
        public uint CcDataPages { get; }
        public uint CcLostDelayedWrites { get; }
        public uint CcFastReadResourceMiss { get; }
        public uint CcCopyReadWaitMiss { get; }
        public uint CcFastMdlReadResourceMiss { get; }
        public uint CcMapDataNoWaitMiss { get; }
        public uint CcMapDataWaitMiss { get; }
        public uint CcPinReadNoWaitMiss { get; }
        public uint CcPinReadWaitMiss { get; }
        public uint CcMdlReadNoWaitMiss { get; }
        public uint CcMdlReadWaitMiss { get; }
        public uint CcReadAheadIos { get; }
        public int MmCacheTransitionCount { get; }
        public int MmCacheReadCount { get; }
        public int MmCacheIoCount { get; }
        public uint PrcbPad91 { get; }
        public IntPtr MmInternal { get; }
        public _PROCESSOR_POWER_STATE PowerState { get; }
        public ulong[] PrcbPad96 { get; }
        public IntPtr PrcbPad90 { get; }
        public _LIST_ENTRY ScbList { get; }
        public _KDPC ForceIdleDpc { get; }
        public _KDPC DpcWatchdogDpc { get; }
        public ulong[] PrcbPad98 { get; }
        public IntPtr VmInternal { get; }
        public byte[] Cache { get; }
        public uint CacheCount { get; }
        public uint CachedCommit { get; }
        public uint CachedResidentAvailable { get; }
        public IntPtr WheaInfo { get; }
        public IntPtr EtwSupport { get; }
        public IntPtr ExSaPageArray { get; }
        public uint KeAlignmentFixupCount { get; }
        public uint PrcbPad95 { get; }
        public _SLIST_HEADER HypercallPageList { get; }
        public IntPtr StatisticsPage { get; }
        public ulong GenerationTarget { get; }
        public _LARGE_INTEGER VirtualApicAssistPage { get; }
        public ulong[] PrcbPad85 { get; }
        public IntPtr HypercallCachedPages { get; }
        public IntPtr VirtualApicAssist { get; }
        public _KAFFINITY_EX PackageProcessorSet { get; }
        public ulong[] PrcbPad86 { get; }
        public uint ProcessorId { get; }
        public uint CoreId { get; }
        public uint ModuleId { get; }
        public uint DieId { get; }
        public uint PackageId { get; }
        public uint[] TopologyId { get; }
        public uint[] NodeRelativeTopologyIndex { get; }
        public ulong SharedReadyQueueMask { get; }
        public IntPtr SharedReadyQueue { get; }
        public uint SharedQueueScanOwner { get; }
        public uint ScanSiblingIndex { get; }
        public IntPtr CoreControlBlock { get; }
        public ulong CoreProcessorSet { get; }
        public ulong ScanSiblingMask { get; }
        public ulong LLCMask { get; }
        public ulong GroupModuleProcessorSet { get; }
        public IntPtr SmtIsolationThread { get; }
        public ulong[] PrcbPad97 { get; }
        public IntPtr ProcessorProfileControlArea { get; }
        public IntPtr ProfileEventIndexAddress { get; }
        public IntPtr DpcWatchdogProfile { get; }
        public IntPtr DpcWatchdogProfileCurrentEmptyCapture { get; }
        public IntPtr SchedulerAssist { get; }
        public _SYNCH_COUNTERS SynchCounters { get; }
        public ulong PrcbPad94 { get; }
        public _FILESYSTEM_DISK_COUNTERS FsCounters { get; }
        public byte[] VendorString { get; }
        public byte[] PrcbPad100 { get; }
        public ulong FeatureBits { get; }
        public _LARGE_INTEGER UpdateSignature { get; }
        public ulong PteBitCache { get; }
        public uint PteBitOffset { get; }
        public uint PrcbPad105 { get; }
        public IntPtr Context { get; }
        public uint ContextFlagsInit { get; }
        public uint PrcbPad115 { get; }
        public IntPtr ExtendedState { get; }
        public IntPtr IsrStack { get; }
        public _KENTROPY_TIMING_STATE EntropyTimingState { get; }
        public _unnamed_tag_ StibpPairingTrace { get; }
        public _SINGLE_LIST_ENTRY AbSelfIoBoostsList { get; }
        public _SINGLE_LIST_ENTRY AbPropagateBoostsList { get; }
        public _KDPC AbDpc { get; }
        public _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE SymCryptEntropyAccumulatorState { get; }
        public _IOP_IRP_STACK_PROFILER IoIrpStackProfilerCurrent { get; }
        public _IOP_IRP_STACK_PROFILER IoIrpStackProfilerPrevious { get; }
        public _KSECURE_FAULT_INFORMATION SecureFault { get; }
        public IntPtr LocalSharedReadyQueue { get; }
        public byte[] LocalSearchContexts { get; }
        public byte[] SearchContexts { get; }
        public byte[] SearchGenerations { get; }
        public ulong[] PrcbPad125 { get; }
        public uint TimerExpirationTraceCount { get; }
        public uint PrcbPad127 { get; }
        public byte[] TimerExpirationTrace { get; }
        public ulong[] PrcbPad128 { get; }
        public _KCLOCK_TIMER_STATE ClockTimerState { get; }
        public IntPtr IpiFrame { get; }
        public byte[] PrcbPad129 { get; }
        public IntPtr Mailbox { get; }
        public ulong[] PrcbPad130 { get; }
        public byte[] McheckContext { get; }
        public ulong TransitionShadowStack { get; }
        public ulong KernelShadowStackInitial { get; }
        public IntPtr IstShadowStacksTable { get; }
        public byte[] HiberSwapShadowStacks { get; }
        public byte[] HiberSwapShadowStackBases { get; }
        public IntPtr MmFaultCompletionInfo { get; }
        public ulong[] PrcbPad132 { get; }
        public byte[] SelfmapLockHandle { get; }
        public ulong[] PrcbPad134b { get; }
        public _KAFFINITY_EX DieProcessorSet { get; }
        public ulong[] PrcbPad135 { get; }
        public uint CoresPerPhysicalDie { get; }
        public uint LogicalProcessorsPerModule { get; }
        public byte[] PrcbPad137 { get; }
        public _KAFFINITY_EX ModuleProcessorSet { get; }
        public ulong[] PrcbPad136 { get; }
        public _KCORE_CONTROL_BLOCK LocalCoreControlBlock { get; }
        public ulong PrcbPad137a { get; }
        public _KDPC KstackFreeDpc { get; }
        public _KDPC SlistRollbackDpc { get; }
        public _SLIST_HEADER KstackFreeList { get; }
        public uint IsrStackNesting { get; }
        public byte[] PrcbPad138 { get; }
        public ulong KernelDirectoryTableBase { get; }
        public ulong RspBaseShadow { get; }
        public ulong UserRspShadow { get; }
        public uint ShadowFlags { get; }
        public uint PrcbPad138b { get; }
        public ulong PrcbPad138c { get; }
        public ushort PrcbPad138d { get; }
        public ushort VerwSelector { get; }
        public uint DbgMceNestingLevel { get; }
        public uint DbgMceFlags { get; }
        public uint CoreControlBlockIndex { get; }
        public IntPtr CoreControlBlockShadow { get; }
        public _KCORE_CONTROL_BLOCK_SHADOW LocalCoreControlBlockShadow { get; }
        public byte[] CacheProcessorSet { get; }
        public ulong[] PrcbPad139 { get; }
        public ulong[] PrcbPad140 { get; }
        public ulong[] PrcbPad140a { get; }
        public ulong[] PrcbPad141 { get; }
        public byte[] RequestMailbox { get; }

        public _KPRCB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB.MxCsr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB.LegacyNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KPRCB.ReservedMustBeZero),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptRequest),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_KPRCB.IdleHalt),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_KPRCB.CurrentThread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KPRCB.NextThread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KPRCB.IdleThread),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KPRCB.NestingLevel),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KPRCB.ClockOwner),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_KPRCB.PendingTickFlags),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KPRCB.PendingTick),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KPRCB.PendingBackupTick),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KPRCB.IdleState),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KPRCB.Number),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_KPRCB.RspBase),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KPRCB.PriorityState),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KPRCB.CpuType),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KPRCB.CpuID),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_KPRCB.CpuStep),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_KPRCB.CpuStepping),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_KPRCB.CpuModel),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_KPRCB.MHz),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_KPRCB.HalReserved),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KPRCB.MinorVersion),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPRCB.MajorVersion),
                    new ulong[]
                    {
                        138UL
                    }
                },
                {
                    nameof(_KPRCB.BuildType),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_KPRCB.CpuVendor),
                    new ulong[]
                    {
                        141UL
                    }
                },
                {
                    nameof(_KPRCB.LegacyCoresPerPhysicalProcessor),
                    new ulong[]
                    {
                        142UL
                    }
                },
                {
                    nameof(_KPRCB.LegacyLogicalProcessorsPerCore),
                    new ulong[]
                    {
                        143UL
                    }
                },
                {
                    nameof(_KPRCB.TscFrequency),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KPRCB.TracepointLog),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KPRCB.CoresPerPhysicalProcessor),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KPRCB.LogicalProcessorsPerCore),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_KPRCB.SelfIpiRequestSummary),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KPRCB.QpcToTscIncrementShift),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad03),
                    new ulong[]
                    {
                        173UL
                    }
                },
                {
                    nameof(_KPRCB.QpcToTscIncrement),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad04),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KPRCB.SchedulerSubNode),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KPRCB.GroupSetMember),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KPRCB.Group),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KPRCB.GroupIndex),
                    new ulong[]
                    {
                        209UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad05),
                    new ulong[]
                    {
                        210UL
                    }
                },
                {
                    nameof(_KPRCB.InitialApicId),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_KPRCB.ScbOffset),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KPRCB.ApicMask),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_KPRCB.AcpiReserved),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KPRCB.CFlushSize),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbFlags),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbFlagsReserved),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad11),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorState),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KPRCB.ExtendedSupervisorState),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorSignature),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorFlags),
                    new ulong[]
                    {
                        1740UL
                    }
                },
                {
                    nameof(_KPRCB.TrappedSecurityDomain),
                    new ulong[]
                    {
                        1744UL
                    }
                },
                {
                    nameof(_KPRCB.BpbState),
                    new ulong[]
                    {
                        1752UL
                    }
                },
                {
                    nameof(_KPRCB.BpbTrappedBpbState),
                    new ulong[]
                    {
                        1754UL
                    }
                },
                {
                    nameof(_KPRCB.BpbFeatures),
                    new ulong[]
                    {
                        1756UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad12b),
                    new ulong[]
                    {
                        1757UL
                    }
                },
                {
                    nameof(_KPRCB.BpbRetpolineState),
                    new ulong[]
                    {
                        1758UL
                    }
                },
                {
                    nameof(_KPRCB.BpbRetpolineStateOverflow),
                    new ulong[]
                    {
                        1759UL
                    }
                },
                {
                    nameof(_KPRCB.PairRegister),
                    new ulong[]
                    {
                        1760UL
                    }
                },
                {
                    nameof(_KPRCB.BpbRetpolineExitSpecCtrl),
                    new ulong[]
                    {
                        1762UL
                    }
                },
                {
                    nameof(_KPRCB.BpbTrappedRetpolineExitSpecCtrl),
                    new ulong[]
                    {
                        1764UL
                    }
                },
                {
                    nameof(_KPRCB.BpbCurrentSpecCtrl),
                    new ulong[]
                    {
                        1766UL
                    }
                },
                {
                    nameof(_KPRCB.BpbKernelSpecCtrl),
                    new ulong[]
                    {
                        1768UL
                    }
                },
                {
                    nameof(_KPRCB.BpbNmiSpecCtrl),
                    new ulong[]
                    {
                        1770UL
                    }
                },
                {
                    nameof(_KPRCB.BpbUserSpecCtrl),
                    new ulong[]
                    {
                        1772UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad12c),
                    new ulong[]
                    {
                        1774UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad12a),
                    new ulong[]
                    {
                        1744UL
                    }
                },
                {
                    nameof(_KPRCB.LockQueue),
                    new ulong[]
                    {
                        1776UL
                    }
                },
                {
                    nameof(_KPRCB.PPLookasideList),
                    new ulong[]
                    {
                        2048UL
                    }
                },
                {
                    nameof(_KPRCB.PPNxPagedLookasideList),
                    new ulong[]
                    {
                        2304UL
                    }
                },
                {
                    nameof(_KPRCB.PPNPagedLookasideList),
                    new ulong[]
                    {
                        5376UL
                    }
                },
                {
                    nameof(_KPRCB.PPPagedLookasideList),
                    new ulong[]
                    {
                        8448UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad20),
                    new ulong[]
                    {
                        11520UL
                    }
                },
                {
                    nameof(_KPRCB.DeferredReadyListHead),
                    new ulong[]
                    {
                        11528UL
                    }
                },
                {
                    nameof(_KPRCB.MmPageFaultCount),
                    new ulong[]
                    {
                        11536UL
                    }
                },
                {
                    nameof(_KPRCB.MmCopyOnWriteCount),
                    new ulong[]
                    {
                        11540UL
                    }
                },
                {
                    nameof(_KPRCB.MmTransitionCount),
                    new ulong[]
                    {
                        11544UL
                    }
                },
                {
                    nameof(_KPRCB.MmDemandZeroCount),
                    new ulong[]
                    {
                        11548UL
                    }
                },
                {
                    nameof(_KPRCB.MmPageReadCount),
                    new ulong[]
                    {
                        11552UL
                    }
                },
                {
                    nameof(_KPRCB.MmPageReadIoCount),
                    new ulong[]
                    {
                        11556UL
                    }
                },
                {
                    nameof(_KPRCB.MmDirtyPagesWriteCount),
                    new ulong[]
                    {
                        11560UL
                    }
                },
                {
                    nameof(_KPRCB.MmDirtyWriteIoCount),
                    new ulong[]
                    {
                        11564UL
                    }
                },
                {
                    nameof(_KPRCB.MmMappedPagesWriteCount),
                    new ulong[]
                    {
                        11568UL
                    }
                },
                {
                    nameof(_KPRCB.MmMappedWriteIoCount),
                    new ulong[]
                    {
                        11572UL
                    }
                },
                {
                    nameof(_KPRCB.KeSystemCalls),
                    new ulong[]
                    {
                        11576UL
                    }
                },
                {
                    nameof(_KPRCB.KeContextSwitches),
                    new ulong[]
                    {
                        11580UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad40),
                    new ulong[]
                    {
                        11584UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastReadNoWait),
                    new ulong[]
                    {
                        11588UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastReadWait),
                    new ulong[]
                    {
                        11592UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastReadNotPossible),
                    new ulong[]
                    {
                        11596UL
                    }
                },
                {
                    nameof(_KPRCB.CcCopyReadNoWait),
                    new ulong[]
                    {
                        11600UL
                    }
                },
                {
                    nameof(_KPRCB.CcCopyReadWait),
                    new ulong[]
                    {
                        11604UL
                    }
                },
                {
                    nameof(_KPRCB.CcCopyReadNoWaitMiss),
                    new ulong[]
                    {
                        11608UL
                    }
                },
                {
                    nameof(_KPRCB.IoReadOperationCount),
                    new ulong[]
                    {
                        11612UL
                    }
                },
                {
                    nameof(_KPRCB.IoWriteOperationCount),
                    new ulong[]
                    {
                        11616UL
                    }
                },
                {
                    nameof(_KPRCB.IoOtherOperationCount),
                    new ulong[]
                    {
                        11620UL
                    }
                },
                {
                    nameof(_KPRCB.IoReadTransferCount),
                    new ulong[]
                    {
                        11624UL
                    }
                },
                {
                    nameof(_KPRCB.IoWriteTransferCount),
                    new ulong[]
                    {
                        11632UL
                    }
                },
                {
                    nameof(_KPRCB.IoOtherTransferCount),
                    new ulong[]
                    {
                        11640UL
                    }
                },
                {
                    nameof(_KPRCB.PacketBarrier),
                    new ulong[]
                    {
                        11648UL
                    }
                },
                {
                    nameof(_KPRCB.TargetCount),
                    new ulong[]
                    {
                        11652UL
                    }
                },
                {
                    nameof(_KPRCB.IpiFrozen),
                    new ulong[]
                    {
                        11656UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad30),
                    new ulong[]
                    {
                        11660UL
                    }
                },
                {
                    nameof(_KPRCB.IsrDpcStats),
                    new ulong[]
                    {
                        11664UL
                    }
                },
                {
                    nameof(_KPRCB.DeviceInterrupts),
                    new ulong[]
                    {
                        11672UL
                    }
                },
                {
                    nameof(_KPRCB.LookasideIrpFloat),
                    new ulong[]
                    {
                        11676UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptLastCount),
                    new ulong[]
                    {
                        11680UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptRate),
                    new ulong[]
                    {
                        11684UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad31),
                    new ulong[]
                    {
                        11688UL
                    }
                },
                {
                    nameof(_KPRCB.PairPrcb),
                    new ulong[]
                    {
                        11696UL
                    }
                },
                {
                    nameof(_KPRCB.StaticAffinity),
                    new ulong[]
                    {
                        11704UL
                    }
                },
                {
                    nameof(_KPRCB.DeferredDispatchInterrupts),
                    new ulong[]
                    {
                        13784UL
                    }
                },
                {
                    nameof(_KPRCB.StaticRescheduleContext),
                    new ulong[]
                    {
                        14312UL
                    }
                },
                {
                    nameof(_KPRCB.CpuPartition),
                    new ulong[]
                    {
                        14320UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad35),
                    new ulong[]
                    {
                        14328UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptObjectPool),
                    new ulong[]
                    {
                        14336UL
                    }
                },
                {
                    nameof(_KPRCB.DpcRuntimeHistoryHashTable),
                    new ulong[]
                    {
                        14352UL
                    }
                },
                {
                    nameof(_KPRCB.DpcRuntimeHistoryHashTableCleanupDpc),
                    new ulong[]
                    {
                        14360UL
                    }
                },
                {
                    nameof(_KPRCB.CurrentDpcRoutine),
                    new ulong[]
                    {
                        14368UL
                    }
                },
                {
                    nameof(_KPRCB.CurrentDpcRuntimeHistoryCached),
                    new ulong[]
                    {
                        14376UL
                    }
                },
                {
                    nameof(_KPRCB.CurrentDpcStartTime),
                    new ulong[]
                    {
                        14384UL
                    }
                },
                {
                    nameof(_KPRCB.DpcDelegateThread),
                    new ulong[]
                    {
                        14392UL
                    }
                },
                {
                    nameof(_KPRCB.DpcData),
                    new ulong[]
                    {
                        14400UL
                    }
                },
                {
                    nameof(_KPRCB.DpcStack),
                    new ulong[]
                    {
                        14496UL
                    }
                },
                {
                    nameof(_KPRCB.MaximumDpcQueueDepth),
                    new ulong[]
                    {
                        14504UL
                    }
                },
                {
                    nameof(_KPRCB.DpcRequestRate),
                    new ulong[]
                    {
                        14508UL
                    }
                },
                {
                    nameof(_KPRCB.MinimumDpcRate),
                    new ulong[]
                    {
                        14512UL
                    }
                },
                {
                    nameof(_KPRCB.DpcLastCount),
                    new ulong[]
                    {
                        14516UL
                    }
                },
                {
                    nameof(_KPRCB.ThreadDpcEnable),
                    new ulong[]
                    {
                        14520UL
                    }
                },
                {
                    nameof(_KPRCB.QuantumEnd),
                    new ulong[]
                    {
                        14521UL
                    }
                },
                {
                    nameof(_KPRCB.DpcRoutineActive),
                    new ulong[]
                    {
                        14522UL
                    }
                },
                {
                    nameof(_KPRCB.IdleSchedule),
                    new ulong[]
                    {
                        14523UL
                    }
                },
                {
                    nameof(_KPRCB.DpcRequestSummary),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcRequestSlot),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.NormalDpcState),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.ThreadDpcState),
                    new ulong[]
                    {
                        14526UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalProcessingActive),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalProcessingRequested),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalThreadSignal),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalTimerExpiration),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalDpcPresent),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalLocalInterrupt),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalPriorityAntiStarvation),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalSwapToDpcDelegate),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcNormalSpare),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcThreadActive),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcThreadRequested),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.DpcThreadSpare),
                    new ulong[]
                    {
                        14524UL
                    }
                },
                {
                    nameof(_KPRCB.LastTick),
                    new ulong[]
                    {
                        14528UL
                    }
                },
                {
                    nameof(_KPRCB.ClockInterrupts),
                    new ulong[]
                    {
                        14532UL
                    }
                },
                {
                    nameof(_KPRCB.ReadyScanTick),
                    new ulong[]
                    {
                        14536UL
                    }
                },
                {
                    nameof(_KPRCB.SingleDpcSoftTimeLimitTicks),
                    new ulong[]
                    {
                        14540UL
                    }
                },
                {
                    nameof(_KPRCB.SingleDpcSoftTimeoutEventInfo),
                    new ulong[]
                    {
                        14544UL
                    }
                },
                {
                    nameof(_KPRCB.CumulativeDpcSoftTimeLimitTicks),
                    new ulong[]
                    {
                        14552UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogProfileBufferSize),
                    new ulong[]
                    {
                        14556UL
                    }
                },
                {
                    nameof(_KPRCB.RcuData),
                    new ulong[]
                    {
                        14560UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptObject),
                    new ulong[]
                    {
                        14592UL
                    }
                },
                {
                    nameof(_KPRCB.TimerTable),
                    new ulong[]
                    {
                        16640UL
                    }
                },
                {
                    nameof(_KPRCB.DpcLog),
                    new ulong[]
                    {
                        33560UL
                    }
                },
                {
                    nameof(_KPRCB.DpcLogIndex),
                    new ulong[]
                    {
                        33568UL
                    }
                },
                {
                    nameof(_KPRCB.DpcLogBufferSize),
                    new ulong[]
                    {
                        33572UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad92),
                    new ulong[]
                    {
                        33576UL
                    }
                },
                {
                    nameof(_KPRCB.DpcGate),
                    new ulong[]
                    {
                        33600UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad52),
                    new ulong[]
                    {
                        33624UL
                    }
                },
                {
                    nameof(_KPRCB.CallDpc),
                    new ulong[]
                    {
                        33632UL
                    }
                },
                {
                    nameof(_KPRCB.ClockKeepAlive),
                    new ulong[]
                    {
                        33696UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad60),
                    new ulong[]
                    {
                        33700UL
                    }
                },
                {
                    nameof(_KPRCB.NmiActive),
                    new ulong[]
                    {
                        33702UL
                    }
                },
                {
                    nameof(_KPRCB.MceActive),
                    new ulong[]
                    {
                        33703UL
                    }
                },
                {
                    nameof(_KPRCB.CombinedNmiMceActive),
                    new ulong[]
                    {
                        33702UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogPeriodTicks),
                    new ulong[]
                    {
                        33704UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogCount),
                    new ulong[]
                    {
                        33708UL
                    }
                },
                {
                    nameof(_KPRCB.KeSpinLockOrdering),
                    new ulong[]
                    {
                        33712UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogProfileCumulativeDpcThresholdTicks),
                    new ulong[]
                    {
                        33716UL
                    }
                },
                {
                    nameof(_KPRCB.CachedPtes),
                    new ulong[]
                    {
                        33720UL
                    }
                },
                {
                    nameof(_KPRCB.WaitListHead),
                    new ulong[]
                    {
                        33728UL
                    }
                },
                {
                    nameof(_KPRCB.WaitLock),
                    new ulong[]
                    {
                        33744UL
                    }
                },
                {
                    nameof(_KPRCB.ReadySummary),
                    new ulong[]
                    {
                        33752UL
                    }
                },
                {
                    nameof(_KPRCB.AffinitizedSelectionMask),
                    new ulong[]
                    {
                        33756UL
                    }
                },
                {
                    nameof(_KPRCB.QueueIndex),
                    new ulong[]
                    {
                        33760UL
                    }
                },
                {
                    nameof(_KPRCB.NormalPriorityQueueIndex),
                    new ulong[]
                    {
                        33764UL
                    }
                },
                {
                    nameof(_KPRCB.NormalPriorityReadyScanTick),
                    new ulong[]
                    {
                        33768UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogSequenceNumber),
                    new ulong[]
                    {
                        33772UL
                    }
                },
                {
                    nameof(_KPRCB.TimerExpirationDpc),
                    new ulong[]
                    {
                        33776UL
                    }
                },
                {
                    nameof(_KPRCB.ScbQueue),
                    new ulong[]
                    {
                        33840UL
                    }
                },
                {
                    nameof(_KPRCB.DispatcherReadyListHead),
                    new ulong[]
                    {
                        33856UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptCount),
                    new ulong[]
                    {
                        34368UL
                    }
                },
                {
                    nameof(_KPRCB.KernelTime),
                    new ulong[]
                    {
                        34372UL
                    }
                },
                {
                    nameof(_KPRCB.UserTime),
                    new ulong[]
                    {
                        34376UL
                    }
                },
                {
                    nameof(_KPRCB.DpcTime),
                    new ulong[]
                    {
                        34380UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptTime),
                    new ulong[]
                    {
                        34384UL
                    }
                },
                {
                    nameof(_KPRCB.AdjustDpcThreshold),
                    new ulong[]
                    {
                        34388UL
                    }
                },
                {
                    nameof(_KPRCB.DebuggerSavedIRQL),
                    new ulong[]
                    {
                        34392UL
                    }
                },
                {
                    nameof(_KPRCB.GroupSchedulingOverQuota),
                    new ulong[]
                    {
                        34393UL
                    }
                },
                {
                    nameof(_KPRCB.DeepSleep),
                    new ulong[]
                    {
                        34394UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad80),
                    new ulong[]
                    {
                        34395UL
                    }
                },
                {
                    nameof(_KPRCB.DpcTimeCount),
                    new ulong[]
                    {
                        34396UL
                    }
                },
                {
                    nameof(_KPRCB.DpcTimeLimitTicks),
                    new ulong[]
                    {
                        34400UL
                    }
                },
                {
                    nameof(_KPRCB.PeriodicCount),
                    new ulong[]
                    {
                        34404UL
                    }
                },
                {
                    nameof(_KPRCB.PeriodicBias),
                    new ulong[]
                    {
                        34408UL
                    }
                },
                {
                    nameof(_KPRCB.AvailableTime),
                    new ulong[]
                    {
                        34412UL
                    }
                },
                {
                    nameof(_KPRCB.KeExceptionDispatchCount),
                    new ulong[]
                    {
                        34416UL
                    }
                },
                {
                    nameof(_KPRCB.ReadyThreadCount),
                    new ulong[]
                    {
                        34420UL
                    }
                },
                {
                    nameof(_KPRCB.ReadyQueueExpectedRunTime),
                    new ulong[]
                    {
                        34424UL
                    }
                },
                {
                    nameof(_KPRCB.StartCycles),
                    new ulong[]
                    {
                        34432UL
                    }
                },
                {
                    nameof(_KPRCB.TaggedCycles),
                    new ulong[]
                    {
                        34440UL
                    }
                },
                {
                    nameof(_KPRCB.AffinitizedCycles),
                    new ulong[]
                    {
                        34472UL
                    }
                },
                {
                    nameof(_KPRCB.CyclesByThreadType),
                    new ulong[]
                    {
                        34480UL
                    }
                },
                {
                    nameof(_KPRCB.CpuCycleScalingFactor),
                    new ulong[]
                    {
                        34488UL
                    }
                },
                {
                    nameof(_KPRCB.PerformanceScoreByClass),
                    new ulong[]
                    {
                        34492UL
                    }
                },
                {
                    nameof(_KPRCB.EfficiencyScoreByClass),
                    new ulong[]
                    {
                        34508UL
                    }
                },
                {
                    nameof(_KPRCB.CycleAccumulationInitialized),
                    new ulong[]
                    {
                        34524UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad83),
                    new ulong[]
                    {
                        34525UL
                    }
                },
                {
                    nameof(_KPRCB.MceRecoveryContext),
                    new ulong[]
                    {
                        34528UL
                    }
                },
                {
                    nameof(_KPRCB.ForceParkDutyCycleData),
                    new ulong[]
                    {
                        34544UL
                    }
                },
                {
                    nameof(_KPRCB.StartCyclesQpc),
                    new ulong[]
                    {
                        34552UL
                    }
                },
                {
                    nameof(_KPRCB.CycleTimeQpc),
                    new ulong[]
                    {
                        34560UL
                    }
                },
                {
                    nameof(_KPRCB.NumberOfSecureFaults),
                    new ulong[]
                    {
                        34568UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad84),
                    new ulong[]
                    {
                        34576UL
                    }
                },
                {
                    nameof(_KPRCB.CachedStacks),
                    new ulong[]
                    {
                        34608UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogProfileSingleDpcThresholdTicks),
                    new ulong[]
                    {
                        34624UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad82),
                    new ulong[]
                    {
                        34628UL
                    }
                },
                {
                    nameof(_KPRCB.PageColor),
                    new ulong[]
                    {
                        34640UL
                    }
                },
                {
                    nameof(_KPRCB.NodeColor),
                    new ulong[]
                    {
                        34644UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad87),
                    new ulong[]
                    {
                        34648UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad81),
                    new ulong[]
                    {
                        34656UL
                    }
                },
                {
                    nameof(_KPRCB.SystemWorkKickInProgress),
                    new ulong[]
                    {
                        34661UL
                    }
                },
                {
                    nameof(_KPRCB.ExceptionStackActive),
                    new ulong[]
                    {
                        34662UL
                    }
                },
                {
                    nameof(_KPRCB.TbFlushListActive),
                    new ulong[]
                    {
                        34663UL
                    }
                },
                {
                    nameof(_KPRCB.ExceptionStack),
                    new ulong[]
                    {
                        34664UL
                    }
                },
                {
                    nameof(_KPRCB.MmSpinLockOrdering),
                    new ulong[]
                    {
                        34672UL
                    }
                },
                {
                    nameof(_KPRCB.CycleTime),
                    new ulong[]
                    {
                        34680UL
                    }
                },
                {
                    nameof(_KPRCB.Cycles),
                    new ulong[]
                    {
                        34688UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastMdlReadNoWait),
                    new ulong[]
                    {
                        34752UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastMdlReadWait),
                    new ulong[]
                    {
                        34756UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastMdlReadNotPossible),
                    new ulong[]
                    {
                        34760UL
                    }
                },
                {
                    nameof(_KPRCB.CcMapDataNoWait),
                    new ulong[]
                    {
                        34764UL
                    }
                },
                {
                    nameof(_KPRCB.CcMapDataWait),
                    new ulong[]
                    {
                        34768UL
                    }
                },
                {
                    nameof(_KPRCB.CcPinMappedDataCount),
                    new ulong[]
                    {
                        34772UL
                    }
                },
                {
                    nameof(_KPRCB.CcPinReadNoWait),
                    new ulong[]
                    {
                        34776UL
                    }
                },
                {
                    nameof(_KPRCB.CcPinReadWait),
                    new ulong[]
                    {
                        34780UL
                    }
                },
                {
                    nameof(_KPRCB.CcMdlReadNoWait),
                    new ulong[]
                    {
                        34784UL
                    }
                },
                {
                    nameof(_KPRCB.CcMdlReadWait),
                    new ulong[]
                    {
                        34788UL
                    }
                },
                {
                    nameof(_KPRCB.CcLazyWriteHotSpots),
                    new ulong[]
                    {
                        34792UL
                    }
                },
                {
                    nameof(_KPRCB.CcLazyWriteIos),
                    new ulong[]
                    {
                        34796UL
                    }
                },
                {
                    nameof(_KPRCB.CcLazyWritePages),
                    new ulong[]
                    {
                        34800UL
                    }
                },
                {
                    nameof(_KPRCB.CcDataFlushes),
                    new ulong[]
                    {
                        34804UL
                    }
                },
                {
                    nameof(_KPRCB.CcDataPages),
                    new ulong[]
                    {
                        34808UL
                    }
                },
                {
                    nameof(_KPRCB.CcLostDelayedWrites),
                    new ulong[]
                    {
                        34812UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastReadResourceMiss),
                    new ulong[]
                    {
                        34816UL
                    }
                },
                {
                    nameof(_KPRCB.CcCopyReadWaitMiss),
                    new ulong[]
                    {
                        34820UL
                    }
                },
                {
                    nameof(_KPRCB.CcFastMdlReadResourceMiss),
                    new ulong[]
                    {
                        34824UL
                    }
                },
                {
                    nameof(_KPRCB.CcMapDataNoWaitMiss),
                    new ulong[]
                    {
                        34828UL
                    }
                },
                {
                    nameof(_KPRCB.CcMapDataWaitMiss),
                    new ulong[]
                    {
                        34832UL
                    }
                },
                {
                    nameof(_KPRCB.CcPinReadNoWaitMiss),
                    new ulong[]
                    {
                        34836UL
                    }
                },
                {
                    nameof(_KPRCB.CcPinReadWaitMiss),
                    new ulong[]
                    {
                        34840UL
                    }
                },
                {
                    nameof(_KPRCB.CcMdlReadNoWaitMiss),
                    new ulong[]
                    {
                        34844UL
                    }
                },
                {
                    nameof(_KPRCB.CcMdlReadWaitMiss),
                    new ulong[]
                    {
                        34848UL
                    }
                },
                {
                    nameof(_KPRCB.CcReadAheadIos),
                    new ulong[]
                    {
                        34852UL
                    }
                },
                {
                    nameof(_KPRCB.MmCacheTransitionCount),
                    new ulong[]
                    {
                        34856UL
                    }
                },
                {
                    nameof(_KPRCB.MmCacheReadCount),
                    new ulong[]
                    {
                        34860UL
                    }
                },
                {
                    nameof(_KPRCB.MmCacheIoCount),
                    new ulong[]
                    {
                        34864UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad91),
                    new ulong[]
                    {
                        34868UL
                    }
                },
                {
                    nameof(_KPRCB.MmInternal),
                    new ulong[]
                    {
                        34872UL
                    }
                },
                {
                    nameof(_KPRCB.PowerState),
                    new ulong[]
                    {
                        34880UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad96),
                    new ulong[]
                    {
                        35448UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad90),
                    new ulong[]
                    {
                        35456UL
                    }
                },
                {
                    nameof(_KPRCB.ScbList),
                    new ulong[]
                    {
                        35464UL
                    }
                },
                {
                    nameof(_KPRCB.ForceIdleDpc),
                    new ulong[]
                    {
                        35480UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogDpc),
                    new ulong[]
                    {
                        35544UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad98),
                    new ulong[]
                    {
                        35608UL
                    }
                },
                {
                    nameof(_KPRCB.VmInternal),
                    new ulong[]
                    {
                        35664UL
                    }
                },
                {
                    nameof(_KPRCB.Cache),
                    new ulong[]
                    {
                        35672UL
                    }
                },
                {
                    nameof(_KPRCB.CacheCount),
                    new ulong[]
                    {
                        35732UL
                    }
                },
                {
                    nameof(_KPRCB.CachedCommit),
                    new ulong[]
                    {
                        35736UL
                    }
                },
                {
                    nameof(_KPRCB.CachedResidentAvailable),
                    new ulong[]
                    {
                        35740UL
                    }
                },
                {
                    nameof(_KPRCB.WheaInfo),
                    new ulong[]
                    {
                        35744UL
                    }
                },
                {
                    nameof(_KPRCB.EtwSupport),
                    new ulong[]
                    {
                        35752UL
                    }
                },
                {
                    nameof(_KPRCB.ExSaPageArray),
                    new ulong[]
                    {
                        35760UL
                    }
                },
                {
                    nameof(_KPRCB.KeAlignmentFixupCount),
                    new ulong[]
                    {
                        35768UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad95),
                    new ulong[]
                    {
                        35772UL
                    }
                },
                {
                    nameof(_KPRCB.HypercallPageList),
                    new ulong[]
                    {
                        35776UL
                    }
                },
                {
                    nameof(_KPRCB.StatisticsPage),
                    new ulong[]
                    {
                        35792UL
                    }
                },
                {
                    nameof(_KPRCB.GenerationTarget),
                    new ulong[]
                    {
                        35800UL
                    }
                },
                {
                    nameof(_KPRCB.VirtualApicAssistPage),
                    new ulong[]
                    {
                        35808UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad85),
                    new ulong[]
                    {
                        35816UL
                    }
                },
                {
                    nameof(_KPRCB.HypercallCachedPages),
                    new ulong[]
                    {
                        35840UL
                    }
                },
                {
                    nameof(_KPRCB.VirtualApicAssist),
                    new ulong[]
                    {
                        35848UL
                    }
                },
                {
                    nameof(_KPRCB.PackageProcessorSet),
                    new ulong[]
                    {
                        35856UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad86),
                    new ulong[]
                    {
                        36120UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorId),
                    new ulong[]
                    {
                        36376UL
                    }
                },
                {
                    nameof(_KPRCB.CoreId),
                    new ulong[]
                    {
                        36380UL
                    }
                },
                {
                    nameof(_KPRCB.ModuleId),
                    new ulong[]
                    {
                        36384UL
                    }
                },
                {
                    nameof(_KPRCB.DieId),
                    new ulong[]
                    {
                        36388UL
                    }
                },
                {
                    nameof(_KPRCB.PackageId),
                    new ulong[]
                    {
                        36392UL
                    }
                },
                {
                    nameof(_KPRCB.TopologyId),
                    new ulong[]
                    {
                        36376UL
                    }
                },
                {
                    nameof(_KPRCB.NodeRelativeTopologyIndex),
                    new ulong[]
                    {
                        36396UL
                    }
                },
                {
                    nameof(_KPRCB.SharedReadyQueueMask),
                    new ulong[]
                    {
                        36416UL
                    }
                },
                {
                    nameof(_KPRCB.SharedReadyQueue),
                    new ulong[]
                    {
                        36424UL
                    }
                },
                {
                    nameof(_KPRCB.SharedQueueScanOwner),
                    new ulong[]
                    {
                        36432UL
                    }
                },
                {
                    nameof(_KPRCB.ScanSiblingIndex),
                    new ulong[]
                    {
                        36436UL
                    }
                },
                {
                    nameof(_KPRCB.CoreControlBlock),
                    new ulong[]
                    {
                        36440UL
                    }
                },
                {
                    nameof(_KPRCB.CoreProcessorSet),
                    new ulong[]
                    {
                        36448UL
                    }
                },
                {
                    nameof(_KPRCB.ScanSiblingMask),
                    new ulong[]
                    {
                        36456UL
                    }
                },
                {
                    nameof(_KPRCB.LLCMask),
                    new ulong[]
                    {
                        36464UL
                    }
                },
                {
                    nameof(_KPRCB.GroupModuleProcessorSet),
                    new ulong[]
                    {
                        36472UL
                    }
                },
                {
                    nameof(_KPRCB.SmtIsolationThread),
                    new ulong[]
                    {
                        36480UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad97),
                    new ulong[]
                    {
                        36488UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorProfileControlArea),
                    new ulong[]
                    {
                        36504UL
                    }
                },
                {
                    nameof(_KPRCB.ProfileEventIndexAddress),
                    new ulong[]
                    {
                        36512UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogProfile),
                    new ulong[]
                    {
                        36520UL
                    }
                },
                {
                    nameof(_KPRCB.DpcWatchdogProfileCurrentEmptyCapture),
                    new ulong[]
                    {
                        36528UL
                    }
                },
                {
                    nameof(_KPRCB.SchedulerAssist),
                    new ulong[]
                    {
                        36536UL
                    }
                },
                {
                    nameof(_KPRCB.SynchCounters),
                    new ulong[]
                    {
                        36544UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad94),
                    new ulong[]
                    {
                        36728UL
                    }
                },
                {
                    nameof(_KPRCB.FsCounters),
                    new ulong[]
                    {
                        36736UL
                    }
                },
                {
                    nameof(_KPRCB.VendorString),
                    new ulong[]
                    {
                        36752UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad100),
                    new ulong[]
                    {
                        36765UL
                    }
                },
                {
                    nameof(_KPRCB.FeatureBits),
                    new ulong[]
                    {
                        36768UL
                    }
                },
                {
                    nameof(_KPRCB.UpdateSignature),
                    new ulong[]
                    {
                        36776UL
                    }
                },
                {
                    nameof(_KPRCB.PteBitCache),
                    new ulong[]
                    {
                        36784UL
                    }
                },
                {
                    nameof(_KPRCB.PteBitOffset),
                    new ulong[]
                    {
                        36792UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad105),
                    new ulong[]
                    {
                        36796UL
                    }
                },
                {
                    nameof(_KPRCB.Context),
                    new ulong[]
                    {
                        36800UL
                    }
                },
                {
                    nameof(_KPRCB.ContextFlagsInit),
                    new ulong[]
                    {
                        36808UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad115),
                    new ulong[]
                    {
                        36812UL
                    }
                },
                {
                    nameof(_KPRCB.ExtendedState),
                    new ulong[]
                    {
                        36816UL
                    }
                },
                {
                    nameof(_KPRCB.IsrStack),
                    new ulong[]
                    {
                        36824UL
                    }
                },
                {
                    nameof(_KPRCB.EntropyTimingState),
                    new ulong[]
                    {
                        36832UL
                    }
                },
                {
                    nameof(_KPRCB.StibpPairingTrace),
                    new ulong[]
                    {
                        37176UL
                    }
                },
                {
                    nameof(_KPRCB.AbSelfIoBoostsList),
                    new ulong[]
                    {
                        37232UL
                    }
                },
                {
                    nameof(_KPRCB.AbPropagateBoostsList),
                    new ulong[]
                    {
                        37240UL
                    }
                },
                {
                    nameof(_KPRCB.AbDpc),
                    new ulong[]
                    {
                        37248UL
                    }
                },
                {
                    nameof(_KPRCB.SymCryptEntropyAccumulatorState),
                    new ulong[]
                    {
                        37312UL
                    }
                },
                {
                    nameof(_KPRCB.IoIrpStackProfilerCurrent),
                    new ulong[]
                    {
                        37696UL
                    }
                },
                {
                    nameof(_KPRCB.IoIrpStackProfilerPrevious),
                    new ulong[]
                    {
                        37780UL
                    }
                },
                {
                    nameof(_KPRCB.SecureFault),
                    new ulong[]
                    {
                        37864UL
                    }
                },
                {
                    nameof(_KPRCB.LocalSharedReadyQueue),
                    new ulong[]
                    {
                        37888UL
                    }
                },
                {
                    nameof(_KPRCB.LocalSearchContexts),
                    new ulong[]
                    {
                        37896UL
                    }
                },
                {
                    nameof(_KPRCB.SearchContexts),
                    new ulong[]
                    {
                        37912UL
                    }
                },
                {
                    nameof(_KPRCB.SearchGenerations),
                    new ulong[]
                    {
                        37928UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad125),
                    new ulong[]
                    {
                        37944UL
                    }
                },
                {
                    nameof(_KPRCB.TimerExpirationTraceCount),
                    new ulong[]
                    {
                        37952UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad127),
                    new ulong[]
                    {
                        37956UL
                    }
                },
                {
                    nameof(_KPRCB.TimerExpirationTrace),
                    new ulong[]
                    {
                        37960UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad128),
                    new ulong[]
                    {
                        38216UL
                    }
                },
                {
                    nameof(_KPRCB.ClockTimerState),
                    new ulong[]
                    {
                        38272UL
                    }
                },
                {
                    nameof(_KPRCB.IpiFrame),
                    new ulong[]
                    {
                        39576UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad129),
                    new ulong[]
                    {
                        39584UL
                    }
                },
                {
                    nameof(_KPRCB.Mailbox),
                    new ulong[]
                    {
                        39616UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad130),
                    new ulong[]
                    {
                        39624UL
                    }
                },
                {
                    nameof(_KPRCB.McheckContext),
                    new ulong[]
                    {
                        39680UL
                    }
                },
                {
                    nameof(_KPRCB.TransitionShadowStack),
                    new ulong[]
                    {
                        39840UL
                    }
                },
                {
                    nameof(_KPRCB.KernelShadowStackInitial),
                    new ulong[]
                    {
                        39848UL
                    }
                },
                {
                    nameof(_KPRCB.IstShadowStacksTable),
                    new ulong[]
                    {
                        39856UL
                    }
                },
                {
                    nameof(_KPRCB.HiberSwapShadowStacks),
                    new ulong[]
                    {
                        39864UL
                    }
                },
                {
                    nameof(_KPRCB.HiberSwapShadowStackBases),
                    new ulong[]
                    {
                        39904UL
                    }
                },
                {
                    nameof(_KPRCB.MmFaultCompletionInfo),
                    new ulong[]
                    {
                        39944UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad132),
                    new ulong[]
                    {
                        39952UL
                    }
                },
                {
                    nameof(_KPRCB.SelfmapLockHandle),
                    new ulong[]
                    {
                        40000UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad134b),
                    new ulong[]
                    {
                        40096UL
                    }
                },
                {
                    nameof(_KPRCB.DieProcessorSet),
                    new ulong[]
                    {
                        40128UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad135),
                    new ulong[]
                    {
                        40392UL
                    }
                },
                {
                    nameof(_KPRCB.CoresPerPhysicalDie),
                    new ulong[]
                    {
                        40648UL
                    }
                },
                {
                    nameof(_KPRCB.LogicalProcessorsPerModule),
                    new ulong[]
                    {
                        40652UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad137),
                    new ulong[]
                    {
                        40656UL
                    }
                },
                {
                    nameof(_KPRCB.ModuleProcessorSet),
                    new ulong[]
                    {
                        40720UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad136),
                    new ulong[]
                    {
                        40984UL
                    }
                },
                {
                    nameof(_KPRCB.LocalCoreControlBlock),
                    new ulong[]
                    {
                        41240UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad137a),
                    new ulong[]
                    {
                        41288UL
                    }
                },
                {
                    nameof(_KPRCB.KstackFreeDpc),
                    new ulong[]
                    {
                        41296UL
                    }
                },
                {
                    nameof(_KPRCB.SlistRollbackDpc),
                    new ulong[]
                    {
                        41360UL
                    }
                },
                {
                    nameof(_KPRCB.KstackFreeList),
                    new ulong[]
                    {
                        41424UL
                    }
                },
                {
                    nameof(_KPRCB.IsrStackNesting),
                    new ulong[]
                    {
                        41440UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad138),
                    new ulong[]
                    {
                        41444UL
                    }
                },
                {
                    nameof(_KPRCB.KernelDirectoryTableBase),
                    new ulong[]
                    {
                        44672UL
                    }
                },
                {
                    nameof(_KPRCB.RspBaseShadow),
                    new ulong[]
                    {
                        44680UL
                    }
                },
                {
                    nameof(_KPRCB.UserRspShadow),
                    new ulong[]
                    {
                        44688UL
                    }
                },
                {
                    nameof(_KPRCB.ShadowFlags),
                    new ulong[]
                    {
                        44696UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad138b),
                    new ulong[]
                    {
                        44700UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad138c),
                    new ulong[]
                    {
                        44704UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad138d),
                    new ulong[]
                    {
                        44712UL
                    }
                },
                {
                    nameof(_KPRCB.VerwSelector),
                    new ulong[]
                    {
                        44714UL
                    }
                },
                {
                    nameof(_KPRCB.DbgMceNestingLevel),
                    new ulong[]
                    {
                        44716UL
                    }
                },
                {
                    nameof(_KPRCB.DbgMceFlags),
                    new ulong[]
                    {
                        44720UL
                    }
                },
                {
                    nameof(_KPRCB.CoreControlBlockIndex),
                    new ulong[]
                    {
                        44724UL
                    }
                },
                {
                    nameof(_KPRCB.CoreControlBlockShadow),
                    new ulong[]
                    {
                        44728UL
                    }
                },
                {
                    nameof(_KPRCB.LocalCoreControlBlockShadow),
                    new ulong[]
                    {
                        44736UL
                    }
                },
                {
                    nameof(_KPRCB.CacheProcessorSet),
                    new ulong[]
                    {
                        44800UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad139),
                    new ulong[]
                    {
                        46120UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad140),
                    new ulong[]
                    {
                        47400UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad140a),
                    new ulong[]
                    {
                        48768UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad141),
                    new ulong[]
                    {
                        48832UL
                    }
                },
                {
                    nameof(_KPRCB.RequestMailbox),
                    new ulong[]
                    {
                        52928UL
                    }
                }
            };
            Register<_KPRCB>((mem, ptr) => new _KPRCB(mem, ptr), offsets);
        }
    }
}