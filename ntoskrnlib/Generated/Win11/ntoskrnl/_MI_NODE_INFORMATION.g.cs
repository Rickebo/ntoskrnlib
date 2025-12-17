#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 57216)]
    public partial struct _MI_NODE_INFORMATION
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_NODE_FREE_PAGE_INFORMATION[] FreePageInfo;
        [FieldOffset(5120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] HotZeroedPageCountsByColor;
        [FieldOffset(5152)]
        public _MI_REBUILD_LARGE_PAGE_TIMER LargePageRebuildTimer;
        [FieldOffset(5192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] StandbyPageList;
        [FieldOffset(6656)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] StandbyPageCachePerChannel;
        [FieldOffset(14848)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_BITMAP_EX[] FreePageSListsBitmap;
        [FieldOffset(14880)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] FreePageSListsBitmapBuffer;
        [FieldOffset(14944)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] FreeZeroPageSlists;
        [FieldOffset(14960)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] TotalPages;
        [FieldOffset(14976)]
        public ulong TotalPagesEntireNode;
        [FieldOffset(14984)]
        public IntPtr Partition;
        [FieldOffset(14992)]
        public ulong TotalHugeIoPages;
        [FieldOffset(15000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] HugeIoRangeFreeCount;
        [FieldOffset(15040)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_BITMAP_EX[] FreeHugeRangeListHeadsBitmap;
        [FieldOffset(15072)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] FreeHugeRangeListHeadsBitmapBuffer;
        [FieldOffset(15136)]
        public _MI_HUGE_PFN_COLORHEAD BadHugeRangeListHead;
        [FieldOffset(15144)]
        public uint Color;
        [FieldOffset(15152)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] ChannelFreeCount;
        [FieldOffset(15184)]
        public _unnamed_tag_ Flags;
        [FieldOffset(15192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _MI_PAGE_MOVE_PROGRESS_STATE[] PageListMoveInProgress;
        [FieldOffset(15216)]
        public uint CurrentHugeRangeColor;
        [FieldOffset(15220)]
        public int NodeLock;
        [FieldOffset(15224)]
        public int ZeroThreadHugeMapLock;
        [FieldOffset(15228)]
        public int LargePageRebuildLock;
        [FieldOffset(15232)]
        public byte ChannelStatus;
        [FieldOffset(15233)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] ChannelOrdering;
        [FieldOffset(15235)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LockedChannelOrdering;
        [FieldOffset(15237)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PowerAttribute;
        [FieldOffset(15240)]
        public uint RollingKernelStackAllocationIndex;
        [FieldOffset(15248)]
        public ulong ScrubResumePage;
        [FieldOffset(15256)]
        public ulong NumberOfPagesGoingBad;
        [FieldOffset(15264)]
        public IntPtr BootZeroContext;
        [FieldOffset(15272)]
        public IntPtr ZeroingContext;
        [FieldOffset(15280)]
        public int ZeroContextLock;
        [FieldOffset(15288)]
        public IntPtr ZeroThreadConductor;
        [FieldOffset(15296)]
        public byte BackgroundZeroingActive;
        [FieldOffset(15304)]
        public IntPtr ZeroingPhysicalMemoryBlock;
        [FieldOffset(15312)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _CACHED_KSTACK_LIST[] CachedKernelStacks;
        [FieldOffset(15696)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public _MI_SLAB_ALLOCATOR_CONTEXT[] SlabContexts;
        [FieldOffset(17792)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] SlabStandbyListCaches;
        [FieldOffset(50560)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] SlabStandbyPageLists;
        [FieldOffset(56192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public _MMPFNLIST[] SlabRepurposedStandbyPageLists;
        [FieldOffset(56984)]
        public _RTL_BITMAP SlabTypeStandbyExistsBitmap;
        [FieldOffset(57000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] SlabTypeStandbyExistsBitmapBuffer;
        [FieldOffset(57008)]
        public IntPtr SlabIdentityState;
        [FieldOffset(57016)]
        public ulong MdlSlabFragmentionLastDemoteTime;
        [FieldOffset(57024)]
        public _MMPFNLIST EnclavePageListHead;
        [FieldOffset(57112)]
        public _MI_LARGE_PAGE_NODE_COALESCE_STATE LargePageCoalesceState;
    }
}