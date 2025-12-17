using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN")]
    public sealed class _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN : DynamicStructure
    {
        public ulong LogicalAddressBase { get; }
        public ulong Size { get; }

        public _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN.LogicalAddressBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN.Size),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN>((mem, ptr) => new _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN(mem, ptr), offsets);
        }
    }
}