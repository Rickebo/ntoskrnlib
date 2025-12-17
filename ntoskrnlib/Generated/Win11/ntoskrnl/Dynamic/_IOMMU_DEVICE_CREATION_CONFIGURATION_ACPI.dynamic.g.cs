using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI")]
    public sealed class _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI : DynamicStructure
    {
        public uint InputMappingBase { get; }
        public uint MappingsCount { get; }

        public _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI.InputMappingBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI.MappingsCount),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI>((mem, ptr) => new _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI(mem, ptr), offsets);
        }
    }
}