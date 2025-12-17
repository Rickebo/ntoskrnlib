using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPROCESS")]
    public sealed class Kprocess : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        public ListEntry ProfileListHead { get => ReadStructure<ListEntry>(nameof(ProfileListHead)); set => WriteStructure(nameof(ProfileListHead), value); }

        [Offset(40UL)]
        public ulong DirectoryTableBase { get => ReadHere<ulong>(nameof(DirectoryTableBase)); set => WriteHere(nameof(DirectoryTableBase), value); }

        [Offset(48UL)]
        public ListEntry ThreadListHead { get => ReadStructure<ListEntry>(nameof(ThreadListHead)); set => WriteStructure(nameof(ThreadListHead), value); }

        [Offset(64UL)]
        public uint ProcessLock { get => ReadHere<uint>(nameof(ProcessLock)); set => WriteHere(nameof(ProcessLock), value); }

        [Offset(68UL)]
        public uint ProcessTimerDelay { get => ReadHere<uint>(nameof(ProcessTimerDelay)); set => WriteHere(nameof(ProcessTimerDelay), value); }

        [Offset(72UL)]
        public ulong DeepFreezeStartTime { get => ReadHere<ulong>(nameof(DeepFreezeStartTime)); set => WriteHere(nameof(DeepFreezeStartTime), value); }

        [Offset(80UL)]
        public IntPtr Affinity { get => ReadHere<IntPtr>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(88UL)]
        public KabUmProcessContext AutoBoostState { get => ReadStructure<KabUmProcessContext>(nameof(AutoBoostState)); set => WriteStructure(nameof(AutoBoostState), value); }

        [Offset(104UL)]
        public ListEntry ReadyListHead { get => ReadStructure<ListEntry>(nameof(ReadyListHead)); set => WriteStructure(nameof(ReadyListHead), value); }

        [Offset(120UL)]
        public SingleListEntry SwapListEntry { get => ReadStructure<SingleListEntry>(nameof(SwapListEntry)); set => WriteStructure(nameof(SwapListEntry), value); }

        [Offset(128UL)]
        public IntPtr ActiveProcessors { get => ReadHere<IntPtr>(nameof(ActiveProcessors)); set => WriteHere(nameof(ActiveProcessors), value); }

        [Offset(136UL)]
        public uint AutoAlignment { get => ReadHere<uint>(nameof(AutoAlignment)); set => WriteHere(nameof(AutoAlignment), value); }

        [Offset(136UL)]
        public uint DisableBoost { get => ReadHere<uint>(nameof(DisableBoost)); set => WriteHere(nameof(DisableBoost), value); }

        [Offset(136UL)]
        public uint DisableQuantum { get => ReadHere<uint>(nameof(DisableQuantum)); set => WriteHere(nameof(DisableQuantum), value); }

        [Offset(136UL)]
        public uint DeepFreeze { get => ReadHere<uint>(nameof(DeepFreeze)); set => WriteHere(nameof(DeepFreeze), value); }

        [Offset(136UL)]
        public uint TimerVirtualization { get => ReadHere<uint>(nameof(TimerVirtualization)); set => WriteHere(nameof(TimerVirtualization), value); }

        [Offset(136UL)]
        public uint CheckStackExtents { get => ReadHere<uint>(nameof(CheckStackExtents)); set => WriteHere(nameof(CheckStackExtents), value); }

        [Offset(136UL)]
        public uint CacheIsolationEnabled { get => ReadHere<uint>(nameof(CacheIsolationEnabled)); set => WriteHere(nameof(CacheIsolationEnabled), value); }

        [Offset(136UL)]
        public uint PpmPolicy { get => ReadHere<uint>(nameof(PpmPolicy)); set => WriteHere(nameof(PpmPolicy), value); }

        [Offset(136UL)]
        public uint VaSpaceDeleted { get => ReadHere<uint>(nameof(VaSpaceDeleted)); set => WriteHere(nameof(VaSpaceDeleted), value); }

        [Offset(136UL)]
        public uint MultiGroup { get => ReadHere<uint>(nameof(MultiGroup)); set => WriteHere(nameof(MultiGroup), value); }

        [Offset(136UL)]
        public uint ForegroundProcess { get => ReadHere<uint>(nameof(ForegroundProcess)); set => WriteHere(nameof(ForegroundProcess), value); }

        [Offset(136UL)]
        public uint ReservedFlags { get => ReadHere<uint>(nameof(ReservedFlags)); set => WriteHere(nameof(ReservedFlags), value); }

        [Offset(136UL)]
        public int ProcessFlags { get => ReadHere<int>(nameof(ProcessFlags)); set => WriteHere(nameof(ProcessFlags), value); }

        [Offset(140UL)]
        public uint Spare0c { get => ReadHere<uint>(nameof(Spare0c)); set => WriteHere(nameof(Spare0c), value); }

        [Offset(144UL)]
        public sbyte BasePriority { get => ReadHere<sbyte>(nameof(BasePriority)); set => WriteHere(nameof(BasePriority), value); }

        [Offset(145UL)]
        public sbyte QuantumReset { get => ReadHere<sbyte>(nameof(QuantumReset)); set => WriteHere(nameof(QuantumReset), value); }

        [Offset(146UL)]
        public sbyte Visited { get => ReadHere<sbyte>(nameof(Visited)); set => WriteHere(nameof(Visited), value); }

        [Offset(147UL)]
        public KexecuteOptions Flags { get => ReadStructure<KexecuteOptions>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(152UL)]
        public KgroupMask ActiveGroupsMask { get => ReadStructure<KgroupMask>(nameof(ActiveGroupsMask)); set => WriteStructure(nameof(ActiveGroupsMask), value); }

        [Offset(168UL)]
        [Length(2)]
        public DynamicArray ActiveGroupPadding { get => ReadStructure<DynamicArray>(nameof(ActiveGroupPadding)); set => WriteStructure(nameof(ActiveGroupPadding), value); }

        [Offset(184UL)]
        public IntPtr IdealProcessorAssignmentBlock { get => ReadHere<IntPtr>(nameof(IdealProcessorAssignmentBlock)); set => WriteHere(nameof(IdealProcessorAssignmentBlock), value); }

        [Offset(192UL)]
        [Length(6)]
        public DynamicArray Padding { get => ReadStructure<DynamicArray>(nameof(Padding)); set => WriteStructure(nameof(Padding), value); }

        [Offset(240UL)]
        public uint Padding2 { get => ReadHere<uint>(nameof(Padding2)); set => WriteHere(nameof(Padding2), value); }

        [Offset(244UL)]
        public uint SchedulerAssistYieldBoostCount { get => ReadHere<uint>(nameof(SchedulerAssistYieldBoostCount)); set => WriteHere(nameof(SchedulerAssistYieldBoostCount), value); }

        [Offset(248UL)]
        public long SchedulerAssistYieldBoostAllowedTime { get => ReadHere<long>(nameof(SchedulerAssistYieldBoostAllowedTime)); set => WriteHere(nameof(SchedulerAssistYieldBoostAllowedTime), value); }

        [Offset(256UL)]
        public uint Spare0d { get => ReadHere<uint>(nameof(Spare0d)); set => WriteHere(nameof(Spare0d), value); }

        [Offset(260UL)]
        public ushort IdealGlobalNode { get => ReadHere<ushort>(nameof(IdealGlobalNode)); set => WriteHere(nameof(IdealGlobalNode), value); }

        [Offset(262UL)]
        public ushort Spare1 { get => ReadHere<ushort>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(264UL)]
        public KstackCount StackCount { get => ReadStructure<KstackCount>(nameof(StackCount)); set => WriteStructure(nameof(StackCount), value); }

        [Offset(272UL)]
        public ListEntry ProcessListEntry { get => ReadStructure<ListEntry>(nameof(ProcessListEntry)); set => WriteStructure(nameof(ProcessListEntry), value); }

        [Offset(288UL)]
        public ulong CycleTime { get => ReadHere<ulong>(nameof(CycleTime)); set => WriteHere(nameof(CycleTime), value); }

        [Offset(296UL)]
        public ulong ContextSwitches { get => ReadHere<ulong>(nameof(ContextSwitches)); set => WriteHere(nameof(ContextSwitches), value); }

        [Offset(304UL)]
        public IntPtr SchedulingGroup { get => ReadHere<IntPtr>(nameof(SchedulingGroup)); set => WriteHere(nameof(SchedulingGroup), value); }

        [Offset(312UL)]
        public ulong KernelTime { get => ReadHere<ulong>(nameof(KernelTime)); set => WriteHere(nameof(KernelTime), value); }

        [Offset(320UL)]
        public ulong UserTime { get => ReadHere<ulong>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(328UL)]
        public ulong ReadyTime { get => ReadHere<ulong>(nameof(ReadyTime)); set => WriteHere(nameof(ReadyTime), value); }

        [Offset(336UL)]
        public uint FreezeCount { get => ReadHere<uint>(nameof(FreezeCount)); set => WriteHere(nameof(FreezeCount), value); }

        [Offset(340UL)]
        public uint Spare4 { get => ReadHere<uint>(nameof(Spare4)); set => WriteHere(nameof(Spare4), value); }

        [Offset(344UL)]
        public ulong UserDirectoryTableBase { get => ReadHere<ulong>(nameof(UserDirectoryTableBase)); set => WriteHere(nameof(UserDirectoryTableBase), value); }

        [Offset(352UL)]
        public byte AddressPolicy { get => ReadHere<byte>(nameof(AddressPolicy)); set => WriteHere(nameof(AddressPolicy), value); }

        [Offset(353UL)]
        [Length(7)]
        public DynamicArray Spare2 { get => ReadStructure<DynamicArray>(nameof(Spare2)); set => WriteStructure(nameof(Spare2), value); }

        [Offset(360UL)]
        public IntPtr InstrumentationCallback { get => ReadHere<IntPtr>(nameof(InstrumentationCallback)); set => WriteHere(nameof(InstrumentationCallback), value); }

        [Offset(368UL)]
        public UnnamedTag SecureState { get => ReadStructure<UnnamedTag>(nameof(SecureState)); set => WriteStructure(nameof(SecureState), value); }

        [Offset(376UL)]
        public ulong KernelWaitTime { get => ReadHere<ulong>(nameof(KernelWaitTime)); set => WriteHere(nameof(KernelWaitTime), value); }

        [Offset(384UL)]
        public ulong UserWaitTime { get => ReadHere<ulong>(nameof(UserWaitTime)); set => WriteHere(nameof(UserWaitTime), value); }

        [Offset(392UL)]
        public ulong LastRebalanceQpc { get => ReadHere<ulong>(nameof(LastRebalanceQpc)); set => WriteHere(nameof(LastRebalanceQpc), value); }

        [Offset(400UL)]
        public IntPtr PerProcessorCycleTimes { get => ReadHere<IntPtr>(nameof(PerProcessorCycleTimes)); set => WriteHere(nameof(PerProcessorCycleTimes), value); }

        [Offset(408UL)]
        public ulong ExtendedFeatureDisableMask { get => ReadHere<ulong>(nameof(ExtendedFeatureDisableMask)); set => WriteHere(nameof(ExtendedFeatureDisableMask), value); }

        [Offset(416UL)]
        public ushort PrimaryGroup { get => ReadHere<ushort>(nameof(PrimaryGroup)); set => WriteHere(nameof(PrimaryGroup), value); }

        [Offset(418UL)]
        [Length(3)]
        public DynamicArray Spare3 { get => ReadStructure<DynamicArray>(nameof(Spare3)); set => WriteStructure(nameof(Spare3), value); }

        [Offset(424UL)]
        public IntPtr UserCetLogging { get => ReadHere<IntPtr>(nameof(UserCetLogging)); set => WriteHere(nameof(UserCetLogging), value); }

        [Offset(432UL)]
        public ListEntry CpuPartitionList { get => ReadStructure<ListEntry>(nameof(CpuPartitionList)); set => WriteStructure(nameof(CpuPartitionList), value); }

        [Offset(448UL)]
        public IntPtr AvailableCpuState { get => ReadHere<IntPtr>(nameof(AvailableCpuState)); set => WriteHere(nameof(AvailableCpuState), value); }

        public Kprocess(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kprocess>();
        }
    }
}