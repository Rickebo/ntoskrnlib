using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1832)]
public struct _EJOB
{
    [FieldOffset(0)]
    public _KEVENT Event;
    [FieldOffset(24)]
    public _LIST_ENTRY JobLinks;
    [FieldOffset(40)]
    public _LIST_ENTRY ProcessListHead;
    [FieldOffset(56)]
    public _ERESOURCE JobLock;
    [FieldOffset(160)]
    public _LARGE_INTEGER TotalUserTime;
    [FieldOffset(168)]
    public _LARGE_INTEGER TotalKernelTime;
    [FieldOffset(176)]
    public _LARGE_INTEGER TotalCycleTime;
    [FieldOffset(184)]
    public _LARGE_INTEGER ThisPeriodTotalUserTime;
    [FieldOffset(192)]
    public _LARGE_INTEGER ThisPeriodTotalKernelTime;
    [FieldOffset(200)]
    public ulong TotalContextSwitches;
    [FieldOffset(208)]
    public uint TotalPageFaultCount;
    [FieldOffset(212)]
    public uint TotalProcesses;
    [FieldOffset(216)]
    public uint ActiveProcesses;
    [FieldOffset(220)]
    public uint TotalTerminatedProcesses;
    [FieldOffset(224)]
    public _LARGE_INTEGER PerProcessUserTimeLimit;
    [FieldOffset(232)]
    public _LARGE_INTEGER PerJobUserTimeLimit;
    [FieldOffset(240)]
    public ulong MinimumWorkingSetSize;
    [FieldOffset(248)]
    public ulong MaximumWorkingSetSize;
    [FieldOffset(256)]
    public uint LimitFlags;
    [FieldOffset(260)]
    public uint ActiveProcessLimit;
    [FieldOffset(264)]
    public _KAFFINITY_EX Affinity;
    [FieldOffset(528)]
    public IntPtr AccessState;
    [FieldOffset(536)]
    public IntPtr AccessStateQuotaReference;
    [FieldOffset(544)]
    public uint UIRestrictionsClass;
    [FieldOffset(548)]
    public uint EndOfJobTimeAction;
    [FieldOffset(552)]
    public IntPtr CompletionPort;
    [FieldOffset(560)]
    public IntPtr CompletionKey;
    [FieldOffset(568)]
    public ulong CompletionCount;
    [FieldOffset(576)]
    public uint SessionId;
    [FieldOffset(580)]
    public uint SchedulingClass;
    [FieldOffset(584)]
    public ulong ReadOperationCount;
    [FieldOffset(592)]
    public ulong WriteOperationCount;
    [FieldOffset(600)]
    public ulong OtherOperationCount;
    [FieldOffset(608)]
    public ulong ReadTransferCount;
    [FieldOffset(616)]
    public ulong WriteTransferCount;
    [FieldOffset(624)]
    public ulong OtherTransferCount;
    [FieldOffset(632)]
    public _PROCESS_DISK_COUNTERS DiskIoInfo;
    [FieldOffset(672)]
    public _PROCESS_NETWORK_COUNTERS NetworkIoInfo;
    [FieldOffset(688)]
    public ulong ProcessMemoryLimit;
    [FieldOffset(696)]
    public ulong JobMemoryLimit;
    [FieldOffset(704)]
    public ulong JobTotalMemoryLimit;
    [FieldOffset(712)]
    public ulong PeakProcessMemoryUsed;
    [FieldOffset(720)]
    public ulong PeakJobMemoryUsed;
    [FieldOffset(728)]
    public _KAFFINITY_EX EffectiveAffinity;
    [FieldOffset(992)]
    public _LARGE_INTEGER EffectivePerProcessUserTimeLimit;
    [FieldOffset(1000)]
    public ulong EffectiveMinimumWorkingSetSize;
    [FieldOffset(1008)]
    public ulong EffectiveMaximumWorkingSetSize;
    [FieldOffset(1016)]
    public ulong EffectiveProcessMemoryLimit;
    [FieldOffset(1024)]
    public IntPtr EffectiveProcessMemoryLimitJob;
    [FieldOffset(1032)]
    public IntPtr EffectivePerProcessUserTimeLimitJob;
    [FieldOffset(1040)]
    public IntPtr EffectiveNetIoRateLimitJob;
    [FieldOffset(1048)]
    public IntPtr EffectiveHeapAttributionJob;
    [FieldOffset(1056)]
    public uint EffectiveLimitFlags;
    [FieldOffset(1060)]
    public uint EffectiveSchedulingClass;
    [FieldOffset(1064)]
    public uint EffectiveFreezeCount;
    [FieldOffset(1068)]
    public uint EffectiveGraphicsFreezeCount;
    [FieldOffset(1072)]
    public uint EffectiveBackgroundCount;
    [FieldOffset(1076)]
    public uint EffectiveSwapCount;
    [FieldOffset(1080)]
    public uint EffectiveNotificationLimitCount;
    [FieldOffset(1084)]
    public uint EffectiveIoPriorityLimit;
    [FieldOffset(1088)]
    public uint IoPriorityLimit;
    [FieldOffset(1092)]
    public uint EffectivePagePriorityLimit;
    [FieldOffset(1096)]
    public uint PagePriorityLimit;
    [FieldOffset(1100)]
    public byte EffectivePriorityClass;
    [FieldOffset(1101)]
    public byte PriorityClass;
    [FieldOffset(1102)]
    public byte NestingDepth;
    [FieldOffset(1103)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Reserved1;
    [FieldOffset(1104)]
    public uint CompletionFilter;
    [FieldOffset(1112)]
    public _WNF_STATE_NAME WakeChannel;
    [FieldOffset(1112)]
    public _PS_JOB_WAKE_INFORMATION WakeInfo;
    [FieldOffset(1184)]
    public _JOBOBJECT_WAKE_FILTER WakeFilter;
    [FieldOffset(1192)]
    public uint LowEdgeLatchFilter;
    [FieldOffset(1200)]
    public IntPtr NotificationLink;
    [FieldOffset(1208)]
    public ulong CurrentJobMemoryUsed;
    [FieldOffset(1216)]
    public IntPtr NotificationInfo;
    [FieldOffset(1224)]
    public IntPtr NotificationInfoQuotaReference;
    [FieldOffset(1232)]
    public IntPtr NotificationPacket;
    [FieldOffset(1240)]
    public IntPtr CpuRateControl;
    [FieldOffset(1248)]
    public IntPtr EffectiveSchedulingGroup;
    [FieldOffset(1256)]
    public ulong ReadyTime;
    [FieldOffset(1264)]
    public _EX_PUSH_LOCK MemoryLimitsLock;
    [FieldOffset(1272)]
    public _LIST_ENTRY SiblingJobLinks;
    [FieldOffset(1288)]
    public _LIST_ENTRY ChildJobListHead;
    [FieldOffset(1304)]
    public IntPtr ParentJob;
    [FieldOffset(1312)]
    public IntPtr RootJob;
    [FieldOffset(1320)]
    public _LIST_ENTRY IteratorListHead;
    [FieldOffset(1336)]
    public ulong AncestorCount;
    [FieldOffset(1344)]
    public IntPtr Ancestors;
    [FieldOffset(1344)]
    public IntPtr SessionObject;
    [FieldOffset(1352)]
    public _EPROCESS_VALUES Accounting;
    [FieldOffset(1456)]
    public uint ShadowActiveProcessCount;
    [FieldOffset(1460)]
    public uint ActiveAuxiliaryProcessCount;
    [FieldOffset(1464)]
    public uint SequenceNumber;
    [FieldOffset(1468)]
    public uint JobId;
    [FieldOffset(1472)]
    public _GUID ContainerId;
    [FieldOffset(1488)]
    public _GUID ContainerTelemetryId;
    [FieldOffset(1504)]
    public IntPtr ServerSiloGlobals;
    [FieldOffset(1512)]
    public _PS_PROPERTY_SET PropertySet;
    [FieldOffset(1536)]
    public IntPtr Storage;
    [FieldOffset(1544)]
    public IntPtr NetRateControl;
    [FieldOffset(1552)]
    public uint JobFlags;
    [FieldOffset(1556)]
    public uint JobFlags2;
    [FieldOffset(1560)]
    public IntPtr EnergyValues;
    [FieldOffset(1568)]
    public ulong SharedCommitCharge;
    [FieldOffset(1576)]
    public uint DiskIoAttributionUserRefCount;
    [FieldOffset(1580)]
    public uint DiskIoAttributionRefCount;
    [FieldOffset(1584)]
    public IntPtr DiskIoAttributionContext;
    [FieldOffset(1584)]
    public IntPtr DiskIoAttributionOwnerJob;
    [FieldOffset(1592)]
    public _JOB_RATE_CONTROL_HEADER IoRateControlHeader;
    [FieldOffset(1632)]
    public _PS_IO_CONTROL_ENTRY GlobalIoControl;
    [FieldOffset(1688)]
    public int IoControlStateLock;
    [FieldOffset(1696)]
    public _RTL_RB_TREE VolumeIoControlTree;
    [FieldOffset(1712)]
    public ulong IoRateOverQuotaHistory;
    [FieldOffset(1720)]
    public uint IoRateCurrentGeneration;
    [FieldOffset(1724)]
    public uint IoRateLastQueryGeneration;
    [FieldOffset(1728)]
    public uint IoRateGenerationLength;
    [FieldOffset(1732)]
    public uint IoRateOverQuotaNotifySequenceId;
    [FieldOffset(1736)]
    public ulong LastThrottledIoTime;
    [FieldOffset(1744)]
    public _EX_PUSH_LOCK IoControlLock;
    [FieldOffset(1752)]
    public long SiloHardReferenceCount;
    [FieldOffset(1760)]
    public _WORK_QUEUE_ITEM RundownWorkItem;
    [FieldOffset(1792)]
    public IntPtr PartitionObject;
    [FieldOffset(1800)]
    public IntPtr PartitionOwnerJob;
    [FieldOffset(1808)]
    public _JOBOBJECT_ENERGY_TRACKING_STATE EnergyTrackingState;
    [FieldOffset(1816)]
    public ulong KernelWaitTime;
    [FieldOffset(1824)]
    public ulong UserWaitTime;
}
