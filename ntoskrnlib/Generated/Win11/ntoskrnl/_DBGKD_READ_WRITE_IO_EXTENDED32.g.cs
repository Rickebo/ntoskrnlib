#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DBGKD_READ_WRITE_IO_EXTENDED32
    {
        [FieldOffset(0)]
        public uint DataSize;
        [FieldOffset(4)]
        public uint InterfaceType;
        [FieldOffset(8)]
        public uint BusNumber;
        [FieldOffset(12)]
        public uint AddressSpace;
        [FieldOffset(16)]
        public uint IoAddress;
        [FieldOffset(20)]
        public uint DataValue;
    }
}