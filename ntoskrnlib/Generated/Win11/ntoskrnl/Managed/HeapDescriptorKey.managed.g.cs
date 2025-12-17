using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_DESCRIPTOR_KEY")]
    public sealed class HeapDescriptorKey : DynamicStructure
    {
        [Offset(0UL)]
        public uint Key { get => ReadHere<uint>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(0UL)]
        public uint EncodedCommittedPageCount { get => ReadHere<uint>(nameof(EncodedCommittedPageCount)); set => WriteHere(nameof(EncodedCommittedPageCount), value); }

        [Offset(0UL)]
        public uint LargePageCost { get => ReadHere<uint>(nameof(LargePageCost)); set => WriteHere(nameof(LargePageCost), value); }

        [Offset(0UL)]
        public uint UnitCount { get => ReadHere<uint>(nameof(UnitCount)); set => WriteHere(nameof(UnitCount), value); }

        public HeapDescriptorKey(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapDescriptorKey>();
        }
    }
}