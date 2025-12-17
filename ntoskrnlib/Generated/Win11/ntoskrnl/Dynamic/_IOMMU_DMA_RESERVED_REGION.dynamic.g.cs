using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_RESERVED_REGION")]
    public sealed class _IOMMU_DMA_RESERVED_REGION : DynamicStructure
    {
        public IntPtr RegionNext { get; }
        public ulong Base { get; }
        public ulong NumberOfPages { get; }
        public byte ShouldMap { get; }

        public _IOMMU_DMA_RESERVED_REGION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_RESERVED_REGION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_RESERVED_REGION.RegionNext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_RESERVED_REGION.Base),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_RESERVED_REGION.NumberOfPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_RESERVED_REGION.ShouldMap),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_IOMMU_DMA_RESERVED_REGION>((mem, ptr) => new _IOMMU_DMA_RESERVED_REGION(mem, ptr), offsets);
        }
    }
}