using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KPRCB")]
    public sealed class Kprcb : DynamicStructure
    {
        [Offset(0UL)]
        public uint MxCsr { get => ReadHere<uint>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(4UL)]
        public byte LegacyNumber { get => ReadHere<byte>(nameof(LegacyNumber)); set => WriteHere(nameof(LegacyNumber), value); }

        [Offset(5UL)]
        public byte ReservedMustBeZero { get => ReadHere<byte>(nameof(ReservedMustBeZero)); set => WriteHere(nameof(ReservedMustBeZero), value); }

        [Offset(6UL)]
        public byte InterruptRequest { get => ReadHere<byte>(nameof(InterruptRequest)); set => WriteHere(nameof(InterruptRequest), value); }

        [Offset(7UL)]
        public byte IdleHalt { get => ReadHere<byte>(nameof(IdleHalt)); set => WriteHere(nameof(IdleHalt), value); }

        [Offset(8UL)]
        public IntPtr CurrentThread { get => ReadHere<IntPtr>(nameof(CurrentThread)); set => WriteHere(nameof(CurrentThread), value); }

        [Offset(16UL)]
        public IntPtr NextThread { get => ReadHere<IntPtr>(nameof(NextThread)); set => WriteHere(nameof(NextThread), value); }

        [Offset(24UL)]
        public IntPtr IdleThread { get => ReadHere<IntPtr>(nameof(IdleThread)); set => WriteHere(nameof(IdleThread), value); }

        [Offset(32UL)]
        public byte NestingLevel { get => ReadHere<byte>(nameof(NestingLevel)); set => WriteHere(nameof(NestingLevel), value); }

        [Offset(33UL)]
        public byte ClockOwner { get => ReadHere<byte>(nameof(ClockOwner)); set => WriteHere(nameof(ClockOwner), value); }

        [Offset(34UL)]
        public byte PendingTickFlags { get => ReadHere<byte>(nameof(PendingTickFlags)); set => WriteHere(nameof(PendingTickFlags), value); }

        [Offset(34UL)]
        public byte PendingTick { get => ReadHere<byte>(nameof(PendingTick)); set => WriteHere(nameof(PendingTick), value); }

        [Offset(34UL)]
        public byte PendingBackupTick { get => ReadHere<byte>(nameof(PendingBackupTick)); set => WriteHere(nameof(PendingBackupTick), value); }

        [Offset(35UL)]
        public byte IdleState { get => ReadHere<byte>(nameof(IdleState)); set => WriteHere(nameof(IdleState), value); }

        [Offset(36UL)]
        public uint Number { get => ReadHere<uint>(nameof(Number)); set => WriteHere(nameof(Number), value); }

        [Offset(40UL)]
        public ulong RspBase { get => ReadHere<ulong>(nameof(RspBase)); set => WriteHere(nameof(RspBase), value); }

        [Offset(48UL)]
        public ulong PrcbLock { get => ReadHere<ulong>(nameof(PrcbLock)); set => WriteHere(nameof(PrcbLock), value); }

        [Offset(56UL)]
        public IntPtr PriorityState { get => ReadHere<IntPtr>(nameof(PriorityState)); set => WriteHere(nameof(PriorityState), value); }

        [Offset(64UL)]
        public sbyte CpuType { get => ReadHere<sbyte>(nameof(CpuType)); set => WriteHere(nameof(CpuType), value); }

        [Offset(65UL)]
        public sbyte CpuID { get => ReadHere<sbyte>(nameof(CpuID)); set => WriteHere(nameof(CpuID), value); }

        [Offset(66UL)]
        public ushort CpuStep { get => ReadHere<ushort>(nameof(CpuStep)); set => WriteHere(nameof(CpuStep), value); }

        [Offset(66UL)]
        public byte CpuStepping { get => ReadHere<byte>(nameof(CpuStepping)); set => WriteHere(nameof(CpuStepping), value); }

        [Offset(67UL)]
        public byte CpuModel { get => ReadHere<byte>(nameof(CpuModel)); set => WriteHere(nameof(CpuModel), value); }

        [Offset(68UL)]
        public uint MHz { get => ReadHere<uint>(nameof(MHz)); set => WriteHere(nameof(MHz), value); }

        [Offset(72UL)]
        [Length(8)]
        public DynamicArray HalReserved { get => ReadStructure<DynamicArray>(nameof(HalReserved)); set => WriteStructure(nameof(HalReserved), value); }

        [Offset(136UL)]
        public ushort MinorVersion { get => ReadHere<ushort>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(138UL)]
        public ushort MajorVersion { get => ReadHere<ushort>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(140UL)]
        public byte BuildType { get => ReadHere<byte>(nameof(BuildType)); set => WriteHere(nameof(BuildType), value); }

        [Offset(141UL)]
        public byte CpuVendor { get => ReadHere<byte>(nameof(CpuVendor)); set => WriteHere(nameof(CpuVendor), value); }

        [Offset(142UL)]
        public byte LegacyCoresPerPhysicalProcessor { get => ReadHere<byte>(nameof(LegacyCoresPerPhysicalProcessor)); set => WriteHere(nameof(LegacyCoresPerPhysicalProcessor), value); }

        [Offset(143UL)]
        public byte LegacyLogicalProcessorsPerCore { get => ReadHere<byte>(nameof(LegacyLogicalProcessorsPerCore)); set => WriteHere(nameof(LegacyLogicalProcessorsPerCore), value); }

        [Offset(144UL)]
        public ulong TscFrequency { get => ReadHere<ulong>(nameof(TscFrequency)); set => WriteHere(nameof(TscFrequency), value); }

        [Offset(152UL)]
        public IntPtr TracepointLog { get => ReadHere<IntPtr>(nameof(TracepointLog)); set => WriteHere(nameof(TracepointLog), value); }

        [Offset(160UL)]
        public uint CoresPerPhysicalProcessor { get => ReadHere<uint>(nameof(CoresPerPhysicalProcessor)); set => WriteHere(nameof(CoresPerPhysicalProcessor), value); }

        [Offset(164UL)]
        public uint LogicalProcessorsPerCore { get => ReadHere<uint>(nameof(LogicalProcessorsPerCore)); set => WriteHere(nameof(LogicalProcessorsPerCore), value); }

        [Offset(168UL)]
        public uint SelfIpiRequestSummary { get => ReadHere<uint>(nameof(SelfIpiRequestSummary)); set => WriteHere(nameof(SelfIpiRequestSummary), value); }

        [Offset(172UL)]
        public byte QpcToTscIncrementShift { get => ReadHere<byte>(nameof(QpcToTscIncrementShift)); set => WriteHere(nameof(QpcToTscIncrementShift), value); }

        [Offset(173UL)]
        [Length(3)]
        public DynamicArray PrcbPad03 { get => ReadStructure<DynamicArray>(nameof(PrcbPad03)); set => WriteStructure(nameof(PrcbPad03), value); }

        [Offset(176UL)]
        public ulong QpcToTscIncrement { get => ReadHere<ulong>(nameof(QpcToTscIncrement)); set => WriteHere(nameof(QpcToTscIncrement), value); }

        [Offset(184UL)]
        public ulong PrcbPad04 { get => ReadHere<ulong>(nameof(PrcbPad04)); set => WriteHere(nameof(PrcbPad04), value); }

        [Offset(192UL)]
        public IntPtr SchedulerSubNode { get => ReadHere<IntPtr>(nameof(SchedulerSubNode)); set => WriteHere(nameof(SchedulerSubNode), value); }

        [Offset(200UL)]
        public ulong GroupSetMember { get => ReadHere<ulong>(nameof(GroupSetMember)); set => WriteHere(nameof(GroupSetMember), value); }

        [Offset(208UL)]
        public byte Group { get => ReadHere<byte>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(209UL)]
        public byte GroupIndex { get => ReadHere<byte>(nameof(GroupIndex)); set => WriteHere(nameof(GroupIndex), value); }

        [Offset(210UL)]
        [Length(2)]
        public DynamicArray PrcbPad05 { get => ReadStructure<DynamicArray>(nameof(PrcbPad05)); set => WriteStructure(nameof(PrcbPad05), value); }

        [Offset(212UL)]
        public uint InitialApicId { get => ReadHere<uint>(nameof(InitialApicId)); set => WriteHere(nameof(InitialApicId), value); }

        [Offset(216UL)]
        public uint ScbOffset { get => ReadHere<uint>(nameof(ScbOffset)); set => WriteHere(nameof(ScbOffset), value); }

        [Offset(220UL)]
        public uint ApicMask { get => ReadHere<uint>(nameof(ApicMask)); set => WriteHere(nameof(ApicMask), value); }

        [Offset(224UL)]
        public IntPtr AcpiReserved { get => ReadHere<IntPtr>(nameof(AcpiReserved)); set => WriteHere(nameof(AcpiReserved), value); }

        [Offset(232UL)]
        public uint CFlushSize { get => ReadHere<uint>(nameof(CFlushSize)); set => WriteHere(nameof(CFlushSize), value); }

        [Offset(236UL)]
        public Kprcbflag PrcbFlags { get => ReadStructure<Kprcbflag>(nameof(PrcbFlags)); set => WriteStructure(nameof(PrcbFlags), value); }

        [Offset(236UL)]
        public uint PrcbFlagsReserved { get => ReadHere<uint>(nameof(PrcbFlagsReserved)); set => WriteHere(nameof(PrcbFlagsReserved), value); }

        [Offset(240UL)]
        [Length(2)]
        public DynamicArray PrcbPad11 { get => ReadStructure<DynamicArray>(nameof(PrcbPad11)); set => WriteStructure(nameof(PrcbPad11), value); }

        [Offset(256UL)]
        public KprocessorState ProcessorState { get => ReadStructure<KprocessorState>(nameof(ProcessorState)); set => WriteStructure(nameof(ProcessorState), value); }

        [Offset(1728UL)]
        public IntPtr ExtendedSupervisorState { get => ReadHere<IntPtr>(nameof(ExtendedSupervisorState)); set => WriteHere(nameof(ExtendedSupervisorState), value); }

        [Offset(1736UL)]
        public uint ProcessorSignature { get => ReadHere<uint>(nameof(ProcessorSignature)); set => WriteHere(nameof(ProcessorSignature), value); }

        [Offset(1740UL)]
        public uint ProcessorFlags { get => ReadHere<uint>(nameof(ProcessorFlags)); set => WriteHere(nameof(ProcessorFlags), value); }

        [Offset(1744UL)]
        public ulong TrappedSecurityDomain { get => ReadHere<ulong>(nameof(TrappedSecurityDomain)); set => WriteHere(nameof(TrappedSecurityDomain), value); }

        [Offset(1752UL)]
        public KprcbBpbState BpbState { get => ReadStructure<KprcbBpbState>(nameof(BpbState)); set => WriteStructure(nameof(BpbState), value); }

        [Offset(1754UL)]
        public KprcbBpbState BpbTrappedBpbState { get => ReadStructure<KprcbBpbState>(nameof(BpbTrappedBpbState)); set => WriteStructure(nameof(BpbTrappedBpbState), value); }

        [Offset(1756UL)]
        public KprcbBpbFeatures BpbFeatures { get => ReadStructure<KprcbBpbFeatures>(nameof(BpbFeatures)); set => WriteStructure(nameof(BpbFeatures), value); }

        [Offset(1757UL)]
        public byte PrcbPad12b { get => ReadHere<byte>(nameof(PrcbPad12b)); set => WriteHere(nameof(PrcbPad12b), value); }

        [Offset(1758UL)]
        public KprcbBpbRetpolineState BpbRetpolineState { get => ReadStructure<KprcbBpbRetpolineState>(nameof(BpbRetpolineState)); set => WriteStructure(nameof(BpbRetpolineState), value); }

        [Offset(1759UL)]
        public byte BpbRetpolineStateOverflow { get => ReadHere<byte>(nameof(BpbRetpolineStateOverflow)); set => WriteHere(nameof(BpbRetpolineStateOverflow), value); }

        [Offset(1760UL)]
        public short PairRegister { get => ReadHere<short>(nameof(PairRegister)); set => WriteHere(nameof(PairRegister), value); }

        [Offset(1762UL)]
        public ushort BpbRetpolineExitSpecCtrl { get => ReadHere<ushort>(nameof(BpbRetpolineExitSpecCtrl)); set => WriteHere(nameof(BpbRetpolineExitSpecCtrl), value); }

        [Offset(1764UL)]
        public ushort BpbTrappedRetpolineExitSpecCtrl { get => ReadHere<ushort>(nameof(BpbTrappedRetpolineExitSpecCtrl)); set => WriteHere(nameof(BpbTrappedRetpolineExitSpecCtrl), value); }

        [Offset(1766UL)]
        public ushort BpbCurrentSpecCtrl { get => ReadHere<ushort>(nameof(BpbCurrentSpecCtrl)); set => WriteHere(nameof(BpbCurrentSpecCtrl), value); }

        [Offset(1768UL)]
        public ushort BpbKernelSpecCtrl { get => ReadHere<ushort>(nameof(BpbKernelSpecCtrl)); set => WriteHere(nameof(BpbKernelSpecCtrl), value); }

        [Offset(1770UL)]
        public ushort BpbNmiSpecCtrl { get => ReadHere<ushort>(nameof(BpbNmiSpecCtrl)); set => WriteHere(nameof(BpbNmiSpecCtrl), value); }

        [Offset(1772UL)]
        public ushort BpbUserSpecCtrl { get => ReadHere<ushort>(nameof(BpbUserSpecCtrl)); set => WriteHere(nameof(BpbUserSpecCtrl), value); }

        [Offset(1774UL)]
        [Length(1)]
        public DynamicArray PrcbPad12c { get => ReadStructure<DynamicArray>(nameof(PrcbPad12c)); set => WriteStructure(nameof(PrcbPad12c), value); }

        [Offset(1744UL)]
        [Length(4)]
        public DynamicArray PrcbPad12a { get => ReadStructure<DynamicArray>(nameof(PrcbPad12a)); set => WriteStructure(nameof(PrcbPad12a), value); }

        [Offset(1776UL)]
        [Length(17)]
        public DynamicArray LockQueue { get => ReadStructure<DynamicArray>(nameof(LockQueue)); set => WriteStructure(nameof(LockQueue), value); }

        [Offset(2048UL)]
        [Length(16)]
        public DynamicArray PPLookasideList { get => ReadStructure<DynamicArray>(nameof(PPLookasideList)); set => WriteStructure(nameof(PPLookasideList), value); }

        [Offset(2304UL)]
        [Length(32)]
        public DynamicArray PPNxPagedLookasideList { get => ReadStructure<DynamicArray>(nameof(PPNxPagedLookasideList)); set => WriteStructure(nameof(PPNxPagedLookasideList), value); }

        [Offset(5376UL)]
        [Length(32)]
        public DynamicArray PPNPagedLookasideList { get => ReadStructure<DynamicArray>(nameof(PPNPagedLookasideList)); set => WriteStructure(nameof(PPNPagedLookasideList), value); }

        [Offset(8448UL)]
        [Length(32)]
        public DynamicArray PPPagedLookasideList { get => ReadStructure<DynamicArray>(nameof(PPPagedLookasideList)); set => WriteStructure(nameof(PPPagedLookasideList), value); }

        [Offset(11520UL)]
        public ulong PrcbPad20 { get => ReadHere<ulong>(nameof(PrcbPad20)); set => WriteHere(nameof(PrcbPad20), value); }

        [Offset(11528UL)]
        public SingleListEntry DeferredReadyListHead { get => ReadStructure<SingleListEntry>(nameof(DeferredReadyListHead)); set => WriteStructure(nameof(DeferredReadyListHead), value); }

        [Offset(11536UL)]
        public int MmPageFaultCount { get => ReadHere<int>(nameof(MmPageFaultCount)); set => WriteHere(nameof(MmPageFaultCount), value); }

        [Offset(11540UL)]
        public int MmCopyOnWriteCount { get => ReadHere<int>(nameof(MmCopyOnWriteCount)); set => WriteHere(nameof(MmCopyOnWriteCount), value); }

        [Offset(11544UL)]
        public int MmTransitionCount { get => ReadHere<int>(nameof(MmTransitionCount)); set => WriteHere(nameof(MmTransitionCount), value); }

        [Offset(11548UL)]
        public int MmDemandZeroCount { get => ReadHere<int>(nameof(MmDemandZeroCount)); set => WriteHere(nameof(MmDemandZeroCount), value); }

        [Offset(11552UL)]
        public int MmPageReadCount { get => ReadHere<int>(nameof(MmPageReadCount)); set => WriteHere(nameof(MmPageReadCount), value); }

        [Offset(11556UL)]
        public int MmPageReadIoCount { get => ReadHere<int>(nameof(MmPageReadIoCount)); set => WriteHere(nameof(MmPageReadIoCount), value); }

        [Offset(11560UL)]
        public int MmDirtyPagesWriteCount { get => ReadHere<int>(nameof(MmDirtyPagesWriteCount)); set => WriteHere(nameof(MmDirtyPagesWriteCount), value); }

        [Offset(11564UL)]
        public int MmDirtyWriteIoCount { get => ReadHere<int>(nameof(MmDirtyWriteIoCount)); set => WriteHere(nameof(MmDirtyWriteIoCount), value); }

        [Offset(11568UL)]
        public int MmMappedPagesWriteCount { get => ReadHere<int>(nameof(MmMappedPagesWriteCount)); set => WriteHere(nameof(MmMappedPagesWriteCount), value); }

        [Offset(11572UL)]
        public int MmMappedWriteIoCount { get => ReadHere<int>(nameof(MmMappedWriteIoCount)); set => WriteHere(nameof(MmMappedWriteIoCount), value); }

        [Offset(11576UL)]
        public uint KeSystemCalls { get => ReadHere<uint>(nameof(KeSystemCalls)); set => WriteHere(nameof(KeSystemCalls), value); }

        [Offset(11580UL)]
        public uint KeContextSwitches { get => ReadHere<uint>(nameof(KeContextSwitches)); set => WriteHere(nameof(KeContextSwitches), value); }

        [Offset(11584UL)]
        public uint PrcbPad40 { get => ReadHere<uint>(nameof(PrcbPad40)); set => WriteHere(nameof(PrcbPad40), value); }

        [Offset(11588UL)]
        public uint CcFastReadNoWait { get => ReadHere<uint>(nameof(CcFastReadNoWait)); set => WriteHere(nameof(CcFastReadNoWait), value); }

        [Offset(11592UL)]
        public uint CcFastReadWait { get => ReadHere<uint>(nameof(CcFastReadWait)); set => WriteHere(nameof(CcFastReadWait), value); }

        [Offset(11596UL)]
        public uint CcFastReadNotPossible { get => ReadHere<uint>(nameof(CcFastReadNotPossible)); set => WriteHere(nameof(CcFastReadNotPossible), value); }

        [Offset(11600UL)]
        public uint CcCopyReadNoWait { get => ReadHere<uint>(nameof(CcCopyReadNoWait)); set => WriteHere(nameof(CcCopyReadNoWait), value); }

        [Offset(11604UL)]
        public uint CcCopyReadWait { get => ReadHere<uint>(nameof(CcCopyReadWait)); set => WriteHere(nameof(CcCopyReadWait), value); }

        [Offset(11608UL)]
        public uint CcCopyReadNoWaitMiss { get => ReadHere<uint>(nameof(CcCopyReadNoWaitMiss)); set => WriteHere(nameof(CcCopyReadNoWaitMiss), value); }

        [Offset(11612UL)]
        public int IoReadOperationCount { get => ReadHere<int>(nameof(IoReadOperationCount)); set => WriteHere(nameof(IoReadOperationCount), value); }

        [Offset(11616UL)]
        public int IoWriteOperationCount { get => ReadHere<int>(nameof(IoWriteOperationCount)); set => WriteHere(nameof(IoWriteOperationCount), value); }

        [Offset(11620UL)]
        public int IoOtherOperationCount { get => ReadHere<int>(nameof(IoOtherOperationCount)); set => WriteHere(nameof(IoOtherOperationCount), value); }

        [Offset(11624UL)]
        public LargeInteger IoReadTransferCount { get => ReadStructure<LargeInteger>(nameof(IoReadTransferCount)); set => WriteStructure(nameof(IoReadTransferCount), value); }

        [Offset(11632UL)]
        public LargeInteger IoWriteTransferCount { get => ReadStructure<LargeInteger>(nameof(IoWriteTransferCount)); set => WriteStructure(nameof(IoWriteTransferCount), value); }

        [Offset(11640UL)]
        public LargeInteger IoOtherTransferCount { get => ReadStructure<LargeInteger>(nameof(IoOtherTransferCount)); set => WriteStructure(nameof(IoOtherTransferCount), value); }

        [Offset(11648UL)]
        public int PacketBarrier { get => ReadHere<int>(nameof(PacketBarrier)); set => WriteHere(nameof(PacketBarrier), value); }

        [Offset(11652UL)]
        public int TargetCount { get => ReadHere<int>(nameof(TargetCount)); set => WriteHere(nameof(TargetCount), value); }

        [Offset(11656UL)]
        public uint IpiFrozen { get => ReadHere<uint>(nameof(IpiFrozen)); set => WriteHere(nameof(IpiFrozen), value); }

        [Offset(11660UL)]
        public uint PrcbPad30 { get => ReadHere<uint>(nameof(PrcbPad30)); set => WriteHere(nameof(PrcbPad30), value); }

        [Offset(11664UL)]
        public IntPtr IsrDpcStats { get => ReadHere<IntPtr>(nameof(IsrDpcStats)); set => WriteHere(nameof(IsrDpcStats), value); }

        [Offset(11672UL)]
        public uint DeviceInterrupts { get => ReadHere<uint>(nameof(DeviceInterrupts)); set => WriteHere(nameof(DeviceInterrupts), value); }

        [Offset(11676UL)]
        public int LookasideIrpFloat { get => ReadHere<int>(nameof(LookasideIrpFloat)); set => WriteHere(nameof(LookasideIrpFloat), value); }

        [Offset(11680UL)]
        public uint InterruptLastCount { get => ReadHere<uint>(nameof(InterruptLastCount)); set => WriteHere(nameof(InterruptLastCount), value); }

        [Offset(11684UL)]
        public uint InterruptRate { get => ReadHere<uint>(nameof(InterruptRate)); set => WriteHere(nameof(InterruptRate), value); }

        [Offset(11688UL)]
        public ulong PrcbPad31 { get => ReadHere<ulong>(nameof(PrcbPad31)); set => WriteHere(nameof(PrcbPad31), value); }

        [Offset(11696UL)]
        public IntPtr PairPrcb { get => ReadHere<IntPtr>(nameof(PairPrcb)); set => WriteHere(nameof(PairPrcb), value); }

        [Offset(11704UL)]
        public KstaticAffinityBlock StaticAffinity { get => ReadStructure<KstaticAffinityBlock>(nameof(StaticAffinity)); set => WriteStructure(nameof(StaticAffinity), value); }

        [Offset(13784UL)]
        public KsoftwareInterruptBatch DeferredDispatchInterrupts { get => ReadStructure<KsoftwareInterruptBatch>(nameof(DeferredDispatchInterrupts)); set => WriteStructure(nameof(DeferredDispatchInterrupts), value); }

        [Offset(14312UL)]
        public IntPtr StaticRescheduleContext { get => ReadHere<IntPtr>(nameof(StaticRescheduleContext)); set => WriteHere(nameof(StaticRescheduleContext), value); }

        [Offset(14320UL)]
        public IntPtr CpuPartition { get => ReadHere<IntPtr>(nameof(CpuPartition)); set => WriteHere(nameof(CpuPartition), value); }

        [Offset(14328UL)]
        [Length(1)]
        public DynamicArray PrcbPad35 { get => ReadStructure<DynamicArray>(nameof(PrcbPad35)); set => WriteStructure(nameof(PrcbPad35), value); }

        [Offset(14336UL)]
        public SlistHeader InterruptObjectPool { get => ReadStructure<SlistHeader>(nameof(InterruptObjectPool)); set => WriteStructure(nameof(InterruptObjectPool), value); }

        [Offset(14352UL)]
        public IntPtr DpcRuntimeHistoryHashTable { get => ReadHere<IntPtr>(nameof(DpcRuntimeHistoryHashTable)); set => WriteHere(nameof(DpcRuntimeHistoryHashTable), value); }

        [Offset(14360UL)]
        public IntPtr DpcRuntimeHistoryHashTableCleanupDpc { get => ReadHere<IntPtr>(nameof(DpcRuntimeHistoryHashTableCleanupDpc)); set => WriteHere(nameof(DpcRuntimeHistoryHashTableCleanupDpc), value); }

        [Offset(14368UL)]
        public IntPtr CurrentDpcRoutine { get => ReadHere<IntPtr>(nameof(CurrentDpcRoutine)); set => WriteHere(nameof(CurrentDpcRoutine), value); }

        [Offset(14376UL)]
        public ulong CurrentDpcRuntimeHistoryCached { get => ReadHere<ulong>(nameof(CurrentDpcRuntimeHistoryCached)); set => WriteHere(nameof(CurrentDpcRuntimeHistoryCached), value); }

        [Offset(14384UL)]
        public ulong CurrentDpcStartTime { get => ReadHere<ulong>(nameof(CurrentDpcStartTime)); set => WriteHere(nameof(CurrentDpcStartTime), value); }

        [Offset(14392UL)]
        public IntPtr DpcDelegateThread { get => ReadHere<IntPtr>(nameof(DpcDelegateThread)); set => WriteHere(nameof(DpcDelegateThread), value); }

        [Offset(14400UL)]
        [Length(2)]
        public DynamicArray DpcData { get => ReadStructure<DynamicArray>(nameof(DpcData)); set => WriteStructure(nameof(DpcData), value); }

        [Offset(14496UL)]
        public IntPtr DpcStack { get => ReadHere<IntPtr>(nameof(DpcStack)); set => WriteHere(nameof(DpcStack), value); }

        [Offset(14504UL)]
        public int MaximumDpcQueueDepth { get => ReadHere<int>(nameof(MaximumDpcQueueDepth)); set => WriteHere(nameof(MaximumDpcQueueDepth), value); }

        [Offset(14508UL)]
        public uint DpcRequestRate { get => ReadHere<uint>(nameof(DpcRequestRate)); set => WriteHere(nameof(DpcRequestRate), value); }

        [Offset(14512UL)]
        public uint MinimumDpcRate { get => ReadHere<uint>(nameof(MinimumDpcRate)); set => WriteHere(nameof(MinimumDpcRate), value); }

        [Offset(14516UL)]
        public uint DpcLastCount { get => ReadHere<uint>(nameof(DpcLastCount)); set => WriteHere(nameof(DpcLastCount), value); }

        [Offset(14520UL)]
        public byte ThreadDpcEnable { get => ReadHere<byte>(nameof(ThreadDpcEnable)); set => WriteHere(nameof(ThreadDpcEnable), value); }

        [Offset(14521UL)]
        public byte QuantumEnd { get => ReadHere<byte>(nameof(QuantumEnd)); set => WriteHere(nameof(QuantumEnd), value); }

        [Offset(14522UL)]
        public byte DpcRoutineActive { get => ReadHere<byte>(nameof(DpcRoutineActive)); set => WriteHere(nameof(DpcRoutineActive), value); }

        [Offset(14523UL)]
        public byte IdleSchedule { get => ReadHere<byte>(nameof(IdleSchedule)); set => WriteHere(nameof(IdleSchedule), value); }

        [Offset(14524UL)]
        public int DpcRequestSummary { get => ReadHere<int>(nameof(DpcRequestSummary)); set => WriteHere(nameof(DpcRequestSummary), value); }

        [Offset(14524UL)]
        [Length(2)]
        public DynamicArray DpcRequestSlot { get => ReadStructure<DynamicArray>(nameof(DpcRequestSlot)); set => WriteStructure(nameof(DpcRequestSlot), value); }

        [Offset(14524UL)]
        public short NormalDpcState { get => ReadHere<short>(nameof(NormalDpcState)); set => WriteHere(nameof(NormalDpcState), value); }

        [Offset(14526UL)]
        public short ThreadDpcState { get => ReadHere<short>(nameof(ThreadDpcState)); set => WriteHere(nameof(ThreadDpcState), value); }

        [Offset(14524UL)]
        public uint DpcNormalProcessingActive { get => ReadHere<uint>(nameof(DpcNormalProcessingActive)); set => WriteHere(nameof(DpcNormalProcessingActive), value); }

        [Offset(14524UL)]
        public uint DpcNormalProcessingRequested { get => ReadHere<uint>(nameof(DpcNormalProcessingRequested)); set => WriteHere(nameof(DpcNormalProcessingRequested), value); }

        [Offset(14524UL)]
        public uint DpcNormalThreadSignal { get => ReadHere<uint>(nameof(DpcNormalThreadSignal)); set => WriteHere(nameof(DpcNormalThreadSignal), value); }

        [Offset(14524UL)]
        public uint DpcNormalTimerExpiration { get => ReadHere<uint>(nameof(DpcNormalTimerExpiration)); set => WriteHere(nameof(DpcNormalTimerExpiration), value); }

        [Offset(14524UL)]
        public uint DpcNormalDpcPresent { get => ReadHere<uint>(nameof(DpcNormalDpcPresent)); set => WriteHere(nameof(DpcNormalDpcPresent), value); }

        [Offset(14524UL)]
        public uint DpcNormalLocalInterrupt { get => ReadHere<uint>(nameof(DpcNormalLocalInterrupt)); set => WriteHere(nameof(DpcNormalLocalInterrupt), value); }

        [Offset(14524UL)]
        public uint DpcNormalPriorityAntiStarvation { get => ReadHere<uint>(nameof(DpcNormalPriorityAntiStarvation)); set => WriteHere(nameof(DpcNormalPriorityAntiStarvation), value); }

        [Offset(14524UL)]
        public uint DpcNormalSwapToDpcDelegate { get => ReadHere<uint>(nameof(DpcNormalSwapToDpcDelegate)); set => WriteHere(nameof(DpcNormalSwapToDpcDelegate), value); }

        [Offset(14524UL)]
        public uint DpcNormalSpare { get => ReadHere<uint>(nameof(DpcNormalSpare)); set => WriteHere(nameof(DpcNormalSpare), value); }

        [Offset(14524UL)]
        public uint DpcThreadActive { get => ReadHere<uint>(nameof(DpcThreadActive)); set => WriteHere(nameof(DpcThreadActive), value); }

        [Offset(14524UL)]
        public uint DpcThreadRequested { get => ReadHere<uint>(nameof(DpcThreadRequested)); set => WriteHere(nameof(DpcThreadRequested), value); }

        [Offset(14524UL)]
        public uint DpcThreadSpare { get => ReadHere<uint>(nameof(DpcThreadSpare)); set => WriteHere(nameof(DpcThreadSpare), value); }

        [Offset(14528UL)]
        public uint LastTick { get => ReadHere<uint>(nameof(LastTick)); set => WriteHere(nameof(LastTick), value); }

        [Offset(14532UL)]
        public uint ClockInterrupts { get => ReadHere<uint>(nameof(ClockInterrupts)); set => WriteHere(nameof(ClockInterrupts), value); }

        [Offset(14536UL)]
        public uint ReadyScanTick { get => ReadHere<uint>(nameof(ReadyScanTick)); set => WriteHere(nameof(ReadyScanTick), value); }

        [Offset(14540UL)]
        public uint SingleDpcSoftTimeLimitTicks { get => ReadHere<uint>(nameof(SingleDpcSoftTimeLimitTicks)); set => WriteHere(nameof(SingleDpcSoftTimeLimitTicks), value); }

        [Offset(14544UL)]
        public IntPtr SingleDpcSoftTimeoutEventInfo { get => ReadHere<IntPtr>(nameof(SingleDpcSoftTimeoutEventInfo)); set => WriteHere(nameof(SingleDpcSoftTimeoutEventInfo), value); }

        [Offset(14552UL)]
        public uint CumulativeDpcSoftTimeLimitTicks { get => ReadHere<uint>(nameof(CumulativeDpcSoftTimeLimitTicks)); set => WriteHere(nameof(CumulativeDpcSoftTimeLimitTicks), value); }

        [Offset(14556UL)]
        public uint DpcWatchdogProfileBufferSize { get => ReadHere<uint>(nameof(DpcWatchdogProfileBufferSize)); set => WriteHere(nameof(DpcWatchdogProfileBufferSize), value); }

        [Offset(14560UL)]
        public KePrcbRcuData RcuData { get => ReadStructure<KePrcbRcuData>(nameof(RcuData)); set => WriteStructure(nameof(RcuData), value); }

        [Offset(14592UL)]
        [Length(256)]
        public DynamicArray InterruptObject { get => ReadStructure<DynamicArray>(nameof(InterruptObject)); set => WriteStructure(nameof(InterruptObject), value); }

        [Offset(16640UL)]
        public KtimerTable TimerTable { get => ReadStructure<KtimerTable>(nameof(TimerTable)); set => WriteStructure(nameof(TimerTable), value); }

        [Offset(33560UL)]
        public IntPtr DpcLog { get => ReadHere<IntPtr>(nameof(DpcLog)); set => WriteHere(nameof(DpcLog), value); }

        [Offset(33568UL)]
        public uint DpcLogIndex { get => ReadHere<uint>(nameof(DpcLogIndex)); set => WriteHere(nameof(DpcLogIndex), value); }

        [Offset(33572UL)]
        public uint DpcLogBufferSize { get => ReadHere<uint>(nameof(DpcLogBufferSize)); set => WriteHere(nameof(DpcLogBufferSize), value); }

        [Offset(33576UL)]
        [Length(6)]
        public DynamicArray PrcbPad92 { get => ReadStructure<DynamicArray>(nameof(PrcbPad92)); set => WriteStructure(nameof(PrcbPad92), value); }

        [Offset(33600UL)]
        public Kgate DpcGate { get => ReadStructure<Kgate>(nameof(DpcGate)); set => WriteStructure(nameof(DpcGate), value); }

        [Offset(33624UL)]
        public IntPtr PrcbPad52 { get => ReadHere<IntPtr>(nameof(PrcbPad52)); set => WriteHere(nameof(PrcbPad52), value); }

        [Offset(33632UL)]
        public Kdpc CallDpc { get => ReadStructure<Kdpc>(nameof(CallDpc)); set => WriteStructure(nameof(CallDpc), value); }

        [Offset(33696UL)]
        public int ClockKeepAlive { get => ReadHere<int>(nameof(ClockKeepAlive)); set => WriteHere(nameof(ClockKeepAlive), value); }

        [Offset(33700UL)]
        [Length(2)]
        public DynamicArray PrcbPad60 { get => ReadStructure<DynamicArray>(nameof(PrcbPad60)); set => WriteStructure(nameof(PrcbPad60), value); }

        [Offset(33702UL)]
        public byte NmiActive { get => ReadHere<byte>(nameof(NmiActive)); set => WriteHere(nameof(NmiActive), value); }

        [Offset(33703UL)]
        public byte MceActive { get => ReadHere<byte>(nameof(MceActive)); set => WriteHere(nameof(MceActive), value); }

        [Offset(33702UL)]
        public ushort CombinedNmiMceActive { get => ReadHere<ushort>(nameof(CombinedNmiMceActive)); set => WriteHere(nameof(CombinedNmiMceActive), value); }

        [Offset(33704UL)]
        public int DpcWatchdogPeriodTicks { get => ReadHere<int>(nameof(DpcWatchdogPeriodTicks)); set => WriteHere(nameof(DpcWatchdogPeriodTicks), value); }

        [Offset(33708UL)]
        public int DpcWatchdogCount { get => ReadHere<int>(nameof(DpcWatchdogCount)); set => WriteHere(nameof(DpcWatchdogCount), value); }

        [Offset(33712UL)]
        public int KeSpinLockOrdering { get => ReadHere<int>(nameof(KeSpinLockOrdering)); set => WriteHere(nameof(KeSpinLockOrdering), value); }

        [Offset(33716UL)]
        public uint DpcWatchdogProfileCumulativeDpcThresholdTicks { get => ReadHere<uint>(nameof(DpcWatchdogProfileCumulativeDpcThresholdTicks)); set => WriteHere(nameof(DpcWatchdogProfileCumulativeDpcThresholdTicks), value); }

        [Offset(33720UL)]
        public IntPtr CachedPtes { get => ReadHere<IntPtr>(nameof(CachedPtes)); set => WriteHere(nameof(CachedPtes), value); }

        [Offset(33728UL)]
        public ListEntry WaitListHead { get => ReadStructure<ListEntry>(nameof(WaitListHead)); set => WriteStructure(nameof(WaitListHead), value); }

        [Offset(33744UL)]
        public ulong WaitLock { get => ReadHere<ulong>(nameof(WaitLock)); set => WriteHere(nameof(WaitLock), value); }

        [Offset(33752UL)]
        public uint ReadySummary { get => ReadHere<uint>(nameof(ReadySummary)); set => WriteHere(nameof(ReadySummary), value); }

        [Offset(33756UL)]
        public int AffinitizedSelectionMask { get => ReadHere<int>(nameof(AffinitizedSelectionMask)); set => WriteHere(nameof(AffinitizedSelectionMask), value); }

        [Offset(33760UL)]
        public uint QueueIndex { get => ReadHere<uint>(nameof(QueueIndex)); set => WriteHere(nameof(QueueIndex), value); }

        [Offset(33764UL)]
        public uint NormalPriorityQueueIndex { get => ReadHere<uint>(nameof(NormalPriorityQueueIndex)); set => WriteHere(nameof(NormalPriorityQueueIndex), value); }

        [Offset(33768UL)]
        public uint NormalPriorityReadyScanTick { get => ReadHere<uint>(nameof(NormalPriorityReadyScanTick)); set => WriteHere(nameof(NormalPriorityReadyScanTick), value); }

        [Offset(33772UL)]
        public uint DpcWatchdogSequenceNumber { get => ReadHere<uint>(nameof(DpcWatchdogSequenceNumber)); set => WriteHere(nameof(DpcWatchdogSequenceNumber), value); }

        [Offset(33776UL)]
        public Kdpc TimerExpirationDpc { get => ReadStructure<Kdpc>(nameof(TimerExpirationDpc)); set => WriteStructure(nameof(TimerExpirationDpc), value); }

        [Offset(33840UL)]
        public RtlRbTree ScbQueue { get => ReadStructure<RtlRbTree>(nameof(ScbQueue)); set => WriteStructure(nameof(ScbQueue), value); }

        [Offset(33856UL)]
        [Length(32)]
        public DynamicArray DispatcherReadyListHead { get => ReadStructure<DynamicArray>(nameof(DispatcherReadyListHead)); set => WriteStructure(nameof(DispatcherReadyListHead), value); }

        [Offset(34368UL)]
        public uint InterruptCount { get => ReadHere<uint>(nameof(InterruptCount)); set => WriteHere(nameof(InterruptCount), value); }

        [Offset(34372UL)]
        public uint KernelTime { get => ReadHere<uint>(nameof(KernelTime)); set => WriteHere(nameof(KernelTime), value); }

        [Offset(34376UL)]
        public uint UserTime { get => ReadHere<uint>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(34380UL)]
        public uint DpcTime { get => ReadHere<uint>(nameof(DpcTime)); set => WriteHere(nameof(DpcTime), value); }

        [Offset(34384UL)]
        public uint InterruptTime { get => ReadHere<uint>(nameof(InterruptTime)); set => WriteHere(nameof(InterruptTime), value); }

        [Offset(34388UL)]
        public uint AdjustDpcThreshold { get => ReadHere<uint>(nameof(AdjustDpcThreshold)); set => WriteHere(nameof(AdjustDpcThreshold), value); }

        [Offset(34392UL)]
        public byte DebuggerSavedIRQL { get => ReadHere<byte>(nameof(DebuggerSavedIRQL)); set => WriteHere(nameof(DebuggerSavedIRQL), value); }

        [Offset(34393UL)]
        public byte GroupSchedulingOverQuota { get => ReadHere<byte>(nameof(GroupSchedulingOverQuota)); set => WriteHere(nameof(GroupSchedulingOverQuota), value); }

        [Offset(34394UL)]
        public byte DeepSleep { get => ReadHere<byte>(nameof(DeepSleep)); set => WriteHere(nameof(DeepSleep), value); }

        [Offset(34395UL)]
        public byte PrcbPad80 { get => ReadHere<byte>(nameof(PrcbPad80)); set => WriteHere(nameof(PrcbPad80), value); }

        [Offset(34396UL)]
        public uint DpcTimeCount { get => ReadHere<uint>(nameof(DpcTimeCount)); set => WriteHere(nameof(DpcTimeCount), value); }

        [Offset(34400UL)]
        public uint DpcTimeLimitTicks { get => ReadHere<uint>(nameof(DpcTimeLimitTicks)); set => WriteHere(nameof(DpcTimeLimitTicks), value); }

        [Offset(34404UL)]
        public uint PeriodicCount { get => ReadHere<uint>(nameof(PeriodicCount)); set => WriteHere(nameof(PeriodicCount), value); }

        [Offset(34408UL)]
        public uint PeriodicBias { get => ReadHere<uint>(nameof(PeriodicBias)); set => WriteHere(nameof(PeriodicBias), value); }

        [Offset(34412UL)]
        public uint AvailableTime { get => ReadHere<uint>(nameof(AvailableTime)); set => WriteHere(nameof(AvailableTime), value); }

        [Offset(34416UL)]
        public uint KeExceptionDispatchCount { get => ReadHere<uint>(nameof(KeExceptionDispatchCount)); set => WriteHere(nameof(KeExceptionDispatchCount), value); }

        [Offset(34420UL)]
        public uint ReadyThreadCount { get => ReadHere<uint>(nameof(ReadyThreadCount)); set => WriteHere(nameof(ReadyThreadCount), value); }

        [Offset(34424UL)]
        public ulong ReadyQueueExpectedRunTime { get => ReadHere<ulong>(nameof(ReadyQueueExpectedRunTime)); set => WriteHere(nameof(ReadyQueueExpectedRunTime), value); }

        [Offset(34432UL)]
        public ulong StartCycles { get => ReadHere<ulong>(nameof(StartCycles)); set => WriteHere(nameof(StartCycles), value); }

        [Offset(34440UL)]
        [Length(4)]
        public DynamicArray TaggedCycles { get => ReadStructure<DynamicArray>(nameof(TaggedCycles)); set => WriteStructure(nameof(TaggedCycles), value); }

        [Offset(34472UL)]
        public ulong AffinitizedCycles { get => ReadHere<ulong>(nameof(AffinitizedCycles)); set => WriteHere(nameof(AffinitizedCycles), value); }

        [Offset(34480UL)]
        public IntPtr CyclesByThreadType { get => ReadHere<IntPtr>(nameof(CyclesByThreadType)); set => WriteHere(nameof(CyclesByThreadType), value); }

        [Offset(34488UL)]
        public uint CpuCycleScalingFactor { get => ReadHere<uint>(nameof(CpuCycleScalingFactor)); set => WriteHere(nameof(CpuCycleScalingFactor), value); }

        [Offset(34492UL)]
        [Length(8)]
        public DynamicArray PerformanceScoreByClass { get => ReadStructure<DynamicArray>(nameof(PerformanceScoreByClass)); set => WriteStructure(nameof(PerformanceScoreByClass), value); }

        [Offset(34508UL)]
        [Length(8)]
        public DynamicArray EfficiencyScoreByClass { get => ReadStructure<DynamicArray>(nameof(EfficiencyScoreByClass)); set => WriteStructure(nameof(EfficiencyScoreByClass), value); }

        [Offset(34524UL)]
        public byte CycleAccumulationInitialized { get => ReadHere<byte>(nameof(CycleAccumulationInitialized)); set => WriteHere(nameof(CycleAccumulationInitialized), value); }

        [Offset(34525UL)]
        [Length(3)]
        public DynamicArray PrcbPad83 { get => ReadStructure<DynamicArray>(nameof(PrcbPad83)); set => WriteStructure(nameof(PrcbPad83), value); }

        [Offset(34528UL)]
        public KmceRecoveryContext MceRecoveryContext { get => ReadStructure<KmceRecoveryContext>(nameof(MceRecoveryContext)); set => WriteStructure(nameof(MceRecoveryContext), value); }

        [Offset(34544UL)]
        public IntPtr ForceParkDutyCycleData { get => ReadHere<IntPtr>(nameof(ForceParkDutyCycleData)); set => WriteHere(nameof(ForceParkDutyCycleData), value); }

        [Offset(34552UL)]
        public ulong StartCyclesQpc { get => ReadHere<ulong>(nameof(StartCyclesQpc)); set => WriteHere(nameof(StartCyclesQpc), value); }

        [Offset(34560UL)]
        public ulong CycleTimeQpc { get => ReadHere<ulong>(nameof(CycleTimeQpc)); set => WriteHere(nameof(CycleTimeQpc), value); }

        [Offset(34568UL)]
        public ulong NumberOfSecureFaults { get => ReadHere<ulong>(nameof(NumberOfSecureFaults)); set => WriteHere(nameof(NumberOfSecureFaults), value); }

        [Offset(34576UL)]
        [Length(8)]
        public DynamicArray PrcbPad84 { get => ReadStructure<DynamicArray>(nameof(PrcbPad84)); set => WriteStructure(nameof(PrcbPad84), value); }

        [Offset(34608UL)]
        [Length(2)]
        public DynamicArray CachedStacks { get => ReadStructure<DynamicArray>(nameof(CachedStacks)); set => WriteStructure(nameof(CachedStacks), value); }

        [Offset(34624UL)]
        public uint DpcWatchdogProfileSingleDpcThresholdTicks { get => ReadHere<uint>(nameof(DpcWatchdogProfileSingleDpcThresholdTicks)); set => WriteHere(nameof(DpcWatchdogProfileSingleDpcThresholdTicks), value); }

        [Offset(34628UL)]
        [Length(3)]
        public DynamicArray PrcbPad82 { get => ReadStructure<DynamicArray>(nameof(PrcbPad82)); set => WriteStructure(nameof(PrcbPad82), value); }

        [Offset(34640UL)]
        public uint PageColor { get => ReadHere<uint>(nameof(PageColor)); set => WriteHere(nameof(PageColor), value); }

        [Offset(34644UL)]
        public uint NodeColor { get => ReadHere<uint>(nameof(NodeColor)); set => WriteHere(nameof(NodeColor), value); }

        [Offset(34648UL)]
        [Length(2)]
        public DynamicArray PrcbPad87 { get => ReadStructure<DynamicArray>(nameof(PrcbPad87)); set => WriteStructure(nameof(PrcbPad87), value); }

        [Offset(34656UL)]
        [Length(5)]
        public DynamicArray PrcbPad81 { get => ReadStructure<DynamicArray>(nameof(PrcbPad81)); set => WriteStructure(nameof(PrcbPad81), value); }

        [Offset(34661UL)]
        public byte SystemWorkKickInProgress { get => ReadHere<byte>(nameof(SystemWorkKickInProgress)); set => WriteHere(nameof(SystemWorkKickInProgress), value); }

        [Offset(34662UL)]
        public byte ExceptionStackActive { get => ReadHere<byte>(nameof(ExceptionStackActive)); set => WriteHere(nameof(ExceptionStackActive), value); }

        [Offset(34663UL)]
        public byte TbFlushListActive { get => ReadHere<byte>(nameof(TbFlushListActive)); set => WriteHere(nameof(TbFlushListActive), value); }

        [Offset(34664UL)]
        public IntPtr ExceptionStack { get => ReadHere<IntPtr>(nameof(ExceptionStack)); set => WriteHere(nameof(ExceptionStack), value); }

        [Offset(34672UL)]
        public long MmSpinLockOrdering { get => ReadHere<long>(nameof(MmSpinLockOrdering)); set => WriteHere(nameof(MmSpinLockOrdering), value); }

        [Offset(34680UL)]
        public ulong CycleTime { get => ReadHere<ulong>(nameof(CycleTime)); set => WriteHere(nameof(CycleTime), value); }

        [Offset(34688UL)]
        [Length(4)]
        public DynamicArray Cycles { get => ReadStructure<DynamicArray>(nameof(Cycles)); set => WriteStructure(nameof(Cycles), value); }

        [Offset(34752UL)]
        public uint CcFastMdlReadNoWait { get => ReadHere<uint>(nameof(CcFastMdlReadNoWait)); set => WriteHere(nameof(CcFastMdlReadNoWait), value); }

        [Offset(34756UL)]
        public uint CcFastMdlReadWait { get => ReadHere<uint>(nameof(CcFastMdlReadWait)); set => WriteHere(nameof(CcFastMdlReadWait), value); }

        [Offset(34760UL)]
        public uint CcFastMdlReadNotPossible { get => ReadHere<uint>(nameof(CcFastMdlReadNotPossible)); set => WriteHere(nameof(CcFastMdlReadNotPossible), value); }

        [Offset(34764UL)]
        public uint CcMapDataNoWait { get => ReadHere<uint>(nameof(CcMapDataNoWait)); set => WriteHere(nameof(CcMapDataNoWait), value); }

        [Offset(34768UL)]
        public uint CcMapDataWait { get => ReadHere<uint>(nameof(CcMapDataWait)); set => WriteHere(nameof(CcMapDataWait), value); }

        [Offset(34772UL)]
        public uint CcPinMappedDataCount { get => ReadHere<uint>(nameof(CcPinMappedDataCount)); set => WriteHere(nameof(CcPinMappedDataCount), value); }

        [Offset(34776UL)]
        public uint CcPinReadNoWait { get => ReadHere<uint>(nameof(CcPinReadNoWait)); set => WriteHere(nameof(CcPinReadNoWait), value); }

        [Offset(34780UL)]
        public uint CcPinReadWait { get => ReadHere<uint>(nameof(CcPinReadWait)); set => WriteHere(nameof(CcPinReadWait), value); }

        [Offset(34784UL)]
        public uint CcMdlReadNoWait { get => ReadHere<uint>(nameof(CcMdlReadNoWait)); set => WriteHere(nameof(CcMdlReadNoWait), value); }

        [Offset(34788UL)]
        public uint CcMdlReadWait { get => ReadHere<uint>(nameof(CcMdlReadWait)); set => WriteHere(nameof(CcMdlReadWait), value); }

        [Offset(34792UL)]
        public uint CcLazyWriteHotSpots { get => ReadHere<uint>(nameof(CcLazyWriteHotSpots)); set => WriteHere(nameof(CcLazyWriteHotSpots), value); }

        [Offset(34796UL)]
        public uint CcLazyWriteIos { get => ReadHere<uint>(nameof(CcLazyWriteIos)); set => WriteHere(nameof(CcLazyWriteIos), value); }

        [Offset(34800UL)]
        public uint CcLazyWritePages { get => ReadHere<uint>(nameof(CcLazyWritePages)); set => WriteHere(nameof(CcLazyWritePages), value); }

        [Offset(34804UL)]
        public uint CcDataFlushes { get => ReadHere<uint>(nameof(CcDataFlushes)); set => WriteHere(nameof(CcDataFlushes), value); }

        [Offset(34808UL)]
        public uint CcDataPages { get => ReadHere<uint>(nameof(CcDataPages)); set => WriteHere(nameof(CcDataPages), value); }

        [Offset(34812UL)]
        public uint CcLostDelayedWrites { get => ReadHere<uint>(nameof(CcLostDelayedWrites)); set => WriteHere(nameof(CcLostDelayedWrites), value); }

        [Offset(34816UL)]
        public uint CcFastReadResourceMiss { get => ReadHere<uint>(nameof(CcFastReadResourceMiss)); set => WriteHere(nameof(CcFastReadResourceMiss), value); }

        [Offset(34820UL)]
        public uint CcCopyReadWaitMiss { get => ReadHere<uint>(nameof(CcCopyReadWaitMiss)); set => WriteHere(nameof(CcCopyReadWaitMiss), value); }

        [Offset(34824UL)]
        public uint CcFastMdlReadResourceMiss { get => ReadHere<uint>(nameof(CcFastMdlReadResourceMiss)); set => WriteHere(nameof(CcFastMdlReadResourceMiss), value); }

        [Offset(34828UL)]
        public uint CcMapDataNoWaitMiss { get => ReadHere<uint>(nameof(CcMapDataNoWaitMiss)); set => WriteHere(nameof(CcMapDataNoWaitMiss), value); }

        [Offset(34832UL)]
        public uint CcMapDataWaitMiss { get => ReadHere<uint>(nameof(CcMapDataWaitMiss)); set => WriteHere(nameof(CcMapDataWaitMiss), value); }

        [Offset(34836UL)]
        public uint CcPinReadNoWaitMiss { get => ReadHere<uint>(nameof(CcPinReadNoWaitMiss)); set => WriteHere(nameof(CcPinReadNoWaitMiss), value); }

        [Offset(34840UL)]
        public uint CcPinReadWaitMiss { get => ReadHere<uint>(nameof(CcPinReadWaitMiss)); set => WriteHere(nameof(CcPinReadWaitMiss), value); }

        [Offset(34844UL)]
        public uint CcMdlReadNoWaitMiss { get => ReadHere<uint>(nameof(CcMdlReadNoWaitMiss)); set => WriteHere(nameof(CcMdlReadNoWaitMiss), value); }

        [Offset(34848UL)]
        public uint CcMdlReadWaitMiss { get => ReadHere<uint>(nameof(CcMdlReadWaitMiss)); set => WriteHere(nameof(CcMdlReadWaitMiss), value); }

        [Offset(34852UL)]
        public uint CcReadAheadIos { get => ReadHere<uint>(nameof(CcReadAheadIos)); set => WriteHere(nameof(CcReadAheadIos), value); }

        [Offset(34856UL)]
        public int MmCacheTransitionCount { get => ReadHere<int>(nameof(MmCacheTransitionCount)); set => WriteHere(nameof(MmCacheTransitionCount), value); }

        [Offset(34860UL)]
        public int MmCacheReadCount { get => ReadHere<int>(nameof(MmCacheReadCount)); set => WriteHere(nameof(MmCacheReadCount), value); }

        [Offset(34864UL)]
        public int MmCacheIoCount { get => ReadHere<int>(nameof(MmCacheIoCount)); set => WriteHere(nameof(MmCacheIoCount), value); }

        [Offset(34868UL)]
        public uint PrcbPad91 { get => ReadHere<uint>(nameof(PrcbPad91)); set => WriteHere(nameof(PrcbPad91), value); }

        [Offset(34872UL)]
        public IntPtr MmInternal { get => ReadHere<IntPtr>(nameof(MmInternal)); set => WriteHere(nameof(MmInternal), value); }

        [Offset(34880UL)]
        public ProcessorPowerState PowerState { get => ReadStructure<ProcessorPowerState>(nameof(PowerState)); set => WriteStructure(nameof(PowerState), value); }

        [Offset(35448UL)]
        [Length(1)]
        public DynamicArray PrcbPad96 { get => ReadStructure<DynamicArray>(nameof(PrcbPad96)); set => WriteStructure(nameof(PrcbPad96), value); }

        [Offset(35456UL)]
        public IntPtr PrcbPad90 { get => ReadHere<IntPtr>(nameof(PrcbPad90)); set => WriteHere(nameof(PrcbPad90), value); }

        [Offset(35464UL)]
        public ListEntry ScbList { get => ReadStructure<ListEntry>(nameof(ScbList)); set => WriteStructure(nameof(ScbList), value); }

        [Offset(35480UL)]
        public Kdpc ForceIdleDpc { get => ReadStructure<Kdpc>(nameof(ForceIdleDpc)); set => WriteStructure(nameof(ForceIdleDpc), value); }

        [Offset(35544UL)]
        public Kdpc DpcWatchdogDpc { get => ReadStructure<Kdpc>(nameof(DpcWatchdogDpc)); set => WriteStructure(nameof(DpcWatchdogDpc), value); }

        [Offset(35608UL)]
        [Length(7)]
        public DynamicArray PrcbPad98 { get => ReadStructure<DynamicArray>(nameof(PrcbPad98)); set => WriteStructure(nameof(PrcbPad98), value); }

        [Offset(35664UL)]
        public IntPtr VmInternal { get => ReadHere<IntPtr>(nameof(VmInternal)); set => WriteHere(nameof(VmInternal), value); }

        [Offset(35672UL)]
        [Length(5)]
        public DynamicArray Cache { get => ReadStructure<DynamicArray>(nameof(Cache)); set => WriteStructure(nameof(Cache), value); }

        [Offset(35732UL)]
        public uint CacheCount { get => ReadHere<uint>(nameof(CacheCount)); set => WriteHere(nameof(CacheCount), value); }

        [Offset(35736UL)]
        public uint CachedCommit { get => ReadHere<uint>(nameof(CachedCommit)); set => WriteHere(nameof(CachedCommit), value); }

        [Offset(35740UL)]
        public uint CachedResidentAvailable { get => ReadHere<uint>(nameof(CachedResidentAvailable)); set => WriteHere(nameof(CachedResidentAvailable), value); }

        [Offset(35744UL)]
        public IntPtr WheaInfo { get => ReadHere<IntPtr>(nameof(WheaInfo)); set => WriteHere(nameof(WheaInfo), value); }

        [Offset(35752UL)]
        public IntPtr EtwSupport { get => ReadHere<IntPtr>(nameof(EtwSupport)); set => WriteHere(nameof(EtwSupport), value); }

        [Offset(35760UL)]
        public IntPtr ExSaPageArray { get => ReadHere<IntPtr>(nameof(ExSaPageArray)); set => WriteHere(nameof(ExSaPageArray), value); }

        [Offset(35768UL)]
        public uint KeAlignmentFixupCount { get => ReadHere<uint>(nameof(KeAlignmentFixupCount)); set => WriteHere(nameof(KeAlignmentFixupCount), value); }

        [Offset(35772UL)]
        public uint PrcbPad95 { get => ReadHere<uint>(nameof(PrcbPad95)); set => WriteHere(nameof(PrcbPad95), value); }

        [Offset(35776UL)]
        public SlistHeader HypercallPageList { get => ReadStructure<SlistHeader>(nameof(HypercallPageList)); set => WriteStructure(nameof(HypercallPageList), value); }

        [Offset(35792UL)]
        public IntPtr StatisticsPage { get => ReadHere<IntPtr>(nameof(StatisticsPage)); set => WriteHere(nameof(StatisticsPage), value); }

        [Offset(35800UL)]
        public ulong GenerationTarget { get => ReadHere<ulong>(nameof(GenerationTarget)); set => WriteHere(nameof(GenerationTarget), value); }

        [Offset(35808UL)]
        public LargeInteger VirtualApicAssistPage { get => ReadStructure<LargeInteger>(nameof(VirtualApicAssistPage)); set => WriteStructure(nameof(VirtualApicAssistPage), value); }

        [Offset(35816UL)]
        [Length(3)]
        public DynamicArray PrcbPad85 { get => ReadStructure<DynamicArray>(nameof(PrcbPad85)); set => WriteStructure(nameof(PrcbPad85), value); }

        [Offset(35840UL)]
        public IntPtr HypercallCachedPages { get => ReadHere<IntPtr>(nameof(HypercallCachedPages)); set => WriteHere(nameof(HypercallCachedPages), value); }

        [Offset(35848UL)]
        public IntPtr VirtualApicAssist { get => ReadHere<IntPtr>(nameof(VirtualApicAssist)); set => WriteHere(nameof(VirtualApicAssist), value); }

        [Offset(35856UL)]
        public KaffinityEx PackageProcessorSet { get => ReadStructure<KaffinityEx>(nameof(PackageProcessorSet)); set => WriteStructure(nameof(PackageProcessorSet), value); }

        [Offset(36120UL)]
        [Length(32)]
        public DynamicArray PrcbPad86 { get => ReadStructure<DynamicArray>(nameof(PrcbPad86)); set => WriteStructure(nameof(PrcbPad86), value); }

        [Offset(36376UL)]
        public uint ProcessorId { get => ReadHere<uint>(nameof(ProcessorId)); set => WriteHere(nameof(ProcessorId), value); }

        [Offset(36380UL)]
        public uint CoreId { get => ReadHere<uint>(nameof(CoreId)); set => WriteHere(nameof(CoreId), value); }

        [Offset(36384UL)]
        public uint ModuleId { get => ReadHere<uint>(nameof(ModuleId)); set => WriteHere(nameof(ModuleId), value); }

        [Offset(36388UL)]
        public uint DieId { get => ReadHere<uint>(nameof(DieId)); set => WriteHere(nameof(DieId), value); }

        [Offset(36392UL)]
        public uint PackageId { get => ReadHere<uint>(nameof(PackageId)); set => WriteHere(nameof(PackageId), value); }

        [Offset(36376UL)]
        [Length(5)]
        public DynamicArray TopologyId { get => ReadStructure<DynamicArray>(nameof(TopologyId)); set => WriteStructure(nameof(TopologyId), value); }

        [Offset(36396UL)]
        [Length(5)]
        public DynamicArray NodeRelativeTopologyIndex { get => ReadStructure<DynamicArray>(nameof(NodeRelativeTopologyIndex)); set => WriteStructure(nameof(NodeRelativeTopologyIndex), value); }

        [Offset(36416UL)]
        public ulong SharedReadyQueueMask { get => ReadHere<ulong>(nameof(SharedReadyQueueMask)); set => WriteHere(nameof(SharedReadyQueueMask), value); }

        [Offset(36424UL)]
        public IntPtr SharedReadyQueue { get => ReadHere<IntPtr>(nameof(SharedReadyQueue)); set => WriteHere(nameof(SharedReadyQueue), value); }

        [Offset(36432UL)]
        public uint SharedQueueScanOwner { get => ReadHere<uint>(nameof(SharedQueueScanOwner)); set => WriteHere(nameof(SharedQueueScanOwner), value); }

        [Offset(36436UL)]
        public uint ScanSiblingIndex { get => ReadHere<uint>(nameof(ScanSiblingIndex)); set => WriteHere(nameof(ScanSiblingIndex), value); }

        [Offset(36440UL)]
        public IntPtr CoreControlBlock { get => ReadHere<IntPtr>(nameof(CoreControlBlock)); set => WriteHere(nameof(CoreControlBlock), value); }

        [Offset(36448UL)]
        public ulong CoreProcessorSet { get => ReadHere<ulong>(nameof(CoreProcessorSet)); set => WriteHere(nameof(CoreProcessorSet), value); }

        [Offset(36456UL)]
        public ulong ScanSiblingMask { get => ReadHere<ulong>(nameof(ScanSiblingMask)); set => WriteHere(nameof(ScanSiblingMask), value); }

        [Offset(36464UL)]
        public ulong LLCMask { get => ReadHere<ulong>(nameof(LLCMask)); set => WriteHere(nameof(LLCMask), value); }

        [Offset(36472UL)]
        public ulong GroupModuleProcessorSet { get => ReadHere<ulong>(nameof(GroupModuleProcessorSet)); set => WriteHere(nameof(GroupModuleProcessorSet), value); }

        [Offset(36480UL)]
        public IntPtr SmtIsolationThread { get => ReadHere<IntPtr>(nameof(SmtIsolationThread)); set => WriteHere(nameof(SmtIsolationThread), value); }

        [Offset(36488UL)]
        [Length(2)]
        public DynamicArray PrcbPad97 { get => ReadStructure<DynamicArray>(nameof(PrcbPad97)); set => WriteStructure(nameof(PrcbPad97), value); }

        [Offset(36504UL)]
        public IntPtr ProcessorProfileControlArea { get => ReadHere<IntPtr>(nameof(ProcessorProfileControlArea)); set => WriteHere(nameof(ProcessorProfileControlArea), value); }

        [Offset(36512UL)]
        public IntPtr ProfileEventIndexAddress { get => ReadHere<IntPtr>(nameof(ProfileEventIndexAddress)); set => WriteHere(nameof(ProfileEventIndexAddress), value); }

        [Offset(36520UL)]
        public IntPtr DpcWatchdogProfile { get => ReadHere<IntPtr>(nameof(DpcWatchdogProfile)); set => WriteHere(nameof(DpcWatchdogProfile), value); }

        [Offset(36528UL)]
        public IntPtr DpcWatchdogProfileCurrentEmptyCapture { get => ReadHere<IntPtr>(nameof(DpcWatchdogProfileCurrentEmptyCapture)); set => WriteHere(nameof(DpcWatchdogProfileCurrentEmptyCapture), value); }

        [Offset(36536UL)]
        public IntPtr SchedulerAssist { get => ReadHere<IntPtr>(nameof(SchedulerAssist)); set => WriteHere(nameof(SchedulerAssist), value); }

        [Offset(36544UL)]
        public SynchCounters SynchCounters { get => ReadStructure<SynchCounters>(nameof(SynchCounters)); set => WriteStructure(nameof(SynchCounters), value); }

        [Offset(36728UL)]
        public ulong PrcbPad94 { get => ReadHere<ulong>(nameof(PrcbPad94)); set => WriteHere(nameof(PrcbPad94), value); }

        [Offset(36736UL)]
        public FilesystemDiskCounters FsCounters { get => ReadStructure<FilesystemDiskCounters>(nameof(FsCounters)); set => WriteStructure(nameof(FsCounters), value); }

        [Offset(36752UL)]
        [Length(13)]
        public DynamicArray VendorString { get => ReadStructure<DynamicArray>(nameof(VendorString)); set => WriteStructure(nameof(VendorString), value); }

        [Offset(36765UL)]
        [Length(3)]
        public DynamicArray PrcbPad100 { get => ReadStructure<DynamicArray>(nameof(PrcbPad100)); set => WriteStructure(nameof(PrcbPad100), value); }

        [Offset(36768UL)]
        public ulong FeatureBits { get => ReadHere<ulong>(nameof(FeatureBits)); set => WriteHere(nameof(FeatureBits), value); }

        [Offset(36776UL)]
        public LargeInteger UpdateSignature { get => ReadStructure<LargeInteger>(nameof(UpdateSignature)); set => WriteStructure(nameof(UpdateSignature), value); }

        [Offset(36784UL)]
        public ulong PteBitCache { get => ReadHere<ulong>(nameof(PteBitCache)); set => WriteHere(nameof(PteBitCache), value); }

        [Offset(36792UL)]
        public uint PteBitOffset { get => ReadHere<uint>(nameof(PteBitOffset)); set => WriteHere(nameof(PteBitOffset), value); }

        [Offset(36796UL)]
        public uint PrcbPad105 { get => ReadHere<uint>(nameof(PrcbPad105)); set => WriteHere(nameof(PrcbPad105), value); }

        [Offset(36800UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(36808UL)]
        public uint ContextFlagsInit { get => ReadHere<uint>(nameof(ContextFlagsInit)); set => WriteHere(nameof(ContextFlagsInit), value); }

        [Offset(36812UL)]
        public uint PrcbPad115 { get => ReadHere<uint>(nameof(PrcbPad115)); set => WriteHere(nameof(PrcbPad115), value); }

        [Offset(36816UL)]
        public IntPtr ExtendedState { get => ReadHere<IntPtr>(nameof(ExtendedState)); set => WriteHere(nameof(ExtendedState), value); }

        [Offset(36824UL)]
        public IntPtr IsrStack { get => ReadHere<IntPtr>(nameof(IsrStack)); set => WriteHere(nameof(IsrStack), value); }

        [Offset(36832UL)]
        public KentropyTimingState EntropyTimingState { get => ReadStructure<KentropyTimingState>(nameof(EntropyTimingState)); set => WriteStructure(nameof(EntropyTimingState), value); }

        [Offset(37176UL)]
        public UnnamedTag StibpPairingTrace { get => ReadStructure<UnnamedTag>(nameof(StibpPairingTrace)); set => WriteStructure(nameof(StibpPairingTrace), value); }

        [Offset(37232UL)]
        public SingleListEntry AbSelfIoBoostsList { get => ReadStructure<SingleListEntry>(nameof(AbSelfIoBoostsList)); set => WriteStructure(nameof(AbSelfIoBoostsList), value); }

        [Offset(37240UL)]
        public SingleListEntry AbPropagateBoostsList { get => ReadStructure<SingleListEntry>(nameof(AbPropagateBoostsList)); set => WriteStructure(nameof(AbPropagateBoostsList), value); }

        [Offset(37248UL)]
        public Kdpc AbDpc { get => ReadStructure<Kdpc>(nameof(AbDpc)); set => WriteStructure(nameof(AbDpc), value); }

        [Offset(37312UL)]
        public SymcryptEntropyAccumulatorState SymCryptEntropyAccumulatorState { get => ReadStructure<SymcryptEntropyAccumulatorState>(nameof(SymCryptEntropyAccumulatorState)); set => WriteStructure(nameof(SymCryptEntropyAccumulatorState), value); }

        [Offset(37696UL)]
        public IopIrpStackProfiler IoIrpStackProfilerCurrent { get => ReadStructure<IopIrpStackProfiler>(nameof(IoIrpStackProfilerCurrent)); set => WriteStructure(nameof(IoIrpStackProfilerCurrent), value); }

        [Offset(37780UL)]
        public IopIrpStackProfiler IoIrpStackProfilerPrevious { get => ReadStructure<IopIrpStackProfiler>(nameof(IoIrpStackProfilerPrevious)); set => WriteStructure(nameof(IoIrpStackProfilerPrevious), value); }

        [Offset(37864UL)]
        public KsecureFaultInformation SecureFault { get => ReadStructure<KsecureFaultInformation>(nameof(SecureFault)); set => WriteStructure(nameof(SecureFault), value); }

        [Offset(37888UL)]
        public IntPtr LocalSharedReadyQueue { get => ReadHere<IntPtr>(nameof(LocalSharedReadyQueue)); set => WriteHere(nameof(LocalSharedReadyQueue), value); }

        [Offset(37896UL)]
        [Length(2)]
        public DynamicArray LocalSearchContexts { get => ReadStructure<DynamicArray>(nameof(LocalSearchContexts)); set => WriteStructure(nameof(LocalSearchContexts), value); }

        [Offset(37912UL)]
        [Length(2)]
        public DynamicArray SearchContexts { get => ReadStructure<DynamicArray>(nameof(SearchContexts)); set => WriteStructure(nameof(SearchContexts), value); }

        [Offset(37928UL)]
        [Length(2)]
        public DynamicArray SearchGenerations { get => ReadStructure<DynamicArray>(nameof(SearchGenerations)); set => WriteStructure(nameof(SearchGenerations), value); }

        [Offset(37944UL)]
        [Length(1)]
        public DynamicArray PrcbPad125 { get => ReadStructure<DynamicArray>(nameof(PrcbPad125)); set => WriteStructure(nameof(PrcbPad125), value); }

        [Offset(37952UL)]
        public uint TimerExpirationTraceCount { get => ReadHere<uint>(nameof(TimerExpirationTraceCount)); set => WriteHere(nameof(TimerExpirationTraceCount), value); }

        [Offset(37956UL)]
        public uint PrcbPad127 { get => ReadHere<uint>(nameof(PrcbPad127)); set => WriteHere(nameof(PrcbPad127), value); }

        [Offset(37960UL)]
        [Length(16)]
        public DynamicArray TimerExpirationTrace { get => ReadStructure<DynamicArray>(nameof(TimerExpirationTrace)); set => WriteStructure(nameof(TimerExpirationTrace), value); }

        [Offset(38216UL)]
        [Length(7)]
        public DynamicArray PrcbPad128 { get => ReadStructure<DynamicArray>(nameof(PrcbPad128)); set => WriteStructure(nameof(PrcbPad128), value); }

        [Offset(38272UL)]
        public KclockTimerState ClockTimerState { get => ReadStructure<KclockTimerState>(nameof(ClockTimerState)); set => WriteStructure(nameof(ClockTimerState), value); }

        [Offset(39576UL)]
        public IntPtr IpiFrame { get => ReadHere<IntPtr>(nameof(IpiFrame)); set => WriteHere(nameof(IpiFrame), value); }

        [Offset(39584UL)]
        [Length(32)]
        public DynamicArray PrcbPad129 { get => ReadStructure<DynamicArray>(nameof(PrcbPad129)); set => WriteStructure(nameof(PrcbPad129), value); }

        [Offset(39616UL)]
        public IntPtr Mailbox { get => ReadHere<IntPtr>(nameof(Mailbox)); set => WriteHere(nameof(Mailbox), value); }

        [Offset(39624UL)]
        [Length(7)]
        public DynamicArray PrcbPad130 { get => ReadStructure<DynamicArray>(nameof(PrcbPad130)); set => WriteStructure(nameof(PrcbPad130), value); }

        [Offset(39680UL)]
        [Length(2)]
        public DynamicArray McheckContext { get => ReadStructure<DynamicArray>(nameof(McheckContext)); set => WriteStructure(nameof(McheckContext), value); }

        [Offset(39840UL)]
        public ulong TransitionShadowStack { get => ReadHere<ulong>(nameof(TransitionShadowStack)); set => WriteHere(nameof(TransitionShadowStack), value); }

        [Offset(39848UL)]
        public ulong KernelShadowStackInitial { get => ReadHere<ulong>(nameof(KernelShadowStackInitial)); set => WriteHere(nameof(KernelShadowStackInitial), value); }

        [Offset(39856UL)]
        public IntPtr IstShadowStacksTable { get => ReadHere<IntPtr>(nameof(IstShadowStacksTable)); set => WriteHere(nameof(IstShadowStacksTable), value); }

        [Offset(39864UL)]
        [Length(5)]
        public DynamicArray HiberSwapShadowStacks { get => ReadStructure<DynamicArray>(nameof(HiberSwapShadowStacks)); set => WriteStructure(nameof(HiberSwapShadowStacks), value); }

        [Offset(39904UL)]
        [Length(5)]
        public DynamicArray HiberSwapShadowStackBases { get => ReadStructure<DynamicArray>(nameof(HiberSwapShadowStackBases)); set => WriteStructure(nameof(HiberSwapShadowStackBases), value); }

        [Offset(39944UL)]
        public IntPtr MmFaultCompletionInfo { get => ReadHere<IntPtr>(nameof(MmFaultCompletionInfo)); set => WriteHere(nameof(MmFaultCompletionInfo), value); }

        [Offset(39952UL)]
        [Length(6)]
        public DynamicArray PrcbPad132 { get => ReadStructure<DynamicArray>(nameof(PrcbPad132)); set => WriteStructure(nameof(PrcbPad132), value); }

        [Offset(40000UL)]
        [Length(4)]
        public DynamicArray SelfmapLockHandle { get => ReadStructure<DynamicArray>(nameof(SelfmapLockHandle)); set => WriteStructure(nameof(SelfmapLockHandle), value); }

        [Offset(40096UL)]
        [Length(4)]
        public DynamicArray PrcbPad134b { get => ReadStructure<DynamicArray>(nameof(PrcbPad134b)); set => WriteStructure(nameof(PrcbPad134b), value); }

        [Offset(40128UL)]
        public KaffinityEx DieProcessorSet { get => ReadStructure<KaffinityEx>(nameof(DieProcessorSet)); set => WriteStructure(nameof(DieProcessorSet), value); }

        [Offset(40392UL)]
        [Length(32)]
        public DynamicArray PrcbPad135 { get => ReadStructure<DynamicArray>(nameof(PrcbPad135)); set => WriteStructure(nameof(PrcbPad135), value); }

        [Offset(40648UL)]
        public uint CoresPerPhysicalDie { get => ReadHere<uint>(nameof(CoresPerPhysicalDie)); set => WriteHere(nameof(CoresPerPhysicalDie), value); }

        [Offset(40652UL)]
        public uint LogicalProcessorsPerModule { get => ReadHere<uint>(nameof(LogicalProcessorsPerModule)); set => WriteHere(nameof(LogicalProcessorsPerModule), value); }

        [Offset(40656UL)]
        [Length(64)]
        public DynamicArray PrcbPad137 { get => ReadStructure<DynamicArray>(nameof(PrcbPad137)); set => WriteStructure(nameof(PrcbPad137), value); }

        [Offset(40720UL)]
        public KaffinityEx ModuleProcessorSet { get => ReadStructure<KaffinityEx>(nameof(ModuleProcessorSet)); set => WriteStructure(nameof(ModuleProcessorSet), value); }

        [Offset(40984UL)]
        [Length(32)]
        public DynamicArray PrcbPad136 { get => ReadStructure<DynamicArray>(nameof(PrcbPad136)); set => WriteStructure(nameof(PrcbPad136), value); }

        [Offset(41240UL)]
        public KcoreControlBlock LocalCoreControlBlock { get => ReadStructure<KcoreControlBlock>(nameof(LocalCoreControlBlock)); set => WriteStructure(nameof(LocalCoreControlBlock), value); }

        [Offset(41288UL)]
        public ulong PrcbPad137a { get => ReadHere<ulong>(nameof(PrcbPad137a)); set => WriteHere(nameof(PrcbPad137a), value); }

        [Offset(41296UL)]
        public Kdpc KstackFreeDpc { get => ReadStructure<Kdpc>(nameof(KstackFreeDpc)); set => WriteStructure(nameof(KstackFreeDpc), value); }

        [Offset(41360UL)]
        public Kdpc SlistRollbackDpc { get => ReadStructure<Kdpc>(nameof(SlistRollbackDpc)); set => WriteStructure(nameof(SlistRollbackDpc), value); }

        [Offset(41424UL)]
        public SlistHeader KstackFreeList { get => ReadStructure<SlistHeader>(nameof(KstackFreeList)); set => WriteStructure(nameof(KstackFreeList), value); }

        [Offset(41440UL)]
        public uint IsrStackNesting { get => ReadHere<uint>(nameof(IsrStackNesting)); set => WriteHere(nameof(IsrStackNesting), value); }

        [Offset(41444UL)]
        [Length(3228)]
        public DynamicArray PrcbPad138 { get => ReadStructure<DynamicArray>(nameof(PrcbPad138)); set => WriteStructure(nameof(PrcbPad138), value); }

        [Offset(44672UL)]
        public ulong KernelDirectoryTableBase { get => ReadHere<ulong>(nameof(KernelDirectoryTableBase)); set => WriteHere(nameof(KernelDirectoryTableBase), value); }

        [Offset(44680UL)]
        public ulong RspBaseShadow { get => ReadHere<ulong>(nameof(RspBaseShadow)); set => WriteHere(nameof(RspBaseShadow), value); }

        [Offset(44688UL)]
        public ulong UserRspShadow { get => ReadHere<ulong>(nameof(UserRspShadow)); set => WriteHere(nameof(UserRspShadow), value); }

        [Offset(44696UL)]
        public uint ShadowFlags { get => ReadHere<uint>(nameof(ShadowFlags)); set => WriteHere(nameof(ShadowFlags), value); }

        [Offset(44700UL)]
        public uint PrcbPad138b { get => ReadHere<uint>(nameof(PrcbPad138b)); set => WriteHere(nameof(PrcbPad138b), value); }

        [Offset(44704UL)]
        public ulong PrcbPad138c { get => ReadHere<ulong>(nameof(PrcbPad138c)); set => WriteHere(nameof(PrcbPad138c), value); }

        [Offset(44712UL)]
        public ushort PrcbPad138d { get => ReadHere<ushort>(nameof(PrcbPad138d)); set => WriteHere(nameof(PrcbPad138d), value); }

        [Offset(44714UL)]
        public ushort VerwSelector { get => ReadHere<ushort>(nameof(VerwSelector)); set => WriteHere(nameof(VerwSelector), value); }

        [Offset(44716UL)]
        public uint DbgMceNestingLevel { get => ReadHere<uint>(nameof(DbgMceNestingLevel)); set => WriteHere(nameof(DbgMceNestingLevel), value); }

        [Offset(44720UL)]
        public uint DbgMceFlags { get => ReadHere<uint>(nameof(DbgMceFlags)); set => WriteHere(nameof(DbgMceFlags), value); }

        [Offset(44724UL)]
        public uint CoreControlBlockIndex { get => ReadHere<uint>(nameof(CoreControlBlockIndex)); set => WriteHere(nameof(CoreControlBlockIndex), value); }

        [Offset(44728UL)]
        public IntPtr CoreControlBlockShadow { get => ReadHere<IntPtr>(nameof(CoreControlBlockShadow)); set => WriteHere(nameof(CoreControlBlockShadow), value); }

        [Offset(44736UL)]
        public KcoreControlBlockShadow LocalCoreControlBlockShadow { get => ReadStructure<KcoreControlBlockShadow>(nameof(LocalCoreControlBlockShadow)); set => WriteStructure(nameof(LocalCoreControlBlockShadow), value); }

        [Offset(44800UL)]
        [Length(5)]
        public DynamicArray CacheProcessorSet { get => ReadStructure<DynamicArray>(nameof(CacheProcessorSet)); set => WriteStructure(nameof(CacheProcessorSet), value); }

        [Offset(46120UL)]
        [Length(160)]
        public DynamicArray PrcbPad139 { get => ReadStructure<DynamicArray>(nameof(PrcbPad139)); set => WriteStructure(nameof(PrcbPad139), value); }

        [Offset(47400UL)]
        [Length(171)]
        public DynamicArray PrcbPad140 { get => ReadStructure<DynamicArray>(nameof(PrcbPad140)); set => WriteStructure(nameof(PrcbPad140), value); }

        [Offset(48768UL)]
        [Length(8)]
        public DynamicArray PrcbPad140a { get => ReadStructure<DynamicArray>(nameof(PrcbPad140a)); set => WriteStructure(nameof(PrcbPad140a), value); }

        [Offset(48832UL)]
        [Length(512)]
        public DynamicArray PrcbPad141 { get => ReadStructure<DynamicArray>(nameof(PrcbPad141)); set => WriteStructure(nameof(PrcbPad141), value); }

        [Offset(52928UL)]
        [Length(1)]
        public DynamicArray RequestMailbox { get => ReadStructure<DynamicArray>(nameof(RequestMailbox)); set => WriteStructure(nameof(RequestMailbox), value); }

        public Kprcb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kprcb>();
        }
    }
}