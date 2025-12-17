using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETHREAD")]
    public sealed class _ETHREAD : DynamicStructure
    {
        public _KTHREAD Tcb { get; }
        public _LARGE_INTEGER CreateTime { get; }
        public _LARGE_INTEGER ExitTime { get; }
        public _LIST_ENTRY KeyedWaitChain { get; }
        public _LIST_ENTRY PostBlockList { get; }
        public IntPtr ForwardLinkShadow { get; }
        public IntPtr StartAddress { get; }
        public IntPtr TerminationPort { get; }
        public IntPtr ReaperLink { get; }
        public IntPtr KeyedWaitValue { get; }
        public ulong ActiveTimerListLock { get; }
        public _LIST_ENTRY ActiveTimerListHead { get; }
        public _CLIENT_ID Cid { get; }
        public _KSEMAPHORE KeyedWaitSemaphore { get; }
        public _KSEMAPHORE AlpcWaitSemaphore { get; }
        public _PS_CLIENT_SECURITY_CONTEXT ClientSecurity { get; }
        public _LIST_ENTRY IrpList { get; }
        public ulong TopLevelIrp { get; }
        public IntPtr DeviceToVerify { get; }
        public IntPtr Win32StartAddress { get; }
        public IntPtr ChargeOnlySession { get; }
        public IntPtr LegacyPowerObject { get; }
        public _LIST_ENTRY ThreadListEntry { get; }
        public _EX_RUNDOWN_REF RundownProtect { get; }
        public _EX_PUSH_LOCK ThreadLock { get; }
        public uint ReadClusterSize { get; }
        public uint MmLockOrdering { get; }
        public uint CrossThreadFlags { get; }
        public uint Terminated { get; }
        public uint ThreadInserted { get; }
        public uint HideFromDebugger { get; }
        public uint ActiveImpersonationInfo { get; }
        public uint HardErrorsAreDisabled { get; }
        public uint BreakOnTermination { get; }
        public uint SkipCreationMsg { get; }
        public uint SkipTerminationMsg { get; }
        public uint CopyTokenOnOpen { get; }
        public uint ThreadIoPriority { get; }
        public uint ThreadPagePriority { get; }
        public uint RundownFail { get; }
        public uint UmsForceQueueTermination { get; }
        public uint IndirectCpuSets { get; }
        public uint DisableDynamicCodeOptOut { get; }
        public uint ExplicitCaseSensitivity { get; }
        public uint PicoNotifyExit { get; }
        public uint DbgWerUserReportActive { get; }
        public uint ForcedSelfTrimActive { get; }
        public uint SamplingCoverage { get; }
        public uint ImpersonationSchedulingGroup { get; }
        public uint ReservedCrossThreadFlags { get; }
        public uint SameThreadPassiveFlags { get; }
        public uint ActiveExWorker { get; }
        public uint MemoryMaker { get; }
        public uint StoreLockThread { get; }
        public uint ClonedThread { get; }
        public uint KeyedEventInUse { get; }
        public uint SelfTerminate { get; }
        public uint RespectIoPriority { get; }
        public uint ActivePageLists { get; }
        public uint SecureContext { get; }
        public uint ZeroPageThread { get; }
        public uint WorkloadClass { get; }
        public uint GenerateDumpOnBadHandleAccess { get; }
        public uint BalanceSetManager { get; }
        public uint ReservedSameThreadPassiveFlags { get; }
        public uint SameThreadApcFlags { get; }
        public byte OwnsProcessAddressSpaceExclusive { get; }
        public byte OwnsProcessAddressSpaceShared { get; }
        public byte HardFaultBehavior { get; }
        public byte StartAddressInvalid { get; }
        public byte EtwCalloutActive { get; }
        public byte SuppressSymbolLoad { get; }
        public byte Prefetching { get; }
        public byte OwnsVadExclusive { get; }
        public byte SystemPagePriorityActive { get; }
        public byte SystemPagePriority { get; }
        public byte AllowUserWritesToExecutableMemory { get; }
        public byte AllowKernelWritesToExecutableMemory { get; }
        public byte OwnsVadShared { get; }
        public byte PasidMsrValid { get; }
        public byte SlabReplenishInProgress { get; }
        public byte CacheManagerActive { get; }
        public byte DisablePageFaultClustering { get; }
        public byte ActiveFaultCount { get; }
        public byte LockOrderState { get; }
        public uint SharedPsModuleLockAcquires { get; }
        public uint MmReserved { get; }
        public ulong AlpcMessageId { get; }
        public IntPtr AlpcMessage { get; }
        public uint AlpcReceiveAttributeSet { get; }
        public _LIST_ENTRY AlpcWaitListEntry { get; }
        public int ExitStatus { get; }
        public uint CacheManagerCount { get; }
        public uint IoBoostCount { get; }
        public uint IoQoSBoostCount { get; }
        public uint IoQoSThrottleCount { get; }
        public uint KernelStackReference { get; }
        public _LIST_ENTRY BoostList { get; }
        public _LIST_ENTRY DeboostList { get; }
        public ulong BoostListLock { get; }
        public ulong IrpListLock { get; }
        public IntPtr ReservedForSynchTracking { get; }
        public _SINGLE_LIST_ENTRY CmCallbackListHead { get; }
        public IntPtr ActivityId { get; }
        public _SINGLE_LIST_ENTRY SeLearningModeListHead { get; }
        public IntPtr VerifierContext { get; }
        public IntPtr AdjustedClientToken { get; }
        public IntPtr WorkOnBehalfThread { get; }
        public _PS_PROPERTY_SET PropertySet { get; }
        public IntPtr PicoContext { get; }
        public ulong UserFsBase { get; }
        public ulong UserGsBase { get; }
        public IntPtr EnergyValues { get; }
        public ulong SelectedCpuSets { get; }
        public IntPtr SelectedCpuSetsIndirect { get; }
        public IntPtr Silo { get; }
        public IntPtr ThreadName { get; }
        public IntPtr SetContextState { get; }
        public IntPtr EtwSupport { get; }
        public _LIST_ENTRY OwnerEntryListHead { get; }
        public ulong DisownedOwnerEntryListLock { get; }
        public _LIST_ENTRY DisownedOwnerEntryListHead { get; }
        public IntPtr SchedulerSharedDataObject { get; }
        public IntPtr CmThreadInfo { get; }
        public IntPtr FlsData { get; }
        public uint LastExpectedRunTime { get; }
        public uint LastSoftParkElectionRunTime { get; }
        public ulong LastSoftParkElectionGeneration { get; }
        public _GROUP_AFFINITY LastSoftParkElectionGroupAffinity { get; }
        public ulong UserIsolationDomain { get; }
        public _KAPC UpdateTebApc { get; }
        public byte[] UpdateTebApcFill1 { get; }
        public sbyte Win32kPriorityFloor { get; }
        public byte[] UpdateTebApcFill2 { get; }
        public byte LastSoftParkElectionQos { get; }
        public byte LastSoftParkElectionWorkloadType { get; }
        public byte LastSoftParkElectionRunningType { get; }
        public byte MmSlabIdentity { get; }
        public byte[] UpdateTebApcFill3 { get; }
        public _RTL_THREAD_RNG_STATE RngState { get; }
        public byte[] UpdateTebApcFill4 { get; }
        public IntPtr UsedByRngState { get; }
        public byte[] UpdateTebApcFill5 { get; }
        public byte UpdateTebSpareByte2 { get; }
        public uint HeapData { get; }
        public ulong Win32kThreadLock { get; }
        public IntPtr ThreadIndex { get; }
        public IntPtr MmFaultClusterContext { get; }
        public _EX_FAST_REF ProcessFastRef { get; }

        public _ETHREAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETHREAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETHREAD.Tcb),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETHREAD.CreateTime),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_ETHREAD.ExitTime),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_ETHREAD.KeyedWaitChain),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_ETHREAD.PostBlockList),
                    new ulong[]
                    {
                        1240UL
                    }
                },
                {
                    nameof(_ETHREAD.ForwardLinkShadow),
                    new ulong[]
                    {
                        1240UL
                    }
                },
                {
                    nameof(_ETHREAD.StartAddress),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_ETHREAD.TerminationPort),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_ETHREAD.ReaperLink),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_ETHREAD.KeyedWaitValue),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_ETHREAD.ActiveTimerListLock),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(_ETHREAD.ActiveTimerListHead),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(_ETHREAD.Cid),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_ETHREAD.KeyedWaitSemaphore),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_ETHREAD.AlpcWaitSemaphore),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_ETHREAD.ClientSecurity),
                    new ulong[]
                    {
                        1336UL
                    }
                },
                {
                    nameof(_ETHREAD.IrpList),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_ETHREAD.TopLevelIrp),
                    new ulong[]
                    {
                        1360UL
                    }
                },
                {
                    nameof(_ETHREAD.DeviceToVerify),
                    new ulong[]
                    {
                        1368UL
                    }
                },
                {
                    nameof(_ETHREAD.Win32StartAddress),
                    new ulong[]
                    {
                        1376UL
                    }
                },
                {
                    nameof(_ETHREAD.ChargeOnlySession),
                    new ulong[]
                    {
                        1384UL
                    }
                },
                {
                    nameof(_ETHREAD.LegacyPowerObject),
                    new ulong[]
                    {
                        1392UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadListEntry),
                    new ulong[]
                    {
                        1400UL
                    }
                },
                {
                    nameof(_ETHREAD.RundownProtect),
                    new ulong[]
                    {
                        1416UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadLock),
                    new ulong[]
                    {
                        1424UL
                    }
                },
                {
                    nameof(_ETHREAD.ReadClusterSize),
                    new ulong[]
                    {
                        1432UL
                    }
                },
                {
                    nameof(_ETHREAD.MmLockOrdering),
                    new ulong[]
                    {
                        1436UL
                    }
                },
                {
                    nameof(_ETHREAD.CrossThreadFlags),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.Terminated),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadInserted),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.HideFromDebugger),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ActiveImpersonationInfo),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.HardErrorsAreDisabled),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.BreakOnTermination),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.SkipCreationMsg),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.SkipTerminationMsg),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.CopyTokenOnOpen),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadIoPriority),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadPagePriority),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.RundownFail),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.UmsForceQueueTermination),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.IndirectCpuSets),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.DisableDynamicCodeOptOut),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ExplicitCaseSensitivity),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.PicoNotifyExit),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.DbgWerUserReportActive),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ForcedSelfTrimActive),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.SamplingCoverage),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ImpersonationSchedulingGroup),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.ReservedCrossThreadFlags),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_ETHREAD.SameThreadPassiveFlags),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.ActiveExWorker),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.MemoryMaker),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.StoreLockThread),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.ClonedThread),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.KeyedEventInUse),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.SelfTerminate),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.RespectIoPriority),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.ActivePageLists),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.SecureContext),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.ZeroPageThread),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.WorkloadClass),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.GenerateDumpOnBadHandleAccess),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.BalanceSetManager),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.ReservedSameThreadPassiveFlags),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_ETHREAD.SameThreadApcFlags),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.OwnsProcessAddressSpaceExclusive),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.OwnsProcessAddressSpaceShared),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.HardFaultBehavior),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.StartAddressInvalid),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.EtwCalloutActive),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.SuppressSymbolLoad),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.Prefetching),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.OwnsVadExclusive),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_ETHREAD.SystemPagePriorityActive),
                    new ulong[]
                    {
                        1449UL
                    }
                },
                {
                    nameof(_ETHREAD.SystemPagePriority),
                    new ulong[]
                    {
                        1449UL
                    }
                },
                {
                    nameof(_ETHREAD.AllowUserWritesToExecutableMemory),
                    new ulong[]
                    {
                        1449UL
                    }
                },
                {
                    nameof(_ETHREAD.AllowKernelWritesToExecutableMemory),
                    new ulong[]
                    {
                        1449UL
                    }
                },
                {
                    nameof(_ETHREAD.OwnsVadShared),
                    new ulong[]
                    {
                        1449UL
                    }
                },
                {
                    nameof(_ETHREAD.PasidMsrValid),
                    new ulong[]
                    {
                        1449UL
                    }
                },
                {
                    nameof(_ETHREAD.SlabReplenishInProgress),
                    new ulong[]
                    {
                        1450UL
                    }
                },
                {
                    nameof(_ETHREAD.CacheManagerActive),
                    new ulong[]
                    {
                        1452UL
                    }
                },
                {
                    nameof(_ETHREAD.DisablePageFaultClustering),
                    new ulong[]
                    {
                        1453UL
                    }
                },
                {
                    nameof(_ETHREAD.ActiveFaultCount),
                    new ulong[]
                    {
                        1454UL
                    }
                },
                {
                    nameof(_ETHREAD.LockOrderState),
                    new ulong[]
                    {
                        1455UL
                    }
                },
                {
                    nameof(_ETHREAD.SharedPsModuleLockAcquires),
                    new ulong[]
                    {
                        1456UL
                    }
                },
                {
                    nameof(_ETHREAD.MmReserved),
                    new ulong[]
                    {
                        1460UL
                    }
                },
                {
                    nameof(_ETHREAD.AlpcMessageId),
                    new ulong[]
                    {
                        1464UL
                    }
                },
                {
                    nameof(_ETHREAD.AlpcMessage),
                    new ulong[]
                    {
                        1472UL
                    }
                },
                {
                    nameof(_ETHREAD.AlpcReceiveAttributeSet),
                    new ulong[]
                    {
                        1472UL
                    }
                },
                {
                    nameof(_ETHREAD.AlpcWaitListEntry),
                    new ulong[]
                    {
                        1480UL
                    }
                },
                {
                    nameof(_ETHREAD.ExitStatus),
                    new ulong[]
                    {
                        1496UL
                    }
                },
                {
                    nameof(_ETHREAD.CacheManagerCount),
                    new ulong[]
                    {
                        1500UL
                    }
                },
                {
                    nameof(_ETHREAD.IoBoostCount),
                    new ulong[]
                    {
                        1504UL
                    }
                },
                {
                    nameof(_ETHREAD.IoQoSBoostCount),
                    new ulong[]
                    {
                        1508UL
                    }
                },
                {
                    nameof(_ETHREAD.IoQoSThrottleCount),
                    new ulong[]
                    {
                        1512UL
                    }
                },
                {
                    nameof(_ETHREAD.KernelStackReference),
                    new ulong[]
                    {
                        1516UL
                    }
                },
                {
                    nameof(_ETHREAD.BoostList),
                    new ulong[]
                    {
                        1520UL
                    }
                },
                {
                    nameof(_ETHREAD.DeboostList),
                    new ulong[]
                    {
                        1536UL
                    }
                },
                {
                    nameof(_ETHREAD.BoostListLock),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_ETHREAD.IrpListLock),
                    new ulong[]
                    {
                        1560UL
                    }
                },
                {
                    nameof(_ETHREAD.ReservedForSynchTracking),
                    new ulong[]
                    {
                        1568UL
                    }
                },
                {
                    nameof(_ETHREAD.CmCallbackListHead),
                    new ulong[]
                    {
                        1576UL
                    }
                },
                {
                    nameof(_ETHREAD.ActivityId),
                    new ulong[]
                    {
                        1584UL
                    }
                },
                {
                    nameof(_ETHREAD.SeLearningModeListHead),
                    new ulong[]
                    {
                        1592UL
                    }
                },
                {
                    nameof(_ETHREAD.VerifierContext),
                    new ulong[]
                    {
                        1600UL
                    }
                },
                {
                    nameof(_ETHREAD.AdjustedClientToken),
                    new ulong[]
                    {
                        1608UL
                    }
                },
                {
                    nameof(_ETHREAD.WorkOnBehalfThread),
                    new ulong[]
                    {
                        1616UL
                    }
                },
                {
                    nameof(_ETHREAD.PropertySet),
                    new ulong[]
                    {
                        1624UL
                    }
                },
                {
                    nameof(_ETHREAD.PicoContext),
                    new ulong[]
                    {
                        1648UL
                    }
                },
                {
                    nameof(_ETHREAD.UserFsBase),
                    new ulong[]
                    {
                        1656UL
                    }
                },
                {
                    nameof(_ETHREAD.UserGsBase),
                    new ulong[]
                    {
                        1664UL
                    }
                },
                {
                    nameof(_ETHREAD.EnergyValues),
                    new ulong[]
                    {
                        1672UL
                    }
                },
                {
                    nameof(_ETHREAD.SelectedCpuSets),
                    new ulong[]
                    {
                        1680UL
                    }
                },
                {
                    nameof(_ETHREAD.SelectedCpuSetsIndirect),
                    new ulong[]
                    {
                        1680UL
                    }
                },
                {
                    nameof(_ETHREAD.Silo),
                    new ulong[]
                    {
                        1688UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadName),
                    new ulong[]
                    {
                        1696UL
                    }
                },
                {
                    nameof(_ETHREAD.SetContextState),
                    new ulong[]
                    {
                        1704UL
                    }
                },
                {
                    nameof(_ETHREAD.EtwSupport),
                    new ulong[]
                    {
                        1712UL
                    }
                },
                {
                    nameof(_ETHREAD.OwnerEntryListHead),
                    new ulong[]
                    {
                        1720UL
                    }
                },
                {
                    nameof(_ETHREAD.DisownedOwnerEntryListLock),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_ETHREAD.DisownedOwnerEntryListHead),
                    new ulong[]
                    {
                        1744UL
                    }
                },
                {
                    nameof(_ETHREAD.SchedulerSharedDataObject),
                    new ulong[]
                    {
                        1760UL
                    }
                },
                {
                    nameof(_ETHREAD.CmThreadInfo),
                    new ulong[]
                    {
                        1768UL
                    }
                },
                {
                    nameof(_ETHREAD.FlsData),
                    new ulong[]
                    {
                        1776UL
                    }
                },
                {
                    nameof(_ETHREAD.LastExpectedRunTime),
                    new ulong[]
                    {
                        1784UL
                    }
                },
                {
                    nameof(_ETHREAD.LastSoftParkElectionRunTime),
                    new ulong[]
                    {
                        1788UL
                    }
                },
                {
                    nameof(_ETHREAD.LastSoftParkElectionGeneration),
                    new ulong[]
                    {
                        1792UL
                    }
                },
                {
                    nameof(_ETHREAD.LastSoftParkElectionGroupAffinity),
                    new ulong[]
                    {
                        1800UL
                    }
                },
                {
                    nameof(_ETHREAD.UserIsolationDomain),
                    new ulong[]
                    {
                        1816UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebApc),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebApcFill1),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_ETHREAD.Win32kPriorityFloor),
                    new ulong[]
                    {
                        1827UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebApcFill2),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_ETHREAD.LastSoftParkElectionQos),
                    new ulong[]
                    {
                        1828UL
                    }
                },
                {
                    nameof(_ETHREAD.LastSoftParkElectionWorkloadType),
                    new ulong[]
                    {
                        1829UL
                    }
                },
                {
                    nameof(_ETHREAD.LastSoftParkElectionRunningType),
                    new ulong[]
                    {
                        1830UL
                    }
                },
                {
                    nameof(_ETHREAD.MmSlabIdentity),
                    new ulong[]
                    {
                        1831UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebApcFill3),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_ETHREAD.RngState),
                    new ulong[]
                    {
                        1888UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebApcFill4),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_ETHREAD.UsedByRngState),
                    new ulong[]
                    {
                        1896UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebApcFill5),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_ETHREAD.UpdateTebSpareByte2),
                    new ulong[]
                    {
                        1907UL
                    }
                },
                {
                    nameof(_ETHREAD.HeapData),
                    new ulong[]
                    {
                        1908UL
                    }
                },
                {
                    nameof(_ETHREAD.Win32kThreadLock),
                    new ulong[]
                    {
                        1912UL
                    }
                },
                {
                    nameof(_ETHREAD.ThreadIndex),
                    new ulong[]
                    {
                        1920UL
                    }
                },
                {
                    nameof(_ETHREAD.MmFaultClusterContext),
                    new ulong[]
                    {
                        1928UL
                    }
                },
                {
                    nameof(_ETHREAD.ProcessFastRef),
                    new ulong[]
                    {
                        1936UL
                    }
                }
            };
            Register<_ETHREAD>((mem, ptr) => new _ETHREAD(mem, ptr), offsets);
        }
    }
}