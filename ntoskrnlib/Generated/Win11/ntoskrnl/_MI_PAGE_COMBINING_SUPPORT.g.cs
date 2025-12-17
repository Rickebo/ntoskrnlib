#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 400)]
    public partial struct _MI_PAGE_COMBINING_SUPPORT
    {
        [FieldOffset(0)]
        public IntPtr Partition;
        [FieldOffset(8)]
        public _LIST_ENTRY ArbitraryPfnMapList;
        [FieldOffset(24)]
        public _MI_COMBINE_WORKITEM FreeCombinePoolItem;
        [FieldOffset(64)]
        public uint CombiningThreadCount;
        [FieldOffset(72)]
        public _LIST_ENTRY CombinePageFreeList;
        [FieldOffset(88)]
        public int CombineFreeListLock;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _MI_COMBINE_PAGE_LISTHEAD[] CombinePageListHeads;
        [FieldOffset(352)]
        public ulong CommonPageCombineDomain;
        [FieldOffset(360)]
        public _MI_PAGE_COMBINE_STATISTICS PageCombineStats;
    }
}