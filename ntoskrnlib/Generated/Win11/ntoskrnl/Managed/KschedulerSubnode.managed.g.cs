using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSCHEDULER_SUBNODE")]
    public sealed class KschedulerSubnode : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SubNodeLock { get => ReadHere<ulong>(nameof(SubNodeLock)); set => WriteHere(nameof(SubNodeLock), value); }

        [Offset(8UL)]
        public ulong IdleNonParkedCpuSet { get => ReadHere<ulong>(nameof(IdleNonParkedCpuSet)); set => WriteHere(nameof(IdleNonParkedCpuSet), value); }

        [Offset(16UL)]
        public ulong IdleCpuSet { get => ReadHere<ulong>(nameof(IdleCpuSet)); set => WriteHere(nameof(IdleCpuSet), value); }

        [Offset(24UL)]
        public ulong IdleSmtSet { get => ReadHere<ulong>(nameof(IdleSmtSet)); set => WriteHere(nameof(IdleSmtSet), value); }

        [Offset(32UL)]
        public ulong IdleModuleSet { get => ReadHere<ulong>(nameof(IdleModuleSet)); set => WriteHere(nameof(IdleModuleSet), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray IdleIsolationUnitSet { get => ReadStructure<DynamicArray>(nameof(IdleIsolationUnitSet)); set => WriteStructure(nameof(IdleIsolationUnitSet), value); }

        [Offset(40UL)]
        public ulong NonPairedSmtSet { get => ReadHere<ulong>(nameof(NonPairedSmtSet)); set => WriteHere(nameof(NonPairedSmtSet), value); }

        [Offset(48UL)]
        public ulong ThreadQosGroupingSet { get => ReadHere<ulong>(nameof(ThreadQosGroupingSet)); set => WriteHere(nameof(ThreadQosGroupingSet), value); }

        [Offset(56UL)]
        [Length(1)]
        public DynamicArray Spare1 { get => ReadStructure<DynamicArray>(nameof(Spare1)); set => WriteStructure(nameof(Spare1), value); }

        [Offset(64UL)]
        public ulong DeepIdleSet { get => ReadHere<ulong>(nameof(DeepIdleSet)); set => WriteHere(nameof(DeepIdleSet), value); }

        [Offset(72UL)]
        public ulong IdleConstrainedSet { get => ReadHere<ulong>(nameof(IdleConstrainedSet)); set => WriteHere(nameof(IdleConstrainedSet), value); }

        [Offset(80UL)]
        public ulong NonParkedSet { get => ReadHere<ulong>(nameof(NonParkedSet)); set => WriteHere(nameof(NonParkedSet), value); }

        [Offset(88UL)]
        public ulong ParkRequestSet { get => ReadHere<ulong>(nameof(ParkRequestSet)); set => WriteHere(nameof(ParkRequestSet), value); }

        [Offset(96UL)]
        public ulong SoftParkRequestSet { get => ReadHere<ulong>(nameof(SoftParkRequestSet)); set => WriteHere(nameof(SoftParkRequestSet), value); }

        [Offset(104UL)]
        public ulong ForceParkRequestSet { get => ReadHere<ulong>(nameof(ForceParkRequestSet)); set => WriteHere(nameof(ForceParkRequestSet), value); }

        [Offset(112UL)]
        public ulong NonIsrTargetedSet { get => ReadHere<ulong>(nameof(NonIsrTargetedSet)); set => WriteHere(nameof(NonIsrTargetedSet), value); }

        [Offset(120UL)]
        public int ParkLock { get => ReadHere<int>(nameof(ParkLock)); set => WriteHere(nameof(ParkLock), value); }

        [Offset(124UL)]
        public byte ProcessSeed { get => ReadHere<byte>(nameof(ProcessSeed)); set => WriteHere(nameof(ProcessSeed), value); }

        [Offset(125UL)]
        [Length(3)]
        public DynamicArray Spare5 { get => ReadStructure<DynamicArray>(nameof(Spare5)); set => WriteStructure(nameof(Spare5), value); }

        [Offset(128UL)]
        public GroupAffinity Affinity { get => ReadStructure<GroupAffinity>(nameof(Affinity)); set => WriteStructure(nameof(Affinity), value); }

        [Offset(128UL)]
        [Length(10)]
        public DynamicArray AffinityFill { get => ReadStructure<DynamicArray>(nameof(AffinityFill)); set => WriteStructure(nameof(AffinityFill), value); }

        [Offset(138UL)]
        public ushort ParentNodeNumber { get => ReadHere<ushort>(nameof(ParentNodeNumber)); set => WriteHere(nameof(ParentNodeNumber), value); }

        [Offset(140UL)]
        public ushort SubNodeNumber { get => ReadHere<ushort>(nameof(SubNodeNumber)); set => WriteHere(nameof(SubNodeNumber), value); }

        [Offset(142UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(144UL)]
        public ulong SiblingMask { get => ReadHere<ulong>(nameof(SiblingMask)); set => WriteHere(nameof(SiblingMask), value); }

        [Offset(152UL)]
        public ulong SharedReadyQueueMask { get => ReadHere<ulong>(nameof(SharedReadyQueueMask)); set => WriteHere(nameof(SharedReadyQueueMask), value); }

        [Offset(160UL)]
        public ulong StrideMask { get => ReadHere<ulong>(nameof(StrideMask)); set => WriteHere(nameof(StrideMask), value); }

        [Offset(168UL)]
        public ulong LLCLeaders { get => ReadHere<ulong>(nameof(LLCLeaders)); set => WriteHere(nameof(LLCLeaders), value); }

        [Offset(176UL)]
        public uint Lowest { get => ReadHere<uint>(nameof(Lowest)); set => WriteHere(nameof(Lowest), value); }

        [Offset(180UL)]
        public uint Highest { get => ReadHere<uint>(nameof(Highest)); set => WriteHere(nameof(Highest), value); }

        [Offset(184UL)]
        public Flags Flags { get => ReadStructure<Flags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(185UL)]
        public byte WorkloadClasses { get => ReadHere<byte>(nameof(WorkloadClasses)); set => WriteHere(nameof(WorkloadClasses), value); }

        [Offset(192UL)]
        public IntPtr HeteroSets { get => ReadHere<IntPtr>(nameof(HeteroSets)); set => WriteHere(nameof(HeteroSets), value); }

        [Offset(200UL)]
        public IntPtr PerformanceRanks { get => ReadHere<IntPtr>(nameof(PerformanceRanks)); set => WriteHere(nameof(PerformanceRanks), value); }

        [Offset(208UL)]
        public IntPtr EfficiencyRanks { get => ReadHere<IntPtr>(nameof(EfficiencyRanks)); set => WriteHere(nameof(EfficiencyRanks), value); }

        [Offset(216UL)]
        [Length(5)]
        public DynamicArray Spare6 { get => ReadStructure<DynamicArray>(nameof(Spare6)); set => WriteStructure(nameof(Spare6), value); }

        [Offset(256UL)]
        [Length(7)]
        public DynamicArray PpmConfiguredQosSets { get => ReadStructure<DynamicArray>(nameof(PpmConfiguredQosSets)); set => WriteStructure(nameof(PpmConfiguredQosSets), value); }

        [Offset(312UL)]
        public ulong Spare7 { get => ReadHere<ulong>(nameof(Spare7)); set => WriteHere(nameof(Spare7), value); }

        [Offset(320UL)]
        public KqosGroupingSets PpmQosGroupingSets { get => ReadStructure<KqosGroupingSets>(nameof(PpmQosGroupingSets)); set => WriteStructure(nameof(PpmQosGroupingSets), value); }

        [Offset(336UL)]
        [Length(6)]
        public DynamicArray Spare8 { get => ReadStructure<DynamicArray>(nameof(Spare8)); set => WriteStructure(nameof(Spare8), value); }

        [Offset(384UL)]
        public ulong StealableLocalReadyQueues { get => ReadHere<ulong>(nameof(StealableLocalReadyQueues)); set => WriteHere(nameof(StealableLocalReadyQueues), value); }

        [Offset(392UL)]
        public ulong StealableSharedReadyQueues { get => ReadHere<ulong>(nameof(StealableSharedReadyQueues)); set => WriteHere(nameof(StealableSharedReadyQueues), value); }

        [Offset(400UL)]
        public ulong StealableStandbyThreads { get => ReadHere<ulong>(nameof(StealableStandbyThreads)); set => WriteHere(nameof(StealableStandbyThreads), value); }

        [Offset(408UL)]
        [Length(5)]
        public DynamicArray Spare9 { get => ReadStructure<DynamicArray>(nameof(Spare9)); set => WriteStructure(nameof(Spare9), value); }

        [Offset(448UL)]
        public KrankList SoftParkRanks { get => ReadStructure<KrankList>(nameof(SoftParkRanks)); set => WriteStructure(nameof(SoftParkRanks), value); }

        [Offset(512UL)]
        public KrankList CoreShareCounts { get => ReadStructure<KrankList>(nameof(CoreShareCounts)); set => WriteStructure(nameof(CoreShareCounts), value); }

        [Offset(576UL)]
        public KrankList ModuleShareCounts { get => ReadStructure<KrankList>(nameof(ModuleShareCounts)); set => WriteStructure(nameof(ModuleShareCounts), value); }

        [Offset(640UL)]
        public KrankList ThreadQosGroupingCoreShareCounts { get => ReadStructure<KrankList>(nameof(ThreadQosGroupingCoreShareCounts)); set => WriteStructure(nameof(ThreadQosGroupingCoreShareCounts), value); }

        [Offset(704UL)]
        public KrankList ThreadQosGroupingModuleShareCounts { get => ReadStructure<KrankList>(nameof(ThreadQosGroupingModuleShareCounts)); set => WriteStructure(nameof(ThreadQosGroupingModuleShareCounts), value); }

        public KschedulerSubnode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KschedulerSubnode>();
        }
    }
}