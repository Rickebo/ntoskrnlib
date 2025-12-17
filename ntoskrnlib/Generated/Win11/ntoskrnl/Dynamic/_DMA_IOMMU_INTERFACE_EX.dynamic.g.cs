using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE_EX")]
    public sealed class _DMA_IOMMU_INTERFACE_EX : DynamicStructure
    {
        public ulong Size { get; }
        public uint Version { get; }
        public _DMA_IOMMU_INTERFACE_V1 V1 { get; }
        public _DMA_IOMMU_INTERFACE_V2 V2 { get; }
        public _DMA_IOMMU_INTERFACE_V3 V3 { get; }

        public _DMA_IOMMU_INTERFACE_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_IOMMU_INTERFACE_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_IOMMU_INTERFACE_EX.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_EX.Version),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_EX.V1),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_EX.V2),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_EX.V3),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DMA_IOMMU_INTERFACE_EX>((mem, ptr) => new _DMA_IOMMU_INTERFACE_EX(mem, ptr), offsets);
        }
    }
}