using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_RESERVED_MEMORY_REGION")]
    public sealed class ExtIommuReservedMemoryRegion : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger Base { get => ReadStructure<LargeInteger>(nameof(Base)); set => WriteStructure(nameof(Base), value); }

        [Offset(8UL)]
        public LargeInteger Limit { get => ReadStructure<LargeInteger>(nameof(Limit)); set => WriteStructure(nameof(Limit), value); }

        [Offset(16UL)]
        public byte Ignored { get => ReadHere<byte>(nameof(Ignored)); set => WriteHere(nameof(Ignored), value); }

        public ExtIommuReservedMemoryRegion(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuReservedMemoryRegion>();
        }
    }
}