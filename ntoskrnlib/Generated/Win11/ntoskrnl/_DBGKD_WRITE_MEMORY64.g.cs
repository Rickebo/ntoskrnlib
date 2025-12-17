#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DBGKD_WRITE_MEMORY64
    {
        [FieldOffset(0)]
        public ulong TargetBaseAddress;
        [FieldOffset(8)]
        public uint TransferCount;
        [FieldOffset(12)]
        public uint ActualBytesWritten;
    }
}