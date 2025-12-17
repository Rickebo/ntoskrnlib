using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_INTERRUPT_RESOURCE")]
    public sealed class _PEP_ACPI_INTERRUPT_RESOURCE : DynamicStructure
    {
        public uint Type { get; }
        public uint InterruptType { get; }
        public uint InterruptPolarity { get; }
        public _PEP_ACPI_RESOURCE_FLAGS Flags { get; }
        public byte Count { get; }
        public IntPtr Pins { get; }

        public _PEP_ACPI_INTERRUPT_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_INTERRUPT_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_INTERRUPT_RESOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_INTERRUPT_RESOURCE.InterruptType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEP_ACPI_INTERRUPT_RESOURCE.InterruptPolarity),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_ACPI_INTERRUPT_RESOURCE.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PEP_ACPI_INTERRUPT_RESOURCE.Count),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_ACPI_INTERRUPT_RESOURCE.Pins),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_PEP_ACPI_INTERRUPT_RESOURCE>((mem, ptr) => new _PEP_ACPI_INTERRUPT_RESOURCE(mem, ptr), offsets);
        }
    }
}