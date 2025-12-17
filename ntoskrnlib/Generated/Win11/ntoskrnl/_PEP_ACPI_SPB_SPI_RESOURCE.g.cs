#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PEP_ACPI_SPB_SPI_RESOURCE
    {
        [FieldOffset(0)]
        public _PEP_ACPI_SPB_RESOURCE SpbCommon;
        [FieldOffset(40)]
        public uint ConnectionSpeed;
        [FieldOffset(44)]
        public byte DataBitLength;
        [FieldOffset(45)]
        public byte Phase;
        [FieldOffset(46)]
        public byte Polarity;
        [FieldOffset(48)]
        public ushort DeviceSelection;
    }
}