using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_IO_MEMORY_RESOURCE")]
    public sealed class _PEP_ACPI_IO_MEMORY_RESOURCE : DynamicStructure
    {
        public uint Type { get; }
        public byte Information { get; }
        public _LARGE_INTEGER MinimumAddress { get; }
        public _LARGE_INTEGER MaximumAddress { get; }
        public uint Alignment { get; }
        public uint Length { get; }

        public _PEP_ACPI_IO_MEMORY_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_IO_MEMORY_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_IO_MEMORY_RESOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_IO_MEMORY_RESOURCE.Information),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEP_ACPI_IO_MEMORY_RESOURCE.MinimumAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_ACPI_IO_MEMORY_RESOURCE.MaximumAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_ACPI_IO_MEMORY_RESOURCE.Alignment),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEP_ACPI_IO_MEMORY_RESOURCE.Length),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_PEP_ACPI_IO_MEMORY_RESOURCE>((mem, ptr) => new _PEP_ACPI_IO_MEMORY_RESOURCE(mem, ptr), offsets);
        }
    }
}