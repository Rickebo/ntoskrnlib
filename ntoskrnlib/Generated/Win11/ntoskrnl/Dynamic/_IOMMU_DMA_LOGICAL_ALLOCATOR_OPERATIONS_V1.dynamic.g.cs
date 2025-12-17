using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1")]
    public sealed class _IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1 : DynamicStructure
    {
        public IntPtr AllocateLogicalAddress { get; }
        public IntPtr FreeLogicalAddress { get; }
        public IntPtr ReserveLogicalAddress { get; }
        public IntPtr QueryCapabilities { get; }
        public IntPtr CleanUp { get; }

        public _IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1.AllocateLogicalAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1.FreeLogicalAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1.ReserveLogicalAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1.QueryCapabilities),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1.CleanUp),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1>((mem, ptr) => new _IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1(mem, ptr), offsets);
        }
    }
}