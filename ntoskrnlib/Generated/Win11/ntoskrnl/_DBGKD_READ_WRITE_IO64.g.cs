#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DBGKD_READ_WRITE_IO64
    {
        [FieldOffset(0)]
        public ulong IoAddress;
        [FieldOffset(8)]
        public uint DataSize;
        [FieldOffset(12)]
        public uint DataValue;
    }
}