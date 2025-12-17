using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_SPI_RESOURCE")]
    public sealed class PepAcpiSpbSpiResource : DynamicStructure
    {
        [Offset(0UL)]
        public PepAcpiSpbResource SpbCommon { get => ReadStructure<PepAcpiSpbResource>(nameof(SpbCommon)); set => WriteStructure(nameof(SpbCommon), value); }

        [Offset(40UL)]
        public uint ConnectionSpeed { get => ReadHere<uint>(nameof(ConnectionSpeed)); set => WriteHere(nameof(ConnectionSpeed), value); }

        [Offset(44UL)]
        public byte DataBitLength { get => ReadHere<byte>(nameof(DataBitLength)); set => WriteHere(nameof(DataBitLength), value); }

        [Offset(45UL)]
        public byte Phase { get => ReadHere<byte>(nameof(Phase)); set => WriteHere(nameof(Phase), value); }

        [Offset(46UL)]
        public byte Polarity { get => ReadHere<byte>(nameof(Polarity)); set => WriteHere(nameof(Polarity), value); }

        [Offset(48UL)]
        public ushort DeviceSelection { get => ReadHere<ushort>(nameof(DeviceSelection)); set => WriteHere(nameof(DeviceSelection), value); }

        public PepAcpiSpbSpiResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiSpbSpiResource>();
        }
    }
}