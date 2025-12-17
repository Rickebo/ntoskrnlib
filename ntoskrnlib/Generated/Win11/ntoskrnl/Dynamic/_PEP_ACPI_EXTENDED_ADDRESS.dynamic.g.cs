using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_EXTENDED_ADDRESS")]
    public sealed class _PEP_ACPI_EXTENDED_ADDRESS : DynamicStructure
    {
        public uint Type { get; }
        public _PEP_ACPI_RESOURCE_FLAGS Flags { get; }
        public byte ResourceFlags { get; }
        public byte GeneralFlags { get; }
        public byte TypeSpecificFlags { get; }
        public byte RevisionId { get; }
        public byte Reserved { get; }
        public ulong Granularity { get; }
        public ulong MinimumAddress { get; }
        public ulong MaximumAddress { get; }
        public ulong TranslationAddress { get; }
        public ulong AddressLength { get; }
        public ulong TypeAttribute { get; }
        public IntPtr DescriptorName { get; }

        public _PEP_ACPI_EXTENDED_ADDRESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_EXTENDED_ADDRESS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.ResourceFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.GeneralFlags),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.TypeSpecificFlags),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.RevisionId),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.Reserved),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.Granularity),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.MinimumAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.MaximumAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.TranslationAddress),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.AddressLength),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.TypeAttribute),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PEP_ACPI_EXTENDED_ADDRESS.DescriptorName),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_PEP_ACPI_EXTENDED_ADDRESS>((mem, ptr) => new _PEP_ACPI_EXTENDED_ADDRESS(mem, ptr), offsets);
        }
    }
}