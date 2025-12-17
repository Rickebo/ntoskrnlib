using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_REVERSE_MAP_VIEW_ATTRIBUTES")]
    public sealed class MiReverseMapViewAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public ulong FullSectionOffset { get => ReadHere<ulong>(nameof(FullSectionOffset)); set => WriteHere(nameof(FullSectionOffset), value); }

        [Offset(0UL)]
        public ulong NumberOfPtes { get => ReadHere<ulong>(nameof(NumberOfPtes)); set => WriteHere(nameof(NumberOfPtes), value); }

        [Offset(0UL)]
        public ulong PartitionId { get => ReadHere<ulong>(nameof(PartitionId)); set => WriteHere(nameof(PartitionId), value); }

        [Offset(0UL)]
        public ulong SectionOffset { get => ReadHere<ulong>(nameof(SectionOffset)); set => WriteHere(nameof(SectionOffset), value); }

        [Offset(0UL)]
        public ulong ViewState { get => ReadHere<ulong>(nameof(ViewState)); set => WriteHere(nameof(ViewState), value); }

        [Offset(0UL)]
        public ulong EntireField { get => ReadHere<ulong>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiReverseMapViewAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiReverseMapViewAttributes>();
        }
    }
}