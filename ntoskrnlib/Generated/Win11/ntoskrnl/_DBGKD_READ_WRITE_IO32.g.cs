#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _DBGKD_READ_WRITE_IO32
    {
        [FieldOffset(0)]
        public uint DataSize;
        [FieldOffset(4)]
        public uint IoAddress;
        [FieldOffset(8)]
        public uint DataValue;
    }
}