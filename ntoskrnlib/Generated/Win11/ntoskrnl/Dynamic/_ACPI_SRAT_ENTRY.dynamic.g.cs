using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACPI_SRAT_ENTRY")]
    public sealed class _ACPI_SRAT_ENTRY : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public _unnamed_tag_ ApicAffinity { get; }
        public _unnamed_tag_ MemoryAffinity { get; }
        public _unnamed_tag_ X2ApicAffinity { get; }
        public _unnamed_tag_ GiccAffinity { get; }
        public _unnamed_tag_ GicItsAffinity { get; }
        public _unnamed_tag_ GenericInitiatorAffinity { get; }
        public _unnamed_tag_ GenericPortAffinity { get; }

        public _ACPI_SRAT_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACPI_SRAT_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACPI_SRAT_ENTRY.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.ApicAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.MemoryAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.X2ApicAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.GiccAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.GicItsAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.GenericInitiatorAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_SRAT_ENTRY.GenericPortAffinity),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_ACPI_SRAT_ENTRY>((mem, ptr) => new _ACPI_SRAT_ENTRY(mem, ptr), offsets);
        }
    }
}