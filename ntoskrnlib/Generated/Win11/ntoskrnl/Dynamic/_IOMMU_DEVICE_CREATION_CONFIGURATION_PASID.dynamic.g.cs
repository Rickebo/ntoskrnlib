using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_CREATION_CONFIGURATION_PASID")]
    public sealed class _IOMMU_DEVICE_CREATION_CONFIGURATION_PASID : DynamicStructure
    {
        public uint ConfigType { get; }
        public byte SuppressPasidFaults { get; }

        public _IOMMU_DEVICE_CREATION_CONFIGURATION_PASID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DEVICE_CREATION_CONFIGURATION_PASID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION_PASID.ConfigType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION_PASID.SuppressPasidFaults),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IOMMU_DEVICE_CREATION_CONFIGURATION_PASID>((mem, ptr) => new _IOMMU_DEVICE_CREATION_CONFIGURATION_PASID(mem, ptr), offsets);
        }
    }
}