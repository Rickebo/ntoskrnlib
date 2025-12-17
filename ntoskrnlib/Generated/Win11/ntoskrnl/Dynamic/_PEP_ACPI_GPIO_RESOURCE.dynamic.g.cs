using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_GPIO_RESOURCE")]
    public sealed class _PEP_ACPI_GPIO_RESOURCE : DynamicStructure
    {
        public uint Type { get; }
        public _PEP_ACPI_RESOURCE_FLAGS Flags { get; }
        public uint InterruptType { get; }
        public uint InterruptPolarity { get; }
        public uint PinConfig { get; }
        public uint IoRestrictionType { get; }
        public ushort DriveStrength { get; }
        public ushort DebounceTimeout { get; }
        public IntPtr PinTable { get; }
        public ushort PinCount { get; }
        public byte ResourceSourceIndex { get; }
        public IntPtr ResourceSourceName { get; }
        public IntPtr VendorData { get; }
        public ushort VendorDataLength { get; }

        public _PEP_ACPI_GPIO_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_GPIO_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.InterruptType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.InterruptPolarity),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.PinConfig),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.IoRestrictionType),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.DriveStrength),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.DebounceTimeout),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.PinTable),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.PinCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.ResourceSourceIndex),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.ResourceSourceName),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.VendorData),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PEP_ACPI_GPIO_RESOURCE.VendorDataLength),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_PEP_ACPI_GPIO_RESOURCE>((mem, ptr) => new _PEP_ACPI_GPIO_RESOURCE(mem, ptr), offsets);
        }
    }
}