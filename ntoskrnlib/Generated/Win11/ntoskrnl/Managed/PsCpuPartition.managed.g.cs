using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_CPU_PARTITION")]
    public sealed class PsCpuPartition : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(8UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(16UL)]
        public ListEntry PartitionListEntry { get => ReadStructure<ListEntry>(nameof(PartitionListEntry)); set => WriteStructure(nameof(PartitionListEntry), value); }

        public PsCpuPartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsCpuPartition>();
        }
    }
}