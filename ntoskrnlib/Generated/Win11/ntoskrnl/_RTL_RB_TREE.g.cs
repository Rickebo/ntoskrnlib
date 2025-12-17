#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTL_RB_TREE
    {
        [FieldOffset(0)]
        public IntPtr Root;
        [FieldOffset(8)]
        public byte Encoded;
        [FieldOffset(8)]
        public IntPtr Min;
    }
}