using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_BLOCK_LIST")]
    public sealed class HeapLfhBlockList : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Next { get => ReadHere<ushort>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(2UL)]
        public ushort Count { get => ReadHere<ushort>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(0UL)]
        public HeapLfhBlockSlist SList { get => ReadStructure<HeapLfhBlockSlist>(nameof(SList)); set => WriteStructure(nameof(SList), value); }

        [Offset(0UL)]
        public uint ListFields { get => ReadHere<uint>(nameof(ListFields)); set => WriteHere(nameof(ListFields), value); }

        public HeapLfhBlockList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhBlockList>();
        }
    }
}