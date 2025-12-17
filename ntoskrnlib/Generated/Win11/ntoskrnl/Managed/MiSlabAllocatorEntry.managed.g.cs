using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_ALLOCATOR_ENTRY")]
    public sealed class MiSlabAllocatorEntry : DynamicStructure
    {
        public MiSlabAllocatorEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSlabAllocatorEntry>();
        }
    }
}