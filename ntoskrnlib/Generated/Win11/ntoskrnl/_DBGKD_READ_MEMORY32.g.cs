#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _DBGKD_READ_MEMORY32
    {
        [FieldOffset(0)]
        public uint TargetBaseAddress;
        [FieldOffset(4)]
        public uint TransferCount;
        [FieldOffset(8)]
        public uint ActualBytesRead;
    }
}