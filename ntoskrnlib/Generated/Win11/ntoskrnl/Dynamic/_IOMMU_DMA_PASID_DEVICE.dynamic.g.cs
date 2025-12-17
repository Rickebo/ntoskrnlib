using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_PASID_DEVICE")]
    public sealed class _IOMMU_DMA_PASID_DEVICE : DynamicStructure
    {
        public _IOMMU_DMA_PASID_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_PASID_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_IOMMU_DMA_PASID_DEVICE>((mem, ptr) => new _IOMMU_DMA_PASID_DEVICE(mem, ptr), offsets);
        }
    }
}