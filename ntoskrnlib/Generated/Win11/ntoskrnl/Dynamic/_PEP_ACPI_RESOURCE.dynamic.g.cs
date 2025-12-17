using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_RESOURCE")]
    public sealed class _PEP_ACPI_RESOURCE : DynamicStructure
    {
        public uint Type { get; }
        public _PEP_ACPI_IO_MEMORY_RESOURCE IoMemory { get; }
        public _PEP_ACPI_INTERRUPT_RESOURCE Interrupt { get; }
        public _PEP_ACPI_GPIO_RESOURCE Gpio { get; }
        public _PEP_ACPI_SPB_I2C_RESOURCE SpbI2c { get; }
        public _PEP_ACPI_SPB_SPI_RESOURCE SpbSpi { get; }
        public _PEP_ACPI_SPB_UART_RESOURCE SpbUart { get; }
        public _PEP_ACPI_EXTENDED_ADDRESS ExtendedAddress { get; }

        public _PEP_ACPI_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_RESOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.IoMemory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.Interrupt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.Gpio),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.SpbI2c),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.SpbSpi),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.SpbUart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE.ExtendedAddress),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PEP_ACPI_RESOURCE>((mem, ptr) => new _PEP_ACPI_RESOURCE(mem, ptr), offsets);
        }
    }
}