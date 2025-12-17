using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID")]
    public sealed class _EXT_IOMMU_DEVICE_ID : DynamicStructure
    {
        public uint DeviceType { get; }
        public _EXT_IOMMU_DEVICE_ID_FLAGS Flags { get; }
        public _EXT_IOMMU_DEVICE_ID_PCI Pci { get; }
        public _EXT_IOMMU_DEVICE_ID_ACPI Acpi { get; }
        public byte IoApicId { get; }
        public ulong LogicalId { get; }
        public _EXT_IOMMU_DEVICE_ID_TEST Test { get; }

        public _EXT_IOMMU_DEVICE_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DEVICE_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.DeviceType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.Pci),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.Acpi),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.IoApicId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.LogicalId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID.Test),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXT_IOMMU_DEVICE_ID>((mem, ptr) => new _EXT_IOMMU_DEVICE_ID(mem, ptr), offsets);
        }
    }
}