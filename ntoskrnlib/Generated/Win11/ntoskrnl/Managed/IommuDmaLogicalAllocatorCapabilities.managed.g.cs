using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES")]
    public sealed class IommuDmaLogicalAllocatorCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public uint ExplicitAddressCapable { get => ReadHere<uint>(nameof(ExplicitAddressCapable)); set => WriteHere(nameof(ExplicitAddressCapable), value); }

        public IommuDmaLogicalAllocatorCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaLogicalAllocatorCapabilities>();
        }
    }
}