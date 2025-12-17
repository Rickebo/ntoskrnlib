using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETHREAD")]
    public sealed class Ethread : DynamicStructure
    {
        [Offset(0UL)]
        public Kthread Tcb { get => ReadStructure<Kthread>(nameof(Tcb)); set => WriteStructure(nameof(Tcb), value); }

        [Offset(1216UL)]
        public LargeInteger CreateTime { get => ReadStructure<LargeInteger>(nameof(CreateTime)); set => WriteStructure(nameof(CreateTime), value); }

        [Offset(1224UL)]
        public LargeInteger ExitTime { get => ReadStructure<LargeInteger>(nameof(ExitTime)); set => WriteStructure(nameof(ExitTime), value); }

        [Offset(1224UL)]
        public ListEntry KeyedWaitChain { get => ReadStructure<ListEntry>(nameof(KeyedWaitChain)); set => WriteStructure(nameof(KeyedWaitChain), value); }

        [Offset(1240UL)]
        public ListEntry PostBlockList { get => ReadStructure<ListEntry>(nameof(PostBlockList)); set => WriteStructure(nameof(PostBlockList), value); }

        [Offset(1240UL)]
        public IntPtr ForwardLinkShadow { get => ReadHere<IntPtr>(nameof(ForwardLinkShadow)); set => WriteHere(nameof(ForwardLinkShadow), value); }

        [Offset(1248UL)]
        public IntPtr StartAddress { get => ReadHere<IntPtr>(nameof(StartAddress)); set => WriteHere(nameof(StartAddress), value); }

        [Offset(1256UL)]
        public IntPtr TerminationPort { get => ReadHere<IntPtr>(nameof(TerminationPort)); set => WriteHere(nameof(TerminationPort), value); }

        [Offset(1256UL)]
        public IntPtr ReaperLink { get => ReadHere<IntPtr>(nameof(ReaperLink)); set => WriteHere(nameof(ReaperLink), value); }

        [Offset(1256UL)]
        public IntPtr KeyedWaitValue { get => ReadHere<IntPtr>(nameof(KeyedWaitValue)); set => WriteHere(nameof(KeyedWaitValue), value); }

        [Offset(1264UL)]
        public ulong ActiveTimerListLock { get => ReadHere<ulong>(nameof(ActiveTimerListLock)); set => WriteHere(nameof(ActiveTimerListLock), value); }

        [Offset(1272UL)]
        public ListEntry ActiveTimerListHead { get => ReadStructure<ListEntry>(nameof(ActiveTimerListHead)); set => WriteStructure(nameof(ActiveTimerListHead), value); }

        [Offset(1288UL)]
        public ClientId Cid { get => ReadStructure<ClientId>(nameof(Cid)); set => WriteStructure(nameof(Cid), value); }

        [Offset(1304UL)]
        public Ksemaphore KeyedWaitSemaphore { get => ReadStructure<Ksemaphore>(nameof(KeyedWaitSemaphore)); set => WriteStructure(nameof(KeyedWaitSemaphore), value); }

        [Offset(1304UL)]
        public Ksemaphore AlpcWaitSemaphore { get => ReadStructure<Ksemaphore>(nameof(AlpcWaitSemaphore)); set => WriteStructure(nameof(AlpcWaitSemaphore), value); }

        [Offset(1336UL)]
        public PsClientSecurityContext ClientSecurity { get => ReadStructure<PsClientSecurityContext>(nameof(ClientSecurity)); set => WriteStructure(nameof(ClientSecurity), value); }

        [Offset(1344UL)]
        public ListEntry IrpList { get => ReadStructure<ListEntry>(nameof(IrpList)); set => WriteStructure(nameof(IrpList), value); }

        [Offset(1360UL)]
        public ulong TopLevelIrp { get => ReadHere<ulong>(nameof(TopLevelIrp)); set => WriteHere(nameof(TopLevelIrp), value); }

        [Offset(1368UL)]
        public IntPtr DeviceToVerify { get => ReadHere<IntPtr>(nameof(DeviceToVerify)); set => WriteHere(nameof(DeviceToVerify), value); }

        [Offset(1376UL)]
        public IntPtr Win32StartAddress { get => ReadHere<IntPtr>(nameof(Win32StartAddress)); set => WriteHere(nameof(Win32StartAddress), value); }

        [Offset(1384UL)]
        public IntPtr ChargeOnlySession { get => ReadHere<IntPtr>(nameof(ChargeOnlySession)); set => WriteHere(nameof(ChargeOnlySession), value); }

        [Offset(1392UL)]
        public IntPtr LegacyPowerObject { get => ReadHere<IntPtr>(nameof(LegacyPowerObject)); set => WriteHere(nameof(LegacyPowerObject), value); }

        [Offset(1400UL)]
        public ListEntry ThreadListEntry { get => ReadStructure<ListEntry>(nameof(ThreadListEntry)); set => WriteStructure(nameof(ThreadListEntry), value); }

        [Offset(1416UL)]
        public ExRundownRef RundownProtect { get => ReadStructure<ExRundownRef>(nameof(RundownProtect)); set => WriteStructure(nameof(RundownProtect), value); }

        [Offset(1424UL)]
        public ExPushLock ThreadLock { get => ReadStructure<ExPushLock>(nameof(ThreadLock)); set => WriteStructure(nameof(ThreadLock), value); }

        [Offset(1432UL)]
        public uint ReadClusterSize { get => ReadHere<uint>(nameof(ReadClusterSize)); set => WriteHere(nameof(ReadClusterSize), value); }

        [Offset(1436UL)]
        public uint MmLockOrdering { get => ReadHere<uint>(nameof(MmLockOrdering)); set => WriteHere(nameof(MmLockOrdering), value); }

        [Offset(1440UL)]
        public uint CrossThreadFlags { get => ReadHere<uint>(nameof(CrossThreadFlags)); set => WriteHere(nameof(CrossThreadFlags), value); }

        [Offset(1440UL)]
        public uint Terminated { get => ReadHere<uint>(nameof(Terminated)); set => WriteHere(nameof(Terminated), value); }

        [Offset(1440UL)]
        public uint ThreadInserted { get => ReadHere<uint>(nameof(ThreadInserted)); set => WriteHere(nameof(ThreadInserted), value); }

        [Offset(1440UL)]
        public uint HideFromDebugger { get => ReadHere<uint>(nameof(HideFromDebugger)); set => WriteHere(nameof(HideFromDebugger), value); }

        [Offset(1440UL)]
        public uint ActiveImpersonationInfo { get => ReadHere<uint>(nameof(ActiveImpersonationInfo)); set => WriteHere(nameof(ActiveImpersonationInfo), value); }

        [Offset(1440UL)]
        public uint HardErrorsAreDisabled { get => ReadHere<uint>(nameof(HardErrorsAreDisabled)); set => WriteHere(nameof(HardErrorsAreDisabled), value); }

        [Offset(1440UL)]
        public uint BreakOnTermination { get => ReadHere<uint>(nameof(BreakOnTermination)); set => WriteHere(nameof(BreakOnTermination), value); }

        [Offset(1440UL)]
        public uint SkipCreationMsg { get => ReadHere<uint>(nameof(SkipCreationMsg)); set => WriteHere(nameof(SkipCreationMsg), value); }

        [Offset(1440UL)]
        public uint SkipTerminationMsg { get => ReadHere<uint>(nameof(SkipTerminationMsg)); set => WriteHere(nameof(SkipTerminationMsg), value); }

        [Offset(1440UL)]
        public uint CopyTokenOnOpen { get => ReadHere<uint>(nameof(CopyTokenOnOpen)); set => WriteHere(nameof(CopyTokenOnOpen), value); }

        [Offset(1440UL)]
        public uint ThreadIoPriority { get => ReadHere<uint>(nameof(ThreadIoPriority)); set => WriteHere(nameof(ThreadIoPriority), value); }

        [Offset(1440UL)]
        public uint ThreadPagePriority { get => ReadHere<uint>(nameof(ThreadPagePriority)); set => WriteHere(nameof(ThreadPagePriority), value); }

        [Offset(1440UL)]
        public uint RundownFail { get => ReadHere<uint>(nameof(RundownFail)); set => WriteHere(nameof(RundownFail), value); }

        [Offset(1440UL)]
        public uint UmsForceQueueTermination { get => ReadHere<uint>(nameof(UmsForceQueueTermination)); set => WriteHere(nameof(UmsForceQueueTermination), value); }

        [Offset(1440UL)]
        public uint IndirectCpuSets { get => ReadHere<uint>(nameof(IndirectCpuSets)); set => WriteHere(nameof(IndirectCpuSets), value); }

        [Offset(1440UL)]
        public uint DisableDynamicCodeOptOut { get => ReadHere<uint>(nameof(DisableDynamicCodeOptOut)); set => WriteHere(nameof(DisableDynamicCodeOptOut), value); }

        [Offset(1440UL)]
        public uint ExplicitCaseSensitivity { get => ReadHere<uint>(nameof(ExplicitCaseSensitivity)); set => WriteHere(nameof(ExplicitCaseSensitivity), value); }

        [Offset(1440UL)]
        public uint PicoNotifyExit { get => ReadHere<uint>(nameof(PicoNotifyExit)); set => WriteHere(nameof(PicoNotifyExit), value); }

        [Offset(1440UL)]
        public uint DbgWerUserReportActive { get => ReadHere<uint>(nameof(DbgWerUserReportActive)); set => WriteHere(nameof(DbgWerUserReportActive), value); }

        [Offset(1440UL)]
        public uint ForcedSelfTrimActive { get => ReadHere<uint>(nameof(ForcedSelfTrimActive)); set => WriteHere(nameof(ForcedSelfTrimActive), value); }

        [Offset(1440UL)]
        public uint SamplingCoverage { get => ReadHere<uint>(nameof(SamplingCoverage)); set => WriteHere(nameof(SamplingCoverage), value); }

        [Offset(1440UL)]
        public uint ImpersonationSchedulingGroup { get => ReadHere<uint>(nameof(ImpersonationSchedulingGroup)); set => WriteHere(nameof(ImpersonationSchedulingGroup), value); }

        [Offset(1440UL)]
        public uint ReservedCrossThreadFlags { get => ReadHere<uint>(nameof(ReservedCrossThreadFlags)); set => WriteHere(nameof(ReservedCrossThreadFlags), value); }

        [Offset(1444UL)]
        public uint SameThreadPassiveFlags { get => ReadHere<uint>(nameof(SameThreadPassiveFlags)); set => WriteHere(nameof(SameThreadPassiveFlags), value); }

        [Offset(1444UL)]
        public uint ActiveExWorker { get => ReadHere<uint>(nameof(ActiveExWorker)); set => WriteHere(nameof(ActiveExWorker), value); }

        [Offset(1444UL)]
        public uint MemoryMaker { get => ReadHere<uint>(nameof(MemoryMaker)); set => WriteHere(nameof(MemoryMaker), value); }

        [Offset(1444UL)]
        public uint StoreLockThread { get => ReadHere<uint>(nameof(StoreLockThread)); set => WriteHere(nameof(StoreLockThread), value); }

        [Offset(1444UL)]
        public uint ClonedThread { get => ReadHere<uint>(nameof(ClonedThread)); set => WriteHere(nameof(ClonedThread), value); }

        [Offset(1444UL)]
        public uint KeyedEventInUse { get => ReadHere<uint>(nameof(KeyedEventInUse)); set => WriteHere(nameof(KeyedEventInUse), value); }

        [Offset(1444UL)]
        public uint SelfTerminate { get => ReadHere<uint>(nameof(SelfTerminate)); set => WriteHere(nameof(SelfTerminate), value); }

        [Offset(1444UL)]
        public uint RespectIoPriority { get => ReadHere<uint>(nameof(RespectIoPriority)); set => WriteHere(nameof(RespectIoPriority), value); }

        [Offset(1444UL)]
        public uint ActivePageLists { get => ReadHere<uint>(nameof(ActivePageLists)); set => WriteHere(nameof(ActivePageLists), value); }

        [Offset(1444UL)]
        public uint SecureContext { get => ReadHere<uint>(nameof(SecureContext)); set => WriteHere(nameof(SecureContext), value); }

        [Offset(1444UL)]
        public uint ZeroPageThread { get => ReadHere<uint>(nameof(ZeroPageThread)); set => WriteHere(nameof(ZeroPageThread), value); }

        [Offset(1444UL)]
        public uint WorkloadClass { get => ReadHere<uint>(nameof(WorkloadClass)); set => WriteHere(nameof(WorkloadClass), value); }

        [Offset(1444UL)]
        public uint GenerateDumpOnBadHandleAccess { get => ReadHere<uint>(nameof(GenerateDumpOnBadHandleAccess)); set => WriteHere(nameof(GenerateDumpOnBadHandleAccess), value); }

        [Offset(1444UL)]
        public uint BalanceSetManager { get => ReadHere<uint>(nameof(BalanceSetManager)); set => WriteHere(nameof(BalanceSetManager), value); }

        [Offset(1444UL)]
        public uint ReservedSameThreadPassiveFlags { get => ReadHere<uint>(nameof(ReservedSameThreadPassiveFlags)); set => WriteHere(nameof(ReservedSameThreadPassiveFlags), value); }

        [Offset(1448UL)]
        public uint SameThreadApcFlags { get => ReadHere<uint>(nameof(SameThreadApcFlags)); set => WriteHere(nameof(SameThreadApcFlags), value); }

        [Offset(1448UL)]
        public byte OwnsProcessAddressSpaceExclusive { get => ReadHere<byte>(nameof(OwnsProcessAddressSpaceExclusive)); set => WriteHere(nameof(OwnsProcessAddressSpaceExclusive), value); }

        [Offset(1448UL)]
        public byte OwnsProcessAddressSpaceShared { get => ReadHere<byte>(nameof(OwnsProcessAddressSpaceShared)); set => WriteHere(nameof(OwnsProcessAddressSpaceShared), value); }

        [Offset(1448UL)]
        public byte HardFaultBehavior { get => ReadHere<byte>(nameof(HardFaultBehavior)); set => WriteHere(nameof(HardFaultBehavior), value); }

        [Offset(1448UL)]
        public byte StartAddressInvalid { get => ReadHere<byte>(nameof(StartAddressInvalid)); set => WriteHere(nameof(StartAddressInvalid), value); }

        [Offset(1448UL)]
        public byte EtwCalloutActive { get => ReadHere<byte>(nameof(EtwCalloutActive)); set => WriteHere(nameof(EtwCalloutActive), value); }

        [Offset(1448UL)]
        public byte SuppressSymbolLoad { get => ReadHere<byte>(nameof(SuppressSymbolLoad)); set => WriteHere(nameof(SuppressSymbolLoad), value); }

        [Offset(1448UL)]
        public byte Prefetching { get => ReadHere<byte>(nameof(Prefetching)); set => WriteHere(nameof(Prefetching), value); }

        [Offset(1448UL)]
        public byte OwnsVadExclusive { get => ReadHere<byte>(nameof(OwnsVadExclusive)); set => WriteHere(nameof(OwnsVadExclusive), value); }

        [Offset(1449UL)]
        public byte SystemPagePriorityActive { get => ReadHere<byte>(nameof(SystemPagePriorityActive)); set => WriteHere(nameof(SystemPagePriorityActive), value); }

        [Offset(1449UL)]
        public byte SystemPagePriority { get => ReadHere<byte>(nameof(SystemPagePriority)); set => WriteHere(nameof(SystemPagePriority), value); }

        [Offset(1449UL)]
        public byte AllowUserWritesToExecutableMemory { get => ReadHere<byte>(nameof(AllowUserWritesToExecutableMemory)); set => WriteHere(nameof(AllowUserWritesToExecutableMemory), value); }

        [Offset(1449UL)]
        public byte AllowKernelWritesToExecutableMemory { get => ReadHere<byte>(nameof(AllowKernelWritesToExecutableMemory)); set => WriteHere(nameof(AllowKernelWritesToExecutableMemory), value); }

        [Offset(1449UL)]
        public byte OwnsVadShared { get => ReadHere<byte>(nameof(OwnsVadShared)); set => WriteHere(nameof(OwnsVadShared), value); }

        [Offset(1449UL)]
        public byte PasidMsrValid { get => ReadHere<byte>(nameof(PasidMsrValid)); set => WriteHere(nameof(PasidMsrValid), value); }

        [Offset(1450UL)]
        public byte SlabReplenishInProgress { get => ReadHere<byte>(nameof(SlabReplenishInProgress)); set => WriteHere(nameof(SlabReplenishInProgress), value); }

        [Offset(1452UL)]
        public byte CacheManagerActive { get => ReadHere<byte>(nameof(CacheManagerActive)); set => WriteHere(nameof(CacheManagerActive), value); }

        [Offset(1453UL)]
        public byte DisablePageFaultClustering { get => ReadHere<byte>(nameof(DisablePageFaultClustering)); set => WriteHere(nameof(DisablePageFaultClustering), value); }

        [Offset(1454UL)]
        public byte ActiveFaultCount { get => ReadHere<byte>(nameof(ActiveFaultCount)); set => WriteHere(nameof(ActiveFaultCount), value); }

        [Offset(1455UL)]
        public byte LockOrderState { get => ReadHere<byte>(nameof(LockOrderState)); set => WriteHere(nameof(LockOrderState), value); }

        [Offset(1456UL)]
        public uint SharedPsModuleLockAcquires { get => ReadHere<uint>(nameof(SharedPsModuleLockAcquires)); set => WriteHere(nameof(SharedPsModuleLockAcquires), value); }

        [Offset(1460UL)]
        public uint MmReserved { get => ReadHere<uint>(nameof(MmReserved)); set => WriteHere(nameof(MmReserved), value); }

        [Offset(1464UL)]
        public ulong AlpcMessageId { get => ReadHere<ulong>(nameof(AlpcMessageId)); set => WriteHere(nameof(AlpcMessageId), value); }

        [Offset(1472UL)]
        public IntPtr AlpcMessage { get => ReadHere<IntPtr>(nameof(AlpcMessage)); set => WriteHere(nameof(AlpcMessage), value); }

        [Offset(1472UL)]
        public uint AlpcReceiveAttributeSet { get => ReadHere<uint>(nameof(AlpcReceiveAttributeSet)); set => WriteHere(nameof(AlpcReceiveAttributeSet), value); }

        [Offset(1480UL)]
        public ListEntry AlpcWaitListEntry { get => ReadStructure<ListEntry>(nameof(AlpcWaitListEntry)); set => WriteStructure(nameof(AlpcWaitListEntry), value); }

        [Offset(1496UL)]
        public int ExitStatus { get => ReadHere<int>(nameof(ExitStatus)); set => WriteHere(nameof(ExitStatus), value); }

        [Offset(1500UL)]
        public uint CacheManagerCount { get => ReadHere<uint>(nameof(CacheManagerCount)); set => WriteHere(nameof(CacheManagerCount), value); }

        [Offset(1504UL)]
        public uint IoBoostCount { get => ReadHere<uint>(nameof(IoBoostCount)); set => WriteHere(nameof(IoBoostCount), value); }

        [Offset(1508UL)]
        public uint IoQoSBoostCount { get => ReadHere<uint>(nameof(IoQoSBoostCount)); set => WriteHere(nameof(IoQoSBoostCount), value); }

        [Offset(1512UL)]
        public uint IoQoSThrottleCount { get => ReadHere<uint>(nameof(IoQoSThrottleCount)); set => WriteHere(nameof(IoQoSThrottleCount), value); }

        [Offset(1516UL)]
        public uint KernelStackReference { get => ReadHere<uint>(nameof(KernelStackReference)); set => WriteHere(nameof(KernelStackReference), value); }

        [Offset(1520UL)]
        public ListEntry BoostList { get => ReadStructure<ListEntry>(nameof(BoostList)); set => WriteStructure(nameof(BoostList), value); }

        [Offset(1536UL)]
        public ListEntry DeboostList { get => ReadStructure<ListEntry>(nameof(DeboostList)); set => WriteStructure(nameof(DeboostList), value); }

        [Offset(1552UL)]
        public ulong BoostListLock { get => ReadHere<ulong>(nameof(BoostListLock)); set => WriteHere(nameof(BoostListLock), value); }

        [Offset(1560UL)]
        public ulong IrpListLock { get => ReadHere<ulong>(nameof(IrpListLock)); set => WriteHere(nameof(IrpListLock), value); }

        [Offset(1568UL)]
        public IntPtr ReservedForSynchTracking { get => ReadHere<IntPtr>(nameof(ReservedForSynchTracking)); set => WriteHere(nameof(ReservedForSynchTracking), value); }

        [Offset(1576UL)]
        public SingleListEntry CmCallbackListHead { get => ReadStructure<SingleListEntry>(nameof(CmCallbackListHead)); set => WriteStructure(nameof(CmCallbackListHead), value); }

        [Offset(1584UL)]
        public IntPtr ActivityId { get => ReadHere<IntPtr>(nameof(ActivityId)); set => WriteHere(nameof(ActivityId), value); }

        [Offset(1592UL)]
        public SingleListEntry SeLearningModeListHead { get => ReadStructure<SingleListEntry>(nameof(SeLearningModeListHead)); set => WriteStructure(nameof(SeLearningModeListHead), value); }

        [Offset(1600UL)]
        public IntPtr VerifierContext { get => ReadHere<IntPtr>(nameof(VerifierContext)); set => WriteHere(nameof(VerifierContext), value); }

        [Offset(1608UL)]
        public IntPtr AdjustedClientToken { get => ReadHere<IntPtr>(nameof(AdjustedClientToken)); set => WriteHere(nameof(AdjustedClientToken), value); }

        [Offset(1616UL)]
        public IntPtr WorkOnBehalfThread { get => ReadHere<IntPtr>(nameof(WorkOnBehalfThread)); set => WriteHere(nameof(WorkOnBehalfThread), value); }

        [Offset(1624UL)]
        public PsPropertySet PropertySet { get => ReadStructure<PsPropertySet>(nameof(PropertySet)); set => WriteStructure(nameof(PropertySet), value); }

        [Offset(1648UL)]
        public IntPtr PicoContext { get => ReadHere<IntPtr>(nameof(PicoContext)); set => WriteHere(nameof(PicoContext), value); }

        [Offset(1656UL)]
        public ulong UserFsBase { get => ReadHere<ulong>(nameof(UserFsBase)); set => WriteHere(nameof(UserFsBase), value); }

        [Offset(1664UL)]
        public ulong UserGsBase { get => ReadHere<ulong>(nameof(UserGsBase)); set => WriteHere(nameof(UserGsBase), value); }

        [Offset(1672UL)]
        public IntPtr EnergyValues { get => ReadHere<IntPtr>(nameof(EnergyValues)); set => WriteHere(nameof(EnergyValues), value); }

        [Offset(1680UL)]
        public ulong SelectedCpuSets { get => ReadHere<ulong>(nameof(SelectedCpuSets)); set => WriteHere(nameof(SelectedCpuSets), value); }

        [Offset(1680UL)]
        public IntPtr SelectedCpuSetsIndirect { get => ReadHere<IntPtr>(nameof(SelectedCpuSetsIndirect)); set => WriteHere(nameof(SelectedCpuSetsIndirect), value); }

        [Offset(1688UL)]
        public IntPtr Silo { get => ReadHere<IntPtr>(nameof(Silo)); set => WriteHere(nameof(Silo), value); }

        [Offset(1696UL)]
        public IntPtr ThreadName { get => ReadHere<IntPtr>(nameof(ThreadName)); set => WriteHere(nameof(ThreadName), value); }

        [Offset(1704UL)]
        public IntPtr SetContextState { get => ReadHere<IntPtr>(nameof(SetContextState)); set => WriteHere(nameof(SetContextState), value); }

        [Offset(1712UL)]
        public IntPtr EtwSupport { get => ReadHere<IntPtr>(nameof(EtwSupport)); set => WriteHere(nameof(EtwSupport), value); }

        [Offset(1720UL)]
        public ListEntry OwnerEntryListHead { get => ReadStructure<ListEntry>(nameof(OwnerEntryListHead)); set => WriteStructure(nameof(OwnerEntryListHead), value); }

        [Offset(1736UL)]
        public ulong DisownedOwnerEntryListLock { get => ReadHere<ulong>(nameof(DisownedOwnerEntryListLock)); set => WriteHere(nameof(DisownedOwnerEntryListLock), value); }

        [Offset(1744UL)]
        public ListEntry DisownedOwnerEntryListHead { get => ReadStructure<ListEntry>(nameof(DisownedOwnerEntryListHead)); set => WriteStructure(nameof(DisownedOwnerEntryListHead), value); }

        [Offset(1760UL)]
        public IntPtr SchedulerSharedDataObject { get => ReadHere<IntPtr>(nameof(SchedulerSharedDataObject)); set => WriteHere(nameof(SchedulerSharedDataObject), value); }

        [Offset(1768UL)]
        public IntPtr CmThreadInfo { get => ReadHere<IntPtr>(nameof(CmThreadInfo)); set => WriteHere(nameof(CmThreadInfo), value); }

        [Offset(1776UL)]
        public IntPtr FlsData { get => ReadHere<IntPtr>(nameof(FlsData)); set => WriteHere(nameof(FlsData), value); }

        [Offset(1784UL)]
        public uint LastExpectedRunTime { get => ReadHere<uint>(nameof(LastExpectedRunTime)); set => WriteHere(nameof(LastExpectedRunTime), value); }

        [Offset(1788UL)]
        public uint LastSoftParkElectionRunTime { get => ReadHere<uint>(nameof(LastSoftParkElectionRunTime)); set => WriteHere(nameof(LastSoftParkElectionRunTime), value); }

        [Offset(1792UL)]
        public ulong LastSoftParkElectionGeneration { get => ReadHere<ulong>(nameof(LastSoftParkElectionGeneration)); set => WriteHere(nameof(LastSoftParkElectionGeneration), value); }

        [Offset(1800UL)]
        public GroupAffinity LastSoftParkElectionGroupAffinity { get => ReadStructure<GroupAffinity>(nameof(LastSoftParkElectionGroupAffinity)); set => WriteStructure(nameof(LastSoftParkElectionGroupAffinity), value); }

        [Offset(1816UL)]
        public ulong UserIsolationDomain { get => ReadHere<ulong>(nameof(UserIsolationDomain)); set => WriteHere(nameof(UserIsolationDomain), value); }

        [Offset(1824UL)]
        public Kapc UpdateTebApc { get => ReadStructure<Kapc>(nameof(UpdateTebApc)); set => WriteStructure(nameof(UpdateTebApc), value); }

        [Offset(1824UL)]
        [Length(3)]
        public DynamicArray UpdateTebApcFill1 { get => ReadStructure<DynamicArray>(nameof(UpdateTebApcFill1)); set => WriteStructure(nameof(UpdateTebApcFill1), value); }

        [Offset(1827UL)]
        public sbyte Win32kPriorityFloor { get => ReadHere<sbyte>(nameof(Win32kPriorityFloor)); set => WriteHere(nameof(Win32kPriorityFloor), value); }

        [Offset(1824UL)]
        [Length(4)]
        public DynamicArray UpdateTebApcFill2 { get => ReadStructure<DynamicArray>(nameof(UpdateTebApcFill2)); set => WriteStructure(nameof(UpdateTebApcFill2), value); }

        [Offset(1828UL)]
        public byte LastSoftParkElectionQos { get => ReadHere<byte>(nameof(LastSoftParkElectionQos)); set => WriteHere(nameof(LastSoftParkElectionQos), value); }

        [Offset(1829UL)]
        public byte LastSoftParkElectionWorkloadType { get => ReadHere<byte>(nameof(LastSoftParkElectionWorkloadType)); set => WriteHere(nameof(LastSoftParkElectionWorkloadType), value); }

        [Offset(1830UL)]
        public byte LastSoftParkElectionRunningType { get => ReadHere<byte>(nameof(LastSoftParkElectionRunningType)); set => WriteHere(nameof(LastSoftParkElectionRunningType), value); }

        [Offset(1831UL)]
        public byte MmSlabIdentity { get => ReadHere<byte>(nameof(MmSlabIdentity)); set => WriteHere(nameof(MmSlabIdentity), value); }

        [Offset(1824UL)]
        [Length(64)]
        public DynamicArray UpdateTebApcFill3 { get => ReadStructure<DynamicArray>(nameof(UpdateTebApcFill3)); set => WriteStructure(nameof(UpdateTebApcFill3), value); }

        [Offset(1888UL)]
        public RtlThreadRngState RngState { get => ReadStructure<RtlThreadRngState>(nameof(RngState)); set => WriteStructure(nameof(RngState), value); }

        [Offset(1824UL)]
        [Length(72)]
        public DynamicArray UpdateTebApcFill4 { get => ReadStructure<DynamicArray>(nameof(UpdateTebApcFill4)); set => WriteStructure(nameof(UpdateTebApcFill4), value); }

        [Offset(1896UL)]
        public IntPtr UsedByRngState { get => ReadHere<IntPtr>(nameof(UsedByRngState)); set => WriteHere(nameof(UsedByRngState), value); }

        [Offset(1824UL)]
        [Length(83)]
        public DynamicArray UpdateTebApcFill5 { get => ReadStructure<DynamicArray>(nameof(UpdateTebApcFill5)); set => WriteStructure(nameof(UpdateTebApcFill5), value); }

        [Offset(1907UL)]
        public byte UpdateTebSpareByte2 { get => ReadHere<byte>(nameof(UpdateTebSpareByte2)); set => WriteHere(nameof(UpdateTebSpareByte2), value); }

        [Offset(1908UL)]
        public uint HeapData { get => ReadHere<uint>(nameof(HeapData)); set => WriteHere(nameof(HeapData), value); }

        [Offset(1912UL)]
        public ulong Win32kThreadLock { get => ReadHere<ulong>(nameof(Win32kThreadLock)); set => WriteHere(nameof(Win32kThreadLock), value); }

        [Offset(1920UL)]
        public IntPtr ThreadIndex { get => ReadHere<IntPtr>(nameof(ThreadIndex)); set => WriteHere(nameof(ThreadIndex), value); }

        [Offset(1928UL)]
        public IntPtr MmFaultClusterContext { get => ReadHere<IntPtr>(nameof(MmFaultClusterContext)); set => WriteHere(nameof(MmFaultClusterContext), value); }

        [Offset(1936UL)]
        public ExFastRef ProcessFastRef { get => ReadStructure<ExFastRef>(nameof(ProcessFastRef)); set => WriteStructure(nameof(ProcessFastRef), value); }

        public Ethread(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Ethread>();
        }
    }
}