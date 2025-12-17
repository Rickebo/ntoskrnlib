#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_SPLAY_LINKS
    {
        [FieldOffset(0)]
        public IntPtr Parent;
        [FieldOffset(8)]
        public IntPtr LeftChild;
        [FieldOffset(16)]
        public IntPtr RightChild;
    }
}