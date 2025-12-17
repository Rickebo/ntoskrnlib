using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_RESOURCE_FLAGS")]
    public sealed class _PEP_ACPI_RESOURCE_FLAGS : DynamicStructure
    {
        public uint AsULong { get; }
        public uint Shared { get; }
        public uint Wake { get; }
        public uint ResourceUsage { get; }
        public uint SlaveMode { get; }
        public uint AddressingMode { get; }
        public uint SharedMode { get; }
        public uint Reserved { get; }

        public _PEP_ACPI_RESOURCE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_RESOURCE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.AsULong),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.Shared),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.Wake),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.ResourceUsage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.SlaveMode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.AddressingMode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.SharedMode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_RESOURCE_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PEP_ACPI_RESOURCE_FLAGS>((mem, ptr) => new _PEP_ACPI_RESOURCE_FLAGS(mem, ptr), offsets);
        }
    }
}