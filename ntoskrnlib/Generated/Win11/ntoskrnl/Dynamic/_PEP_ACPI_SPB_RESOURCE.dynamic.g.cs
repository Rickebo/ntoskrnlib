using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_RESOURCE")]
    public sealed class _PEP_ACPI_SPB_RESOURCE : DynamicStructure
    {
        public uint Type { get; }
        public _PEP_ACPI_RESOURCE_FLAGS Flags { get; }
        public ushort TypeSpecificFlags { get; }
        public byte ResourceSourceIndex { get; }
        public IntPtr ResourceSourceName { get; }
        public IntPtr VendorData { get; }
        public ushort VendorDataLength { get; }

        public _PEP_ACPI_SPB_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_SPB_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.TypeSpecificFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.ResourceSourceIndex),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.ResourceSourceName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.VendorData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_RESOURCE.VendorDataLength),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PEP_ACPI_SPB_RESOURCE>((mem, ptr) => new _PEP_ACPI_SPB_RESOURCE(mem, ptr), offsets);
        }
    }
}