using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_NODE_IOMMU_EXTENSION")]
    public sealed class _DEVICE_NODE_IOMMU_EXTENSION : DynamicStructure
    {
        public _DEVICE_NODE_IOMMU_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_NODE_IOMMU_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_DEVICE_NODE_IOMMU_EXTENSION>((mem, ptr) => new _DEVICE_NODE_IOMMU_EXTENSION(mem, ptr), offsets);
        }
    }
}