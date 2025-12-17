using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_SPI_RESOURCE")]
    public sealed class _PEP_ACPI_SPB_SPI_RESOURCE : DynamicStructure
    {
        public _PEP_ACPI_SPB_RESOURCE SpbCommon { get; }
        public uint ConnectionSpeed { get; }
        public byte DataBitLength { get; }
        public byte Phase { get; }
        public byte Polarity { get; }
        public ushort DeviceSelection { get; }

        public _PEP_ACPI_SPB_SPI_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_SPB_SPI_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_SPB_SPI_RESOURCE.SpbCommon),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_SPI_RESOURCE.ConnectionSpeed),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_SPI_RESOURCE.DataBitLength),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_SPI_RESOURCE.Phase),
                    new ulong[]
                    {
                        45UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_SPI_RESOURCE.Polarity),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_SPI_RESOURCE.DeviceSelection),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PEP_ACPI_SPB_SPI_RESOURCE>((mem, ptr) => new _PEP_ACPI_SPB_SPI_RESOURCE(mem, ptr), offsets);
        }
    }
}