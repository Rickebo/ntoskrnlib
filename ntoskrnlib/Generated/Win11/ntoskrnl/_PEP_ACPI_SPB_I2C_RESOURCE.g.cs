#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _PEP_ACPI_SPB_I2C_RESOURCE
    {
        [FieldOffset(0)]
        public _PEP_ACPI_SPB_RESOURCE SpbCommon;
        [FieldOffset(40)]
        public uint ConnectionSpeed;
        [FieldOffset(44)]
        public ushort SlaveAddress;
    }
}