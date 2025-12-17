using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DOMAIN_CREATION_FLAGS")]
    public sealed class _IOMMU_DMA_DOMAIN_CREATION_FLAGS : DynamicStructure
    {
        public ulong Reserved { get; }
        public ulong AsUlonglong { get; }

        public _IOMMU_DMA_DOMAIN_CREATION_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_DOMAIN_CREATION_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_DOMAIN_CREATION_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN_CREATION_FLAGS.AsUlonglong),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IOMMU_DMA_DOMAIN_CREATION_FLAGS>((mem, ptr) => new _IOMMU_DMA_DOMAIN_CREATION_FLAGS(mem, ptr), offsets);
        }
    }
}