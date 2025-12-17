using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_UART_RESOURCE")]
    public sealed class _PEP_ACPI_SPB_UART_RESOURCE : DynamicStructure
    {
        public _PEP_ACPI_SPB_RESOURCE SpbCommon { get; }
        public uint BaudRate { get; }
        public ushort RxBufferSize { get; }
        public ushort TxBufferSize { get; }
        public byte Parity { get; }
        public byte LinesInUse { get; }

        public _PEP_ACPI_SPB_UART_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_SPB_UART_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_SPB_UART_RESOURCE.SpbCommon),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_UART_RESOURCE.BaudRate),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_UART_RESOURCE.RxBufferSize),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_UART_RESOURCE.TxBufferSize),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_UART_RESOURCE.Parity),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_UART_RESOURCE.LinesInUse),
                    new ulong[]
                    {
                        49UL
                    }
                }
            };
            Register<_PEP_ACPI_SPB_UART_RESOURCE>((mem, ptr) => new _PEP_ACPI_SPB_UART_RESOURCE(mem, ptr), offsets);
        }
    }
}