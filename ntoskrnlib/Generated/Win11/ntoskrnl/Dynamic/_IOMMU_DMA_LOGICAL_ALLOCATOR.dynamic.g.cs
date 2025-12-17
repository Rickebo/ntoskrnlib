using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR")]
    public sealed class _IOMMU_DMA_LOGICAL_ALLOCATOR : DynamicStructure
    {
        public IntPtr Operations { get; }
        public uint Version { get; }
        public uint Size { get; }
        public uint AllocatorType { get; }

        public _IOMMU_DMA_LOGICAL_ALLOCATOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_LOGICAL_ALLOCATOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR.Operations),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR.Version),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR.Size),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR.AllocatorType),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_IOMMU_DMA_LOGICAL_ALLOCATOR>((mem, ptr) => new _IOMMU_DMA_LOGICAL_ALLOCATOR(mem, ptr), offsets);
        }
    }
}