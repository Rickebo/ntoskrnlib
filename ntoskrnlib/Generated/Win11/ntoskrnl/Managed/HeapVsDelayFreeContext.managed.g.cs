using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_VS_DELAY_FREE_CONTEXT")]
    public sealed class HeapVsDelayFreeContext : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader ListHead { get => ReadStructure<SlistHeader>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        public HeapVsDelayFreeContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVsDelayFreeContext>();
        }
    }
}