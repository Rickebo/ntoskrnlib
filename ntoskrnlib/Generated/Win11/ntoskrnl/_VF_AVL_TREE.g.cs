#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _VF_AVL_TREE
    {
        [FieldOffset(0)]
        public ulong NodeRangeSize;
        [FieldOffset(8)]
        public ulong NodeCount;
        [FieldOffset(16)]
        public IntPtr Tables;
        [FieldOffset(24)]
        public uint TablesNo;
        [FieldOffset(28)]
        public _unnamed_tag_ u1;
    }
}