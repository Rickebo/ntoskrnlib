using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_CREATION_CONFIGURATION")]
    public sealed class _IOMMU_DEVICE_CREATION_CONFIGURATION : DynamicStructure
    {
        public _LIST_ENTRY NextConfiguration { get; }
        public uint ConfigType { get; }
        public _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI Acpi { get; }
        public IntPtr DeviceId { get; }
        public _IOMMU_DEVICE_CREATION_CONFIGURATION_PASID Pasid { get; }

        public _IOMMU_DEVICE_CREATION_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DEVICE_CREATION_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION.NextConfiguration),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION.ConfigType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION.Acpi),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION.DeviceId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION.Pasid),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_IOMMU_DEVICE_CREATION_CONFIGURATION>((mem, ptr) => new _IOMMU_DEVICE_CREATION_CONFIGURATION(mem, ptr), offsets);
        }
    }
}