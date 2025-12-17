#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MI_COMBINE_PAGE_LISTHEAD
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE Table;
        [FieldOffset(8)]
        public int Lock;
    }
}