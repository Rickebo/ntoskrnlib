using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES")]
    public sealed class _IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES : DynamicStructure
    {
        public uint ExplicitAddressCapable { get; }

        public _IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES.ExplicitAddressCapable),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES>((mem, ptr) => new _IOMMU_DMA_LOGICAL_ALLOCATOR_CAPABILITIES(mem, ptr), offsets);
        }
    }
}