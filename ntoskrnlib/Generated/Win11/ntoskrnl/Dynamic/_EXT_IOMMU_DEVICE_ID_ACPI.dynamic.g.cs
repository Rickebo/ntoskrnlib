using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_ACPI")]
    public sealed class _EXT_IOMMU_DEVICE_ID_ACPI : DynamicStructure
    {
        public IntPtr ObjectName { get; }

        public _EXT_IOMMU_DEVICE_ID_ACPI(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DEVICE_ID_ACPI()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_ACPI.ObjectName),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_DEVICE_ID_ACPI>((mem, ptr) => new _EXT_IOMMU_DEVICE_ID_ACPI(mem, ptr), offsets);
        }
    }
}