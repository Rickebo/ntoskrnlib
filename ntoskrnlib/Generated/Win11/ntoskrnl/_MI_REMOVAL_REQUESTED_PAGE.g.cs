#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_REMOVAL_REQUESTED_PAGE
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE TreeNode;
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(24)]
        public IntPtr Pfn;
    }
}