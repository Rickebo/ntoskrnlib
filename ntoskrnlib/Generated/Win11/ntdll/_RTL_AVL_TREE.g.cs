#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_AVL_TREE
    {
        [FieldOffset(0)]
        public IntPtr Root;
    }
}