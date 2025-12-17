using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG")]
    public sealed class _IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG : DynamicStructure
    {
        public uint LogicalAllocatorType { get; }
        public _unnamed_tag_ BuddyAllocatorConfig { get; }

        public _IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG.LogicalAllocatorType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG.BuddyAllocatorConfig),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG>((mem, ptr) => new _IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG(mem, ptr), offsets);
        }
    }
}