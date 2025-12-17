using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_KSTACK_ALLOCATIONS")]
    public sealed class MiKstackAllocations : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray AllocationPeaks { get => ReadStructure<DynamicArray>(nameof(AllocationPeaks)); set => WriteStructure(nameof(AllocationPeaks), value); }

        public MiKstackAllocations(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiKstackAllocations>();
        }
    }
}