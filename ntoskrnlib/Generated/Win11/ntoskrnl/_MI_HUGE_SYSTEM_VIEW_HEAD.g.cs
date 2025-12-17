#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MI_HUGE_SYSTEM_VIEW_HEAD
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE ViewRoot;
        [FieldOffset(8)]
        public uint ViewCount;
        [FieldOffset(12)]
        public int Lock;
    }
}