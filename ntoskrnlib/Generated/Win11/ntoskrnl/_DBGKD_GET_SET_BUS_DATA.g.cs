#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _DBGKD_GET_SET_BUS_DATA
    {
        [FieldOffset(0)]
        public uint BusDataType;
        [FieldOffset(4)]
        public uint BusNumber;
        [FieldOffset(8)]
        public uint SlotNumber;
        [FieldOffset(12)]
        public uint Offset;
        [FieldOffset(16)]
        public uint Length;
    }
}