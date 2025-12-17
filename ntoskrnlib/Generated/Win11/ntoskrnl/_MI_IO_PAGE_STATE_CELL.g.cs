#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_IO_PAGE_STATE_CELL
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE PfnRoot;
        [FieldOffset(8)]
        public ulong UnmappedNodeCount;
        [FieldOffset(16)]
        public ulong UnmappedHugeIoSpaceNodeCount;
        [FieldOffset(24)]
        public ulong TotalNodeCount;
        [FieldOffset(32)]
        public ulong ResumePageForDeleteScans;
    }
}