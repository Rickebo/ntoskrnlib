using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACPI_METHOD_ARGUMENT_V1")]
    public sealed class _ACPI_METHOD_ARGUMENT_V1 : DynamicStructure
    {
        public ushort Type { get; }
        public ushort DataLength { get; }
        public uint Argument { get; }
        public byte[] Data { get; }

        public _ACPI_METHOD_ARGUMENT_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACPI_METHOD_ARGUMENT_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACPI_METHOD_ARGUMENT_V1.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACPI_METHOD_ARGUMENT_V1.DataLength),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ACPI_METHOD_ARGUMENT_V1.Argument),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ACPI_METHOD_ARGUMENT_V1.Data),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_ACPI_METHOD_ARGUMENT_V1>((mem, ptr) => new _ACPI_METHOD_ARGUMENT_V1(mem, ptr), offsets);
        }
    }
}