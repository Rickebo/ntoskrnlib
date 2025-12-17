#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _VF_AVL_TREE_NODE
    {
        [FieldOffset(0)]
        public IntPtr p;
        [FieldOffset(8)]
        public ulong RangeSize;
    }
}