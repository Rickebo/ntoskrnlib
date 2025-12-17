using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_I2C_RESOURCE")]
    public sealed class PepAcpiSpbI2CResource : DynamicStructure
    {
        [Offset(0UL)]
        public PepAcpiSpbResource SpbCommon { get => ReadStructure<PepAcpiSpbResource>(nameof(SpbCommon)); set => WriteStructure(nameof(SpbCommon), value); }

        [Offset(40UL)]
        public uint ConnectionSpeed { get => ReadHere<uint>(nameof(ConnectionSpeed)); set => WriteHere(nameof(ConnectionSpeed), value); }

        [Offset(44UL)]
        public ushort SlaveAddress { get => ReadHere<ushort>(nameof(SlaveAddress)); set => WriteHere(nameof(SlaveAddress), value); }

        public PepAcpiSpbI2CResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiSpbI2CResource>();
        }
    }
}