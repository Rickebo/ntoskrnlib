using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_I2C_RESOURCE")]
    public sealed class _PEP_ACPI_SPB_I2C_RESOURCE : DynamicStructure
    {
        public _PEP_ACPI_SPB_RESOURCE SpbCommon { get; }
        public uint ConnectionSpeed { get; }
        public ushort SlaveAddress { get; }

        public _PEP_ACPI_SPB_I2C_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_ACPI_SPB_I2C_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_ACPI_SPB_I2C_RESOURCE.SpbCommon),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_I2C_RESOURCE.ConnectionSpeed),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEP_ACPI_SPB_I2C_RESOURCE.SlaveAddress),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_PEP_ACPI_SPB_I2C_RESOURCE>((mem, ptr) => new _PEP_ACPI_SPB_I2C_RESOURCE(mem, ptr), offsets);
        }
    }
}