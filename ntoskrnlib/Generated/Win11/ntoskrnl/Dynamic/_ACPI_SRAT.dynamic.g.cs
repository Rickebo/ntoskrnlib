using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACPI_SRAT")]
    public sealed class _ACPI_SRAT : DynamicStructure
    {
        public _DESCRIPTION_HEADER Header { get; }
        public uint TableRevision { get; }
        public uint[] Reserved { get; }

        public _ACPI_SRAT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACPI_SRAT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACPI_SRAT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACPI_SRAT.TableRevision),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_ACPI_SRAT.Reserved),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_ACPI_SRAT>((mem, ptr) => new _ACPI_SRAT(mem, ptr), offsets);
        }
    }
}