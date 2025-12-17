using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KNODE")]
    public sealed class Knode : DynamicStructure
    {
        [Offset(0UL)]
        public ushort NodeNumber { get => ReadHere<ushort>(nameof(NodeNumber)); set => WriteHere(nameof(NodeNumber), value); }

        [Offset(2UL)]
        public ushort PrimaryNodeNumber { get => ReadHere<ushort>(nameof(PrimaryNodeNumber)); set => WriteHere(nameof(PrimaryNodeNumber), value); }

        [Offset(4UL)]
        public uint ProximityId { get => ReadHere<uint>(nameof(ProximityId)); set => WriteHere(nameof(ProximityId), value); }

        [Offset(8UL)]
        public ushort MaximumProcessors { get => ReadHere<ushort>(nameof(MaximumProcessors)); set => WriteHere(nameof(MaximumProcessors), value); }

        [Offset(10UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(11UL)]
        public byte GroupSeed { get => ReadHere<byte>(nameof(GroupSeed)); set => WriteHere(nameof(GroupSeed), value); }

        [Offset(12UL)]
        public byte PrimaryGroup { get => ReadHere<byte>(nameof(PrimaryGroup)); set => WriteHere(nameof(PrimaryGroup), value); }

        [Offset(13UL)]
        [Length(3)]
        public DynamicArray Padding { get => ReadStructure<DynamicArray>(nameof(Padding)); set => WriteStructure(nameof(Padding), value); }

        [Offset(16UL)]
        public KgroupMask ActiveGroups { get => ReadStructure<KgroupMask>(nameof(ActiveGroups)); set => WriteStructure(nameof(ActiveGroups), value); }

        [Offset(32UL)]
        [Length(32)]
        public DynamicArray SchedulerSubNodes { get => ReadStructure<DynamicArray>(nameof(SchedulerSubNodes)); set => WriteStructure(nameof(SchedulerSubNodes), value); }

        [Offset(288UL)]
        [Length(5)]
        public DynamicArray ActiveTopologyElements { get => ReadStructure<DynamicArray>(nameof(ActiveTopologyElements)); set => WriteStructure(nameof(ActiveTopologyElements), value); }

        [Offset(308UL)]
        [Length(8)]
        public DynamicArray PerformanceSearchRanks { get => ReadStructure<DynamicArray>(nameof(PerformanceSearchRanks)); set => WriteStructure(nameof(PerformanceSearchRanks), value); }

        [Offset(564UL)]
        [Length(8)]
        public DynamicArray EfficiencySearchRanks { get => ReadStructure<DynamicArray>(nameof(EfficiencySearchRanks)); set => WriteStructure(nameof(EfficiencySearchRanks), value); }

        public Knode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Knode>();
        }
    }
}