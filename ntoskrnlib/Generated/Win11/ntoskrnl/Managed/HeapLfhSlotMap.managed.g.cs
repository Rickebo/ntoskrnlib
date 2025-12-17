using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SLOT_MAP")]
    public sealed class HeapLfhSlotMap : DynamicStructure
    {
        [Offset(0UL)]
        [Length(128)]
        public DynamicArray Map { get => ReadStructure<DynamicArray>(nameof(Map)); set => WriteStructure(nameof(Map), value); }

        public HeapLfhSlotMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhSlotMap>();
        }
    }
}