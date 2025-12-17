#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _MI_IO_PAGE_STATE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _MI_IO_PAGE_STATE_CELL[] TypeCell;
        [FieldOffset(128)]
        public _RTL_AVL_TREE InvariantIoSpace;
        [FieldOffset(136)]
        public _RTL_AVL_TREE ExclusionSpace;
        [FieldOffset(144)]
        public int IoPfnPruneLock;
        [FieldOffset(152)]
        public _WORK_QUEUE_ITEM UnmappedNodeWorkItem;
        [FieldOffset(184)]
        public _MI_IO_CACHE_STATS IoCacheStats;
    }
}