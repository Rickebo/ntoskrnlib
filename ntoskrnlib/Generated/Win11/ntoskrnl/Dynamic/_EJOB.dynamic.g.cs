using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EJOB")]
    public sealed class _EJOB : DynamicStructure
    {
        public _KEVENT Event { get; }
        public _LIST_ENTRY JobLinks { get; }
        public _LIST_ENTRY ProcessListHead { get; }
        public _ERESOURCE JobLock { get; }
        public _LARGE_INTEGER TotalUserTime { get; }
        public _LARGE_INTEGER TotalKernelTime { get; }
        public _LARGE_INTEGER TotalCycleTime { get; }
        public _LARGE_INTEGER ThisPeriodTotalUserTime { get; }
        public _LARGE_INTEGER ThisPeriodTotalKernelTime { get; }
        public ulong TotalContextSwitches { get; }
        public uint TotalPageFaultCount { get; }
        public uint TotalProcesses { get; }
        public uint ActiveProcesses { get; }
        public uint TotalTerminatedProcesses { get; }
        public _LARGE_INTEGER PerProcessUserTimeLimit { get; }
        public _LARGE_INTEGER PerJobUserTimeLimit { get; }
        public ulong MinimumWorkingSetSize { get; }
        public ulong MaximumWorkingSetSize { get; }
        public uint LimitFlags { get; }
        public uint ActiveProcessLimit { get; }
        public _KAFFINITY_EX Affinity { get; }
        public IntPtr AccessState { get; }
        public IntPtr AccessStateQuotaReference { get; }
        public uint UIRestrictionsClass { get; }
        public uint EndOfJobTimeAction { get; }
        public IntPtr CompletionPort { get; }
        public IntPtr CompletionKey { get; }
        public ulong CompletionCount { get; }
        public uint SessionId { get; }
        public uint SchedulingClass { get; }
        public ulong ReadOperationCount { get; }
        public ulong WriteOperationCount { get; }
        public ulong OtherOperationCount { get; }
        public ulong ReadTransferCount { get; }
        public ulong WriteTransferCount { get; }
        public ulong OtherTransferCount { get; }
        public _PROCESS_DISK_COUNTERS DiskIoInfo { get; }
        public _PROCESS_NETWORK_COUNTERS NetworkIoInfo { get; }
        public ulong ProcessMemoryLimit { get; }
        public ulong JobMemoryLimit { get; }
        public ulong JobTotalMemoryLimit { get; }
        public ulong PeakProcessMemoryUsed { get; }
        public ulong PeakJobMemoryUsed { get; }
        public _KAFFINITY_EX EffectiveAffinity { get; }
        public _LARGE_INTEGER EffectivePerProcessUserTimeLimit { get; }
        public ulong EffectiveMinimumWorkingSetSize { get; }
        public ulong EffectiveMaximumWorkingSetSize { get; }
        public ulong EffectiveProcessMemoryLimit { get; }
        public IntPtr EffectiveProcessMemoryLimitJob { get; }
        public IntPtr EffectivePerProcessUserTimeLimitJob { get; }
        public IntPtr EffectiveNetIoRateLimitJob { get; }
        public IntPtr EffectiveHeapAttributionJob { get; }
        public uint EffectiveLimitFlags { get; }
        public uint EffectiveSchedulingClass { get; }
        public uint EffectiveFreezeCount { get; }
        public uint EffectiveGraphicsFreezeCount { get; }
        public uint EffectiveBackgroundCount { get; }
        public uint EffectiveSwapCount { get; }
        public uint EffectiveNotificationLimitCount { get; }
        public uint EffectiveIoPriorityLimit { get; }
        public uint IoPriorityLimit { get; }
        public uint EffectivePagePriorityLimit { get; }
        public uint PagePriorityLimit { get; }
        public byte EffectivePriorityClass { get; }
        public byte PriorityClass { get; }
        public byte NestingDepth { get; }
        public byte[] Reserved1 { get; }
        public uint CompletionFilter { get; }
        public _WNF_STATE_NAME WakeChannel { get; }
        public _PS_JOB_WAKE_INFORMATION WakeInfo { get; }
        public _JOBOBJECT_WAKE_FILTER WakeFilter { get; }
        public uint LowEdgeLatchFilter { get; }
        public IntPtr NotificationLink { get; }
        public ulong CurrentJobMemoryUsed { get; }
        public IntPtr NotificationInfo { get; }
        public IntPtr NotificationInfoQuotaReference { get; }
        public IntPtr NotificationPacket { get; }
        public IntPtr CpuRateControl { get; }
        public IntPtr EffectiveSchedulingGroup { get; }
        public ulong ReadyTime { get; }
        public _EX_PUSH_LOCK MemoryLimitsLock { get; }
        public _LIST_ENTRY SiblingJobLinks { get; }
        public _LIST_ENTRY ChildJobListHead { get; }
        public IntPtr ParentJob { get; }
        public IntPtr RootJob { get; }
        public _LIST_ENTRY IteratorListHead { get; }
        public ulong AncestorCount { get; }
        public IntPtr Ancestors { get; }
        public IntPtr SessionObject { get; }
        public _EPROCESS_VALUES Accounting { get; }
        public uint ShadowActiveProcessCount { get; }
        public uint ActiveAuxiliaryProcessCount { get; }
        public uint SequenceNumber { get; }
        public uint JobId { get; }
        public _GUID ContainerId { get; }
        public _GUID ContainerTelemetryId { get; }
        public IntPtr ServerSiloGlobals { get; }
        public _PS_PROPERTY_SET PropertySet { get; }
        public IntPtr Storage { get; }
        public IntPtr NetRateControl { get; }
        public uint JobFlags { get; }
        public uint CloseDone { get; }
        public uint MultiGroup { get; }
        public uint OutstandingNotification { get; }
        public uint NotificationInProgress { get; }
        public uint UILimits { get; }
        public uint CpuRateControlActive { get; }
        public uint OwnCpuRateControl { get; }
        public uint Terminating { get; }
        public uint WorkingSetLock { get; }
        public uint JobFrozen { get; }
        public uint Background { get; }
        public uint WakeNotificationAllocated { get; }
        public uint WakeNotificationEnabled { get; }
        public uint WakeNotificationPending { get; }
        public uint LimitNotificationRequired { get; }
        public uint ZeroCountNotificationRequired { get; }
        public uint CycleTimeNotificationRequired { get; }
        public uint CycleTimeNotificationPending { get; }
        public uint TimersVirtualized { get; }
        public uint JobSwapped { get; }
        public uint ViolationDetected { get; }
        public uint EmptyJobNotified { get; }
        public uint NoSystemCharge { get; }
        public uint DropNoWakeCharges { get; }
        public uint NoWakeChargePolicyDecided { get; }
        public uint NetRateControlActive { get; }
        public uint OwnNetRateControl { get; }
        public uint IoRateControlActive { get; }
        public uint OwnIoRateControl { get; }
        public uint DisallowNewProcesses { get; }
        public uint Silo { get; }
        public uint ContainerTelemetryIdSet { get; }
        public uint JobFlags2 { get; }
        public uint ParentLocked { get; }
        public uint EnableUsermodeSiloThreadImpersonation { get; }
        public uint DisallowUsermodeSiloThreadImpersonation { get; }
        public uint JobGraphicsFreezeOptimized { get; }
        public IntPtr EnergyValues { get; }
        public ulong SharedCommitCharge { get; }
        public uint DiskIoAttributionUserRefCount { get; }
        public uint DiskIoAttributionRefCount { get; }
        public IntPtr DiskIoAttributionContext { get; }
        public IntPtr DiskIoAttributionOwnerJob { get; }
        public _JOB_RATE_CONTROL_HEADER IoRateControlHeader { get; }
        public _PS_IO_CONTROL_ENTRY GlobalIoControl { get; }
        public int IoControlStateLock { get; }
        public _RTL_RB_TREE VolumeIoControlTree { get; }
        public ulong IoRateOverQuotaHistory { get; }
        public uint IoRateCurrentGeneration { get; }
        public uint IoRateLastQueryGeneration { get; }
        public uint IoRateGenerationLength { get; }
        public uint IoRateOverQuotaNotifySequenceId { get; }
        public ulong LastThrottledIoTime { get; }
        public _EX_PUSH_LOCK IoControlLock { get; }
        public long SiloHardReferenceCount { get; }
        public _WORK_QUEUE_ITEM RundownWorkItem { get; }
        public IntPtr PartitionObject { get; }
        public IntPtr PartitionOwnerJob { get; }
        public _JOBOBJECT_ENERGY_TRACKING_STATE EnergyTrackingState { get; }
        public ulong KernelWaitTime { get; }
        public ulong UserWaitTime { get; }

        public _EJOB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EJOB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EJOB.Event),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EJOB.JobLinks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EJOB.ProcessListHead),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EJOB.JobLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EJOB.TotalUserTime),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_EJOB.TotalKernelTime),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_EJOB.TotalCycleTime),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_EJOB.ThisPeriodTotalUserTime),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_EJOB.ThisPeriodTotalKernelTime),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_EJOB.TotalContextSwitches),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_EJOB.TotalPageFaultCount),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_EJOB.TotalProcesses),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_EJOB.ActiveProcesses),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_EJOB.TotalTerminatedProcesses),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_EJOB.PerProcessUserTimeLimit),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_EJOB.PerJobUserTimeLimit),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_EJOB.MinimumWorkingSetSize),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_EJOB.MaximumWorkingSetSize),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_EJOB.LimitFlags),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_EJOB.ActiveProcessLimit),
                    new ulong[]
                    {
                        260UL
                    }
                },
                {
                    nameof(_EJOB.Affinity),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_EJOB.AccessState),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_EJOB.AccessStateQuotaReference),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_EJOB.UIRestrictionsClass),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_EJOB.EndOfJobTimeAction),
                    new ulong[]
                    {
                        548UL
                    }
                },
                {
                    nameof(_EJOB.CompletionPort),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_EJOB.CompletionKey),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_EJOB.CompletionCount),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_EJOB.SessionId),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_EJOB.SchedulingClass),
                    new ulong[]
                    {
                        580UL
                    }
                },
                {
                    nameof(_EJOB.ReadOperationCount),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_EJOB.WriteOperationCount),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_EJOB.OtherOperationCount),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_EJOB.ReadTransferCount),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_EJOB.WriteTransferCount),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_EJOB.OtherTransferCount),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_EJOB.DiskIoInfo),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_EJOB.NetworkIoInfo),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_EJOB.ProcessMemoryLimit),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_EJOB.JobMemoryLimit),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_EJOB.JobTotalMemoryLimit),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_EJOB.PeakProcessMemoryUsed),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_EJOB.PeakJobMemoryUsed),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveAffinity),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_EJOB.EffectivePerProcessUserTimeLimit),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveMinimumWorkingSetSize),
                    new ulong[]
                    {
                        1000UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveMaximumWorkingSetSize),
                    new ulong[]
                    {
                        1008UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveProcessMemoryLimit),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveProcessMemoryLimitJob),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_EJOB.EffectivePerProcessUserTimeLimitJob),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveNetIoRateLimitJob),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveHeapAttributionJob),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveLimitFlags),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveSchedulingClass),
                    new ulong[]
                    {
                        1060UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveFreezeCount),
                    new ulong[]
                    {
                        1064UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveGraphicsFreezeCount),
                    new ulong[]
                    {
                        1068UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveBackgroundCount),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveSwapCount),
                    new ulong[]
                    {
                        1076UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveNotificationLimitCount),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveIoPriorityLimit),
                    new ulong[]
                    {
                        1084UL
                    }
                },
                {
                    nameof(_EJOB.IoPriorityLimit),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(_EJOB.EffectivePagePriorityLimit),
                    new ulong[]
                    {
                        1092UL
                    }
                },
                {
                    nameof(_EJOB.PagePriorityLimit),
                    new ulong[]
                    {
                        1096UL
                    }
                },
                {
                    nameof(_EJOB.EffectivePriorityClass),
                    new ulong[]
                    {
                        1100UL
                    }
                },
                {
                    nameof(_EJOB.PriorityClass),
                    new ulong[]
                    {
                        1101UL
                    }
                },
                {
                    nameof(_EJOB.NestingDepth),
                    new ulong[]
                    {
                        1102UL
                    }
                },
                {
                    nameof(_EJOB.Reserved1),
                    new ulong[]
                    {
                        1103UL
                    }
                },
                {
                    nameof(_EJOB.CompletionFilter),
                    new ulong[]
                    {
                        1104UL
                    }
                },
                {
                    nameof(_EJOB.WakeChannel),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(_EJOB.WakeInfo),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(_EJOB.WakeFilter),
                    new ulong[]
                    {
                        1184UL
                    }
                },
                {
                    nameof(_EJOB.LowEdgeLatchFilter),
                    new ulong[]
                    {
                        1192UL
                    }
                },
                {
                    nameof(_EJOB.NotificationLink),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_EJOB.CurrentJobMemoryUsed),
                    new ulong[]
                    {
                        1208UL
                    }
                },
                {
                    nameof(_EJOB.NotificationInfo),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_EJOB.NotificationInfoQuotaReference),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_EJOB.NotificationPacket),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(_EJOB.CpuRateControl),
                    new ulong[]
                    {
                        1240UL
                    }
                },
                {
                    nameof(_EJOB.EffectiveSchedulingGroup),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_EJOB.ReadyTime),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_EJOB.MemoryLimitsLock),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(_EJOB.SiblingJobLinks),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(_EJOB.ChildJobListHead),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_EJOB.ParentJob),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_EJOB.RootJob),
                    new ulong[]
                    {
                        1312UL
                    }
                },
                {
                    nameof(_EJOB.IteratorListHead),
                    new ulong[]
                    {
                        1320UL
                    }
                },
                {
                    nameof(_EJOB.AncestorCount),
                    new ulong[]
                    {
                        1336UL
                    }
                },
                {
                    nameof(_EJOB.Ancestors),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_EJOB.SessionObject),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_EJOB.Accounting),
                    new ulong[]
                    {
                        1352UL
                    }
                },
                {
                    nameof(_EJOB.ShadowActiveProcessCount),
                    new ulong[]
                    {
                        1456UL
                    }
                },
                {
                    nameof(_EJOB.ActiveAuxiliaryProcessCount),
                    new ulong[]
                    {
                        1460UL
                    }
                },
                {
                    nameof(_EJOB.SequenceNumber),
                    new ulong[]
                    {
                        1464UL
                    }
                },
                {
                    nameof(_EJOB.JobId),
                    new ulong[]
                    {
                        1468UL
                    }
                },
                {
                    nameof(_EJOB.ContainerId),
                    new ulong[]
                    {
                        1472UL
                    }
                },
                {
                    nameof(_EJOB.ContainerTelemetryId),
                    new ulong[]
                    {
                        1488UL
                    }
                },
                {
                    nameof(_EJOB.ServerSiloGlobals),
                    new ulong[]
                    {
                        1504UL
                    }
                },
                {
                    nameof(_EJOB.PropertySet),
                    new ulong[]
                    {
                        1512UL
                    }
                },
                {
                    nameof(_EJOB.Storage),
                    new ulong[]
                    {
                        1536UL
                    }
                },
                {
                    nameof(_EJOB.NetRateControl),
                    new ulong[]
                    {
                        1544UL
                    }
                },
                {
                    nameof(_EJOB.JobFlags),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.CloseDone),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.MultiGroup),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.OutstandingNotification),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.NotificationInProgress),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.UILimits),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.CpuRateControlActive),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.OwnCpuRateControl),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.Terminating),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.WorkingSetLock),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.JobFrozen),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.Background),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.WakeNotificationAllocated),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.WakeNotificationEnabled),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.WakeNotificationPending),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.LimitNotificationRequired),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.ZeroCountNotificationRequired),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.CycleTimeNotificationRequired),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.CycleTimeNotificationPending),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.TimersVirtualized),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.JobSwapped),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.ViolationDetected),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.EmptyJobNotified),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.NoSystemCharge),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.DropNoWakeCharges),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.NoWakeChargePolicyDecided),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.NetRateControlActive),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.OwnNetRateControl),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.IoRateControlActive),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.OwnIoRateControl),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.DisallowNewProcesses),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.Silo),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.ContainerTelemetryIdSet),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_EJOB.JobFlags2),
                    new ulong[]
                    {
                        1556UL
                    }
                },
                {
                    nameof(_EJOB.ParentLocked),
                    new ulong[]
                    {
                        1556UL
                    }
                },
                {
                    nameof(_EJOB.EnableUsermodeSiloThreadImpersonation),
                    new ulong[]
                    {
                        1556UL
                    }
                },
                {
                    nameof(_EJOB.DisallowUsermodeSiloThreadImpersonation),
                    new ulong[]
                    {
                        1556UL
                    }
                },
                {
                    nameof(_EJOB.JobGraphicsFreezeOptimized),
                    new ulong[]
                    {
                        1556UL
                    }
                },
                {
                    nameof(_EJOB.EnergyValues),
                    new ulong[]
                    {
                        1560UL
                    }
                },
                {
                    nameof(_EJOB.SharedCommitCharge),
                    new ulong[]
                    {
                        1568UL
                    }
                },
                {
                    nameof(_EJOB.DiskIoAttributionUserRefCount),
                    new ulong[]
                    {
                        1576UL
                    }
                },
                {
                    nameof(_EJOB.DiskIoAttributionRefCount),
                    new ulong[]
                    {
                        1580UL
                    }
                },
                {
                    nameof(_EJOB.DiskIoAttributionContext),
                    new ulong[]
                    {
                        1584UL
                    }
                },
                {
                    nameof(_EJOB.DiskIoAttributionOwnerJob),
                    new ulong[]
                    {
                        1584UL
                    }
                },
                {
                    nameof(_EJOB.IoRateControlHeader),
                    new ulong[]
                    {
                        1592UL
                    }
                },
                {
                    nameof(_EJOB.GlobalIoControl),
                    new ulong[]
                    {
                        1632UL
                    }
                },
                {
                    nameof(_EJOB.IoControlStateLock),
                    new ulong[]
                    {
                        1688UL
                    }
                },
                {
                    nameof(_EJOB.VolumeIoControlTree),
                    new ulong[]
                    {
                        1696UL
                    }
                },
                {
                    nameof(_EJOB.IoRateOverQuotaHistory),
                    new ulong[]
                    {
                        1712UL
                    }
                },
                {
                    nameof(_EJOB.IoRateCurrentGeneration),
                    new ulong[]
                    {
                        1720UL
                    }
                },
                {
                    nameof(_EJOB.IoRateLastQueryGeneration),
                    new ulong[]
                    {
                        1724UL
                    }
                },
                {
                    nameof(_EJOB.IoRateGenerationLength),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_EJOB.IoRateOverQuotaNotifySequenceId),
                    new ulong[]
                    {
                        1732UL
                    }
                },
                {
                    nameof(_EJOB.LastThrottledIoTime),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_EJOB.IoControlLock),
                    new ulong[]
                    {
                        1744UL
                    }
                },
                {
                    nameof(_EJOB.SiloHardReferenceCount),
                    new ulong[]
                    {
                        1752UL
                    }
                },
                {
                    nameof(_EJOB.RundownWorkItem),
                    new ulong[]
                    {
                        1760UL
                    }
                },
                {
                    nameof(_EJOB.PartitionObject),
                    new ulong[]
                    {
                        1792UL
                    }
                },
                {
                    nameof(_EJOB.PartitionOwnerJob),
                    new ulong[]
                    {
                        1800UL
                    }
                },
                {
                    nameof(_EJOB.EnergyTrackingState),
                    new ulong[]
                    {
                        1808UL
                    }
                },
                {
                    nameof(_EJOB.KernelWaitTime),
                    new ulong[]
                    {
                        1816UL
                    }
                },
                {
                    nameof(_EJOB.UserWaitTime),
                    new ulong[]
                    {
                        1824UL
                    }
                }
            };
            Register<_EJOB>((mem, ptr) => new _EJOB(mem, ptr), offsets);
        }
    }
}