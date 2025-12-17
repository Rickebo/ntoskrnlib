using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_HEAP_POOL_NODE")]
    public sealed class ExHeapPoolNode : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray Heaps { get => ReadStructure<DynamicArray>(nameof(Heaps)); set => WriteStructure(nameof(Heaps), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray Lookasides { get => ReadStructure<DynamicArray>(nameof(Lookasides)); set => WriteStructure(nameof(Lookasides), value); }

        public ExHeapPoolNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExHeapPoolNode>();
        }
    }
}