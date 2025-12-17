using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PHYSICAL_MEMORY_RANGE")]
    public sealed class PhysicalMemoryRange : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger BaseAddress { get => ReadStructure<LargeInteger>(nameof(BaseAddress)); set => WriteStructure(nameof(BaseAddress), value); }

        [Offset(8UL)]
        public LargeInteger NumberOfBytes { get => ReadStructure<LargeInteger>(nameof(NumberOfBytes)); set => WriteStructure(nameof(NumberOfBytes), value); }

        public PhysicalMemoryRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PhysicalMemoryRange>();
        }
    }
}