#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _VF_AVL_TABLE
    {
        [FieldOffset(0)]
        public _RTL_AVL_TABLE RtlTable;
        [FieldOffset(104)]
        public IntPtr ReservedNode;
        [FieldOffset(112)]
        public IntPtr NodeToFree;
        [FieldOffset(128)]
        public int Lock;
        [FieldOffset(136)]
        public IntPtr ExclusiveOwnerThread;
    }
}