#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_ACCESS_VIOLATION_RANGE
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE Node;
        [FieldOffset(24)]
        public IntPtr Va;
        [FieldOffset(32)]
        public IntPtr EndVaInclusive;
    }
}