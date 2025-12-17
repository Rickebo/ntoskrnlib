using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EJOB")]
    public sealed class Ejob : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(24UL)]
        public ListEntry JobLinks { get => ReadStructure<ListEntry>(nameof(JobLinks)); set => WriteStructure(nameof(JobLinks), value); }

        [Offset(40UL)]
        public ListEntry ProcessListHead { get => ReadStructure<ListEntry>(nameof(ProcessListHead)); set => WriteStructure(nameof(ProcessListHead), value); }

        [Offset(56UL)]
        public Eresource JobLock { get => ReadStructure<Eresource>(nameof(JobLock)); set => WriteStructure(nameof(JobLock), value); }

        [Offset(160UL)]
        public LargeInteger TotalUserTime { get => ReadStructure<LargeInteger>(nameof(TotalUserTime)); set => WriteStructure(nameof(TotalUserTime), value); }

        [Offset(168UL)]
        public LargeInteger TotalKernelTime { get => ReadStructure<LargeInteger>(nameof(TotalKernelTime)); set => WriteStructure(nameof(TotalKernelTime), value); }

        [Offset(176UL)]
        public LargeInteger TotalCycleTime { get => ReadStructure<LargeInteger>(nameof(TotalCycleTime)); set => WriteStructure(nameof(TotalCycleTime), value); }

        [Offset(184UL)]
        public LargeInteger ThisPeriodTotalUserTime { get => ReadStructure<LargeInteger>(nameof(ThisPeriodTotalUserTime)); set => WriteStructure(nameof(ThisPeriodTotalUserTime), value); }

        [Offset(192UL)]
        public LargeInteger ThisPeriodTotalKernelTime { get => ReadStructure<LargeInteger>(nameof(ThisPeriodTotalKernelTime)); set => WriteStructure(nameof(ThisPeriodTotalKernelTime), value); }

        [Offset(200UL)]
        public ulong TotalContextSwitches { get => ReadHere<ulong>(nameof(TotalContextSwitches)); set => WriteHere(nameof(TotalContextSwitches), value); }

        [Offset(208UL)]
        public uint TotalPageFaultCount { get => ReadHere<uint>(nameof(TotalPageFaultCount)); set => WriteHere(nameof(TotalPageFaultCount), value); }

        [Offset(212UL)]
        public uint TotalProcesses { get => ReadHere<uint>(nameof(TotalProcesses)); set => WriteHere(nameof(TotalProcesses), value); }

        [Offset(216UL)]
        public uint ActiveProcesses { get => ReadHere<uint>(nameof(ActiveProcesses)); set => WriteHere(nameof(ActiveProcesses), value); }

        [Offset(220UL)]
        public uint TotalTerminatedProcesses { get => ReadHere<uint>(nameof(TotalTerminatedProcesses)); set => WriteHere(nameof(TotalTerminatedProcesses), value); }

        [Offset(224UL)]
        public LargeInteger PerProcessUserTimeLimit { get => ReadStructure<LargeInteger>(nameof(PerProcessUserTimeLimit)); set => WriteStructure(nameof(PerProcessUserTimeLimit), value); }

        [Offset(232UL)]
        public LargeInteger PerJobUserTimeLimit { get => ReadStructure<LargeInteger>(nameof(PerJobUserTimeLimit)); set => WriteStructure(nameof(PerJobUserTimeLimit), value); }

        [Offset(240UL)]
        public ulong MinimumWorkingSetSize { get => ReadHere<ulong>(nameof(MinimumWorkingSetSize)); set => WriteHere(nameof(MinimumWorkingSetSize), value); }

        [Offset(248UL)]
        public ulong MaximumWorkingSetSize { get => ReadHere<ulong>(nameof(MaximumWorkingSetSize)); set => WriteHere(nameof(MaximumWorkingSetSize), value); }

        [Offset(256UL)]
        public uint LimitFlags { get => ReadHere<uint>(nameof(LimitFlags)); set => WriteHere(nameof(LimitFlags), value); }

        [Offset(260UL)]
        public uint ActiveProcessLimit { get => ReadHere<uint>(nameof(ActiveProcessLimit)); set => WriteHere(nameof(ActiveProcessLimit), value); }

        [Offset(264UL)]
        public KaffinityEx Affinity { get => ReadStructure<KaffinityEx>(nameof(Affinity)); set => WriteStructure(nameof(Affinity), value); }

        [Offset(528UL)]
        public IntPtr AccessState { get => ReadHere<IntPtr>(nameof(AccessState)); set => WriteHere(nameof(AccessState), value); }

        [Offset(536UL)]
        public IntPtr AccessStateQuotaReference { get => ReadHere<IntPtr>(nameof(AccessStateQuotaReference)); set => WriteHere(nameof(AccessStateQuotaReference), value); }

        [Offset(544UL)]
        public uint UIRestrictionsClass { get => ReadHere<uint>(nameof(UIRestrictionsClass)); set => WriteHere(nameof(UIRestrictionsClass), value); }

        [Offset(548UL)]
        public uint EndOfJobTimeAction { get => ReadHere<uint>(nameof(EndOfJobTimeAction)); set => WriteHere(nameof(EndOfJobTimeAction), value); }

        [Offset(552UL)]
        public IntPtr CompletionPort { get => ReadHere<IntPtr>(nameof(CompletionPort)); set => WriteHere(nameof(CompletionPort), value); }

        [Offset(560UL)]
        public IntPtr CompletionKey { get => ReadHere<IntPtr>(nameof(CompletionKey)); set => WriteHere(nameof(CompletionKey), value); }

        [Offset(568UL)]
        public ulong CompletionCount { get => ReadHere<ulong>(nameof(CompletionCount)); set => WriteHere(nameof(CompletionCount), value); }

        [Offset(576UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(580UL)]
        public uint SchedulingClass { get => ReadHere<uint>(nameof(SchedulingClass)); set => WriteHere(nameof(SchedulingClass), value); }

        [Offset(584UL)]
        public ulong ReadOperationCount { get => ReadHere<ulong>(nameof(ReadOperationCount)); set => WriteHere(nameof(ReadOperationCount), value); }

        [Offset(592UL)]
        public ulong WriteOperationCount { get => ReadHere<ulong>(nameof(WriteOperationCount)); set => WriteHere(nameof(WriteOperationCount), value); }

        [Offset(600UL)]
        public ulong OtherOperationCount { get => ReadHere<ulong>(nameof(OtherOperationCount)); set => WriteHere(nameof(OtherOperationCount), value); }

        [Offset(608UL)]
        public ulong ReadTransferCount { get => ReadHere<ulong>(nameof(ReadTransferCount)); set => WriteHere(nameof(ReadTransferCount), value); }

        [Offset(616UL)]
        public ulong WriteTransferCount { get => ReadHere<ulong>(nameof(WriteTransferCount)); set => WriteHere(nameof(WriteTransferCount), value); }

        [Offset(624UL)]
        public ulong OtherTransferCount { get => ReadHere<ulong>(nameof(OtherTransferCount)); set => WriteHere(nameof(OtherTransferCount), value); }

        [Offset(632UL)]
        public ProcessDiskCounters DiskIoInfo { get => ReadStructure<ProcessDiskCounters>(nameof(DiskIoInfo)); set => WriteStructure(nameof(DiskIoInfo), value); }

        [Offset(672UL)]
        public ProcessNetworkCounters NetworkIoInfo { get => ReadStructure<ProcessNetworkCounters>(nameof(NetworkIoInfo)); set => WriteStructure(nameof(NetworkIoInfo), value); }

        [Offset(688UL)]
        public ulong ProcessMemoryLimit { get => ReadHere<ulong>(nameof(ProcessMemoryLimit)); set => WriteHere(nameof(ProcessMemoryLimit), value); }

        [Offset(696UL)]
        public ulong JobMemoryLimit { get => ReadHere<ulong>(nameof(JobMemoryLimit)); set => WriteHere(nameof(JobMemoryLimit), value); }

        [Offset(704UL)]
        public ulong JobTotalMemoryLimit { get => ReadHere<ulong>(nameof(JobTotalMemoryLimit)); set => WriteHere(nameof(JobTotalMemoryLimit), value); }

        [Offset(712UL)]
        public ulong PeakProcessMemoryUsed { get => ReadHere<ulong>(nameof(PeakProcessMemoryUsed)); set => WriteHere(nameof(PeakProcessMemoryUsed), value); }

        [Offset(720UL)]
        public ulong PeakJobMemoryUsed { get => ReadHere<ulong>(nameof(PeakJobMemoryUsed)); set => WriteHere(nameof(PeakJobMemoryUsed), value); }

        [Offset(728UL)]
        public KaffinityEx EffectiveAffinity { get => ReadStructure<KaffinityEx>(nameof(EffectiveAffinity)); set => WriteStructure(nameof(EffectiveAffinity), value); }

        [Offset(992UL)]
        public LargeInteger EffectivePerProcessUserTimeLimit { get => ReadStructure<LargeInteger>(nameof(EffectivePerProcessUserTimeLimit)); set => WriteStructure(nameof(EffectivePerProcessUserTimeLimit), value); }

        [Offset(1000UL)]
        public ulong EffectiveMinimumWorkingSetSize { get => ReadHere<ulong>(nameof(EffectiveMinimumWorkingSetSize)); set => WriteHere(nameof(EffectiveMinimumWorkingSetSize), value); }

        [Offset(1008UL)]
        public ulong EffectiveMaximumWorkingSetSize { get => ReadHere<ulong>(nameof(EffectiveMaximumWorkingSetSize)); set => WriteHere(nameof(EffectiveMaximumWorkingSetSize), value); }

        [Offset(1016UL)]
        public ulong EffectiveProcessMemoryLimit { get => ReadHere<ulong>(nameof(EffectiveProcessMemoryLimit)); set => WriteHere(nameof(EffectiveProcessMemoryLimit), value); }

        [Offset(1024UL)]
        public IntPtr EffectiveProcessMemoryLimitJob { get => ReadHere<IntPtr>(nameof(EffectiveProcessMemoryLimitJob)); set => WriteHere(nameof(EffectiveProcessMemoryLimitJob), value); }

        [Offset(1032UL)]
        public IntPtr EffectivePerProcessUserTimeLimitJob { get => ReadHere<IntPtr>(nameof(EffectivePerProcessUserTimeLimitJob)); set => WriteHere(nameof(EffectivePerProcessUserTimeLimitJob), value); }

        [Offset(1040UL)]
        public IntPtr EffectiveNetIoRateLimitJob { get => ReadHere<IntPtr>(nameof(EffectiveNetIoRateLimitJob)); set => WriteHere(nameof(EffectiveNetIoRateLimitJob), value); }

        [Offset(1048UL)]
        public IntPtr EffectiveHeapAttributionJob { get => ReadHere<IntPtr>(nameof(EffectiveHeapAttributionJob)); set => WriteHere(nameof(EffectiveHeapAttributionJob), value); }

        [Offset(1056UL)]
        public uint EffectiveLimitFlags { get => ReadHere<uint>(nameof(EffectiveLimitFlags)); set => WriteHere(nameof(EffectiveLimitFlags), value); }

        [Offset(1060UL)]
        public uint EffectiveSchedulingClass { get => ReadHere<uint>(nameof(EffectiveSchedulingClass)); set => WriteHere(nameof(EffectiveSchedulingClass), value); }

        [Offset(1064UL)]
        public uint EffectiveFreezeCount { get => ReadHere<uint>(nameof(EffectiveFreezeCount)); set => WriteHere(nameof(EffectiveFreezeCount), value); }

        [Offset(1068UL)]
        public uint EffectiveGraphicsFreezeCount { get => ReadHere<uint>(nameof(EffectiveGraphicsFreezeCount)); set => WriteHere(nameof(EffectiveGraphicsFreezeCount), value); }

        [Offset(1072UL)]
        public uint EffectiveBackgroundCount { get => ReadHere<uint>(nameof(EffectiveBackgroundCount)); set => WriteHere(nameof(EffectiveBackgroundCount), value); }

        [Offset(1076UL)]
        public uint EffectiveSwapCount { get => ReadHere<uint>(nameof(EffectiveSwapCount)); set => WriteHere(nameof(EffectiveSwapCount), value); }

        [Offset(1080UL)]
        public uint EffectiveNotificationLimitCount { get => ReadHere<uint>(nameof(EffectiveNotificationLimitCount)); set => WriteHere(nameof(EffectiveNotificationLimitCount), value); }

        [Offset(1084UL)]
        public uint EffectiveIoPriorityLimit { get => ReadHere<uint>(nameof(EffectiveIoPriorityLimit)); set => WriteHere(nameof(EffectiveIoPriorityLimit), value); }

        [Offset(1088UL)]
        public uint IoPriorityLimit { get => ReadHere<uint>(nameof(IoPriorityLimit)); set => WriteHere(nameof(IoPriorityLimit), value); }

        [Offset(1092UL)]
        public uint EffectivePagePriorityLimit { get => ReadHere<uint>(nameof(EffectivePagePriorityLimit)); set => WriteHere(nameof(EffectivePagePriorityLimit), value); }

        [Offset(1096UL)]
        public uint PagePriorityLimit { get => ReadHere<uint>(nameof(PagePriorityLimit)); set => WriteHere(nameof(PagePriorityLimit), value); }

        [Offset(1100UL)]
        public byte EffectivePriorityClass { get => ReadHere<byte>(nameof(EffectivePriorityClass)); set => WriteHere(nameof(EffectivePriorityClass), value); }

        [Offset(1101UL)]
        public byte PriorityClass { get => ReadHere<byte>(nameof(PriorityClass)); set => WriteHere(nameof(PriorityClass), value); }

        [Offset(1102UL)]
        public byte NestingDepth { get => ReadHere<byte>(nameof(NestingDepth)); set => WriteHere(nameof(NestingDepth), value); }

        [Offset(1103UL)]
        [Length(1)]
        public DynamicArray Reserved1 { get => ReadStructure<DynamicArray>(nameof(Reserved1)); set => WriteStructure(nameof(Reserved1), value); }

        [Offset(1104UL)]
        public uint CompletionFilter { get => ReadHere<uint>(nameof(CompletionFilter)); set => WriteHere(nameof(CompletionFilter), value); }

        [Offset(1112UL)]
        public WnfStateName WakeChannel { get => ReadStructure<WnfStateName>(nameof(WakeChannel)); set => WriteStructure(nameof(WakeChannel), value); }

        [Offset(1112UL)]
        public PsJobWakeInformation WakeInfo { get => ReadStructure<PsJobWakeInformation>(nameof(WakeInfo)); set => WriteStructure(nameof(WakeInfo), value); }

        [Offset(1184UL)]
        public JobobjectWakeFilter WakeFilter { get => ReadStructure<JobobjectWakeFilter>(nameof(WakeFilter)); set => WriteStructure(nameof(WakeFilter), value); }

        [Offset(1192UL)]
        public uint LowEdgeLatchFilter { get => ReadHere<uint>(nameof(LowEdgeLatchFilter)); set => WriteHere(nameof(LowEdgeLatchFilter), value); }

        [Offset(1200UL)]
        public IntPtr NotificationLink { get => ReadHere<IntPtr>(nameof(NotificationLink)); set => WriteHere(nameof(NotificationLink), value); }

        [Offset(1208UL)]
        public ulong CurrentJobMemoryUsed { get => ReadHere<ulong>(nameof(CurrentJobMemoryUsed)); set => WriteHere(nameof(CurrentJobMemoryUsed), value); }

        [Offset(1216UL)]
        public IntPtr NotificationInfo { get => ReadHere<IntPtr>(nameof(NotificationInfo)); set => WriteHere(nameof(NotificationInfo), value); }

        [Offset(1224UL)]
        public IntPtr NotificationInfoQuotaReference { get => ReadHere<IntPtr>(nameof(NotificationInfoQuotaReference)); set => WriteHere(nameof(NotificationInfoQuotaReference), value); }

        [Offset(1232UL)]
        public IntPtr NotificationPacket { get => ReadHere<IntPtr>(nameof(NotificationPacket)); set => WriteHere(nameof(NotificationPacket), value); }

        [Offset(1240UL)]
        public IntPtr CpuRateControl { get => ReadHere<IntPtr>(nameof(CpuRateControl)); set => WriteHere(nameof(CpuRateControl), value); }

        [Offset(1248UL)]
        public IntPtr EffectiveSchedulingGroup { get => ReadHere<IntPtr>(nameof(EffectiveSchedulingGroup)); set => WriteHere(nameof(EffectiveSchedulingGroup), value); }

        [Offset(1256UL)]
        public ulong ReadyTime { get => ReadHere<ulong>(nameof(ReadyTime)); set => WriteHere(nameof(ReadyTime), value); }

        [Offset(1264UL)]
        public ExPushLock MemoryLimitsLock { get => ReadStructure<ExPushLock>(nameof(MemoryLimitsLock)); set => WriteStructure(nameof(MemoryLimitsLock), value); }

        [Offset(1272UL)]
        public ListEntry SiblingJobLinks { get => ReadStructure<ListEntry>(nameof(SiblingJobLinks)); set => WriteStructure(nameof(SiblingJobLinks), value); }

        [Offset(1288UL)]
        public ListEntry ChildJobListHead { get => ReadStructure<ListEntry>(nameof(ChildJobListHead)); set => WriteStructure(nameof(ChildJobListHead), value); }

        [Offset(1304UL)]
        public IntPtr ParentJob { get => ReadHere<IntPtr>(nameof(ParentJob)); set => WriteHere(nameof(ParentJob), value); }

        [Offset(1312UL)]
        public IntPtr RootJob { get => ReadHere<IntPtr>(nameof(RootJob)); set => WriteHere(nameof(RootJob), value); }

        [Offset(1320UL)]
        public ListEntry IteratorListHead { get => ReadStructure<ListEntry>(nameof(IteratorListHead)); set => WriteStructure(nameof(IteratorListHead), value); }

        [Offset(1336UL)]
        public ulong AncestorCount { get => ReadHere<ulong>(nameof(AncestorCount)); set => WriteHere(nameof(AncestorCount), value); }

        [Offset(1344UL)]
        public IntPtr Ancestors { get => ReadHere<IntPtr>(nameof(Ancestors)); set => WriteHere(nameof(Ancestors), value); }

        [Offset(1344UL)]
        public IntPtr SessionObject { get => ReadHere<IntPtr>(nameof(SessionObject)); set => WriteHere(nameof(SessionObject), value); }

        [Offset(1352UL)]
        public EprocessValues Accounting { get => ReadStructure<EprocessValues>(nameof(Accounting)); set => WriteStructure(nameof(Accounting), value); }

        [Offset(1456UL)]
        public uint ShadowActiveProcessCount { get => ReadHere<uint>(nameof(ShadowActiveProcessCount)); set => WriteHere(nameof(ShadowActiveProcessCount), value); }

        [Offset(1460UL)]
        public uint ActiveAuxiliaryProcessCount { get => ReadHere<uint>(nameof(ActiveAuxiliaryProcessCount)); set => WriteHere(nameof(ActiveAuxiliaryProcessCount), value); }

        [Offset(1464UL)]
        public uint SequenceNumber { get => ReadHere<uint>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(1468UL)]
        public uint JobId { get => ReadHere<uint>(nameof(JobId)); set => WriteHere(nameof(JobId), value); }

        [Offset(1472UL)]
        public Guid ContainerId { get => ReadStructure<Guid>(nameof(ContainerId)); set => WriteStructure(nameof(ContainerId), value); }

        [Offset(1488UL)]
        public Guid ContainerTelemetryId { get => ReadStructure<Guid>(nameof(ContainerTelemetryId)); set => WriteStructure(nameof(ContainerTelemetryId), value); }

        [Offset(1504UL)]
        public IntPtr ServerSiloGlobals { get => ReadHere<IntPtr>(nameof(ServerSiloGlobals)); set => WriteHere(nameof(ServerSiloGlobals), value); }

        [Offset(1512UL)]
        public PsPropertySet PropertySet { get => ReadStructure<PsPropertySet>(nameof(PropertySet)); set => WriteStructure(nameof(PropertySet), value); }

        [Offset(1536UL)]
        public IntPtr Storage { get => ReadHere<IntPtr>(nameof(Storage)); set => WriteHere(nameof(Storage), value); }

        [Offset(1544UL)]
        public IntPtr NetRateControl { get => ReadHere<IntPtr>(nameof(NetRateControl)); set => WriteHere(nameof(NetRateControl), value); }

        [Offset(1552UL)]
        public uint JobFlags { get => ReadHere<uint>(nameof(JobFlags)); set => WriteHere(nameof(JobFlags), value); }

        [Offset(1552UL)]
        public uint CloseDone { get => ReadHere<uint>(nameof(CloseDone)); set => WriteHere(nameof(CloseDone), value); }

        [Offset(1552UL)]
        public uint MultiGroup { get => ReadHere<uint>(nameof(MultiGroup)); set => WriteHere(nameof(MultiGroup), value); }

        [Offset(1552UL)]
        public uint OutstandingNotification { get => ReadHere<uint>(nameof(OutstandingNotification)); set => WriteHere(nameof(OutstandingNotification), value); }

        [Offset(1552UL)]
        public uint NotificationInProgress { get => ReadHere<uint>(nameof(NotificationInProgress)); set => WriteHere(nameof(NotificationInProgress), value); }

        [Offset(1552UL)]
        public uint UILimits { get => ReadHere<uint>(nameof(UILimits)); set => WriteHere(nameof(UILimits), value); }

        [Offset(1552UL)]
        public uint CpuRateControlActive { get => ReadHere<uint>(nameof(CpuRateControlActive)); set => WriteHere(nameof(CpuRateControlActive), value); }

        [Offset(1552UL)]
        public uint OwnCpuRateControl { get => ReadHere<uint>(nameof(OwnCpuRateControl)); set => WriteHere(nameof(OwnCpuRateControl), value); }

        [Offset(1552UL)]
        public uint Terminating { get => ReadHere<uint>(nameof(Terminating)); set => WriteHere(nameof(Terminating), value); }

        [Offset(1552UL)]
        public uint WorkingSetLock { get => ReadHere<uint>(nameof(WorkingSetLock)); set => WriteHere(nameof(WorkingSetLock), value); }

        [Offset(1552UL)]
        public uint JobFrozen { get => ReadHere<uint>(nameof(JobFrozen)); set => WriteHere(nameof(JobFrozen), value); }

        [Offset(1552UL)]
        public uint Background { get => ReadHere<uint>(nameof(Background)); set => WriteHere(nameof(Background), value); }

        [Offset(1552UL)]
        public uint WakeNotificationAllocated { get => ReadHere<uint>(nameof(WakeNotificationAllocated)); set => WriteHere(nameof(WakeNotificationAllocated), value); }

        [Offset(1552UL)]
        public uint WakeNotificationEnabled { get => ReadHere<uint>(nameof(WakeNotificationEnabled)); set => WriteHere(nameof(WakeNotificationEnabled), value); }

        [Offset(1552UL)]
        public uint WakeNotificationPending { get => ReadHere<uint>(nameof(WakeNotificationPending)); set => WriteHere(nameof(WakeNotificationPending), value); }

        [Offset(1552UL)]
        public uint LimitNotificationRequired { get => ReadHere<uint>(nameof(LimitNotificationRequired)); set => WriteHere(nameof(LimitNotificationRequired), value); }

        [Offset(1552UL)]
        public uint ZeroCountNotificationRequired { get => ReadHere<uint>(nameof(ZeroCountNotificationRequired)); set => WriteHere(nameof(ZeroCountNotificationRequired), value); }

        [Offset(1552UL)]
        public uint CycleTimeNotificationRequired { get => ReadHere<uint>(nameof(CycleTimeNotificationRequired)); set => WriteHere(nameof(CycleTimeNotificationRequired), value); }

        [Offset(1552UL)]
        public uint CycleTimeNotificationPending { get => ReadHere<uint>(nameof(CycleTimeNotificationPending)); set => WriteHere(nameof(CycleTimeNotificationPending), value); }

        [Offset(1552UL)]
        public uint TimersVirtualized { get => ReadHere<uint>(nameof(TimersVirtualized)); set => WriteHere(nameof(TimersVirtualized), value); }

        [Offset(1552UL)]
        public uint JobSwapped { get => ReadHere<uint>(nameof(JobSwapped)); set => WriteHere(nameof(JobSwapped), value); }

        [Offset(1552UL)]
        public uint ViolationDetected { get => ReadHere<uint>(nameof(ViolationDetected)); set => WriteHere(nameof(ViolationDetected), value); }

        [Offset(1552UL)]
        public uint EmptyJobNotified { get => ReadHere<uint>(nameof(EmptyJobNotified)); set => WriteHere(nameof(EmptyJobNotified), value); }

        [Offset(1552UL)]
        public uint NoSystemCharge { get => ReadHere<uint>(nameof(NoSystemCharge)); set => WriteHere(nameof(NoSystemCharge), value); }

        [Offset(1552UL)]
        public uint DropNoWakeCharges { get => ReadHere<uint>(nameof(DropNoWakeCharges)); set => WriteHere(nameof(DropNoWakeCharges), value); }

        [Offset(1552UL)]
        public uint NoWakeChargePolicyDecided { get => ReadHere<uint>(nameof(NoWakeChargePolicyDecided)); set => WriteHere(nameof(NoWakeChargePolicyDecided), value); }

        [Offset(1552UL)]
        public uint NetRateControlActive { get => ReadHere<uint>(nameof(NetRateControlActive)); set => WriteHere(nameof(NetRateControlActive), value); }

        [Offset(1552UL)]
        public uint OwnNetRateControl { get => ReadHere<uint>(nameof(OwnNetRateControl)); set => WriteHere(nameof(OwnNetRateControl), value); }

        [Offset(1552UL)]
        public uint IoRateControlActive { get => ReadHere<uint>(nameof(IoRateControlActive)); set => WriteHere(nameof(IoRateControlActive), value); }

        [Offset(1552UL)]
        public uint OwnIoRateControl { get => ReadHere<uint>(nameof(OwnIoRateControl)); set => WriteHere(nameof(OwnIoRateControl), value); }

        [Offset(1552UL)]
        public uint DisallowNewProcesses { get => ReadHere<uint>(nameof(DisallowNewProcesses)); set => WriteHere(nameof(DisallowNewProcesses), value); }

        [Offset(1552UL)]
        public uint Silo { get => ReadHere<uint>(nameof(Silo)); set => WriteHere(nameof(Silo), value); }

        [Offset(1552UL)]
        public uint ContainerTelemetryIdSet { get => ReadHere<uint>(nameof(ContainerTelemetryIdSet)); set => WriteHere(nameof(ContainerTelemetryIdSet), value); }

        [Offset(1556UL)]
        public uint JobFlags2 { get => ReadHere<uint>(nameof(JobFlags2)); set => WriteHere(nameof(JobFlags2), value); }

        [Offset(1556UL)]
        public uint ParentLocked { get => ReadHere<uint>(nameof(ParentLocked)); set => WriteHere(nameof(ParentLocked), value); }

        [Offset(1556UL)]
        public uint EnableUsermodeSiloThreadImpersonation { get => ReadHere<uint>(nameof(EnableUsermodeSiloThreadImpersonation)); set => WriteHere(nameof(EnableUsermodeSiloThreadImpersonation), value); }

        [Offset(1556UL)]
        public uint DisallowUsermodeSiloThreadImpersonation { get => ReadHere<uint>(nameof(DisallowUsermodeSiloThreadImpersonation)); set => WriteHere(nameof(DisallowUsermodeSiloThreadImpersonation), value); }

        [Offset(1556UL)]
        public uint JobGraphicsFreezeOptimized { get => ReadHere<uint>(nameof(JobGraphicsFreezeOptimized)); set => WriteHere(nameof(JobGraphicsFreezeOptimized), value); }

        [Offset(1560UL)]
        public IntPtr EnergyValues { get => ReadHere<IntPtr>(nameof(EnergyValues)); set => WriteHere(nameof(EnergyValues), value); }

        [Offset(1568UL)]
        public ulong SharedCommitCharge { get => ReadHere<ulong>(nameof(SharedCommitCharge)); set => WriteHere(nameof(SharedCommitCharge), value); }

        [Offset(1576UL)]
        public uint DiskIoAttributionUserRefCount { get => ReadHere<uint>(nameof(DiskIoAttributionUserRefCount)); set => WriteHere(nameof(DiskIoAttributionUserRefCount), value); }

        [Offset(1580UL)]
        public uint DiskIoAttributionRefCount { get => ReadHere<uint>(nameof(DiskIoAttributionRefCount)); set => WriteHere(nameof(DiskIoAttributionRefCount), value); }

        [Offset(1584UL)]
        public IntPtr DiskIoAttributionContext { get => ReadHere<IntPtr>(nameof(DiskIoAttributionContext)); set => WriteHere(nameof(DiskIoAttributionContext), value); }

        [Offset(1584UL)]
        public IntPtr DiskIoAttributionOwnerJob { get => ReadHere<IntPtr>(nameof(DiskIoAttributionOwnerJob)); set => WriteHere(nameof(DiskIoAttributionOwnerJob), value); }

        [Offset(1592UL)]
        public JobRateControlHeader IoRateControlHeader { get => ReadStructure<JobRateControlHeader>(nameof(IoRateControlHeader)); set => WriteStructure(nameof(IoRateControlHeader), value); }

        [Offset(1632UL)]
        public PsIoControlEntry GlobalIoControl { get => ReadStructure<PsIoControlEntry>(nameof(GlobalIoControl)); set => WriteStructure(nameof(GlobalIoControl), value); }

        [Offset(1688UL)]
        public int IoControlStateLock { get => ReadHere<int>(nameof(IoControlStateLock)); set => WriteHere(nameof(IoControlStateLock), value); }

        [Offset(1696UL)]
        public RtlRbTree VolumeIoControlTree { get => ReadStructure<RtlRbTree>(nameof(VolumeIoControlTree)); set => WriteStructure(nameof(VolumeIoControlTree), value); }

        [Offset(1712UL)]
        public ulong IoRateOverQuotaHistory { get => ReadHere<ulong>(nameof(IoRateOverQuotaHistory)); set => WriteHere(nameof(IoRateOverQuotaHistory), value); }

        [Offset(1720UL)]
        public uint IoRateCurrentGeneration { get => ReadHere<uint>(nameof(IoRateCurrentGeneration)); set => WriteHere(nameof(IoRateCurrentGeneration), value); }

        [Offset(1724UL)]
        public uint IoRateLastQueryGeneration { get => ReadHere<uint>(nameof(IoRateLastQueryGeneration)); set => WriteHere(nameof(IoRateLastQueryGeneration), value); }

        [Offset(1728UL)]
        public uint IoRateGenerationLength { get => ReadHere<uint>(nameof(IoRateGenerationLength)); set => WriteHere(nameof(IoRateGenerationLength), value); }

        [Offset(1732UL)]
        public uint IoRateOverQuotaNotifySequenceId { get => ReadHere<uint>(nameof(IoRateOverQuotaNotifySequenceId)); set => WriteHere(nameof(IoRateOverQuotaNotifySequenceId), value); }

        [Offset(1736UL)]
        public ulong LastThrottledIoTime { get => ReadHere<ulong>(nameof(LastThrottledIoTime)); set => WriteHere(nameof(LastThrottledIoTime), value); }

        [Offset(1744UL)]
        public ExPushLock IoControlLock { get => ReadStructure<ExPushLock>(nameof(IoControlLock)); set => WriteStructure(nameof(IoControlLock), value); }

        [Offset(1752UL)]
        public long SiloHardReferenceCount { get => ReadHere<long>(nameof(SiloHardReferenceCount)); set => WriteHere(nameof(SiloHardReferenceCount), value); }

        [Offset(1760UL)]
        public WorkQueueItem RundownWorkItem { get => ReadStructure<WorkQueueItem>(nameof(RundownWorkItem)); set => WriteStructure(nameof(RundownWorkItem), value); }

        [Offset(1792UL)]
        public IntPtr PartitionObject { get => ReadHere<IntPtr>(nameof(PartitionObject)); set => WriteHere(nameof(PartitionObject), value); }

        [Offset(1800UL)]
        public IntPtr PartitionOwnerJob { get => ReadHere<IntPtr>(nameof(PartitionOwnerJob)); set => WriteHere(nameof(PartitionOwnerJob), value); }

        [Offset(1808UL)]
        public JobobjectEnergyTrackingState EnergyTrackingState { get => ReadStructure<JobobjectEnergyTrackingState>(nameof(EnergyTrackingState)); set => WriteStructure(nameof(EnergyTrackingState), value); }

        [Offset(1816UL)]
        public ulong KernelWaitTime { get => ReadHere<ulong>(nameof(KernelWaitTime)); set => WriteHere(nameof(KernelWaitTime), value); }

        [Offset(1824UL)]
        public ulong UserWaitTime { get => ReadHere<ulong>(nameof(UserWaitTime)); set => WriteHere(nameof(UserWaitTime), value); }

        public Ejob(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Ejob>();
        }
    }
}