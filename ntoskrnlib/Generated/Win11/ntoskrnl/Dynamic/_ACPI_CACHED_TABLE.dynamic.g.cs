using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACPI_CACHED_TABLE")]
    public sealed class _ACPI_CACHED_TABLE : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public _LARGE_INTEGER PhysicalAddress { get; }
        public _DESCRIPTION_HEADER Header { get; }

        public _ACPI_CACHED_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACPI_CACHED_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACPI_CACHED_TABLE.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACPI_CACHED_TABLE.PhysicalAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ACPI_CACHED_TABLE.Header),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ACPI_CACHED_TABLE>((mem, ptr) => new _ACPI_CACHED_TABLE(mem, ptr), offsets);
        }
    }
}