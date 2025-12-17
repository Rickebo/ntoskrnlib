#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_RUN_ONCE
    {
        [FieldOffset(0)]
        public IntPtr Ptr;
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public ulong State;
    }
}