#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _IO_STATUS_BLOCK
    {
        [FieldOffset(0)]
        public int Status;
        [FieldOffset(0)]
        public IntPtr Pointer;
        [FieldOffset(8)]
        public ulong Information;
    }
}