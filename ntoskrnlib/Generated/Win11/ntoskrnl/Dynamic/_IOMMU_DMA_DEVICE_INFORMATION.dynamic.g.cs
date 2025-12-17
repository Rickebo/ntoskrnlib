using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DEVICE_INFORMATION")]
    public sealed class _IOMMU_DMA_DEVICE_INFORMATION : DynamicStructure
    {
        public byte DefaultPasidEnabled { get; }
        public byte PasidTaggedDmaEnabled { get; }
        public byte PasidFaultsSuppressed { get; }

        public _IOMMU_DMA_DEVICE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_DEVICE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_DEVICE_INFORMATION.DefaultPasidEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE_INFORMATION.PasidTaggedDmaEnabled),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE_INFORMATION.PasidFaultsSuppressed),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_IOMMU_DMA_DEVICE_INFORMATION>((mem, ptr) => new _IOMMU_DMA_DEVICE_INFORMATION(mem, ptr), offsets);
        }
    }
}