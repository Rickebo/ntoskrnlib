#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _HVP_VIEW_MAP
    {
        [FieldOffset(0)]
        public IntPtr SectionReference;
        [FieldOffset(8)]
        public long StorageEndFileOffset;
        [FieldOffset(16)]
        public long SectionEndFileOffset;
        [FieldOffset(24)]
        public IntPtr ProcessTuple;
        [FieldOffset(32)]
        public uint Flags;
        [FieldOffset(40)]
        public _RTL_RB_TREE ViewTree;
    }
}