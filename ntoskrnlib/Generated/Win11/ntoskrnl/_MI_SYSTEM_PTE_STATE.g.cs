#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 5376)]
    public partial struct _MI_SYSTEM_PTE_STATE
    {
        [FieldOffset(0)]
        public _NPAGED_LOOKASIDE_LIST MdlTrackerLookaside;
        [FieldOffset(128)]
        public _SLIST_HEADER DeadPteTrackerSListHead;
        [FieldOffset(144)]
        public int PteTrackerLock;
        [FieldOffset(152)]
        public IntPtr CachedPteHeads;
        [FieldOffset(160)]
        public _MI_SYSTEM_PTE_TYPE SystemViewPteInfo;
        [FieldOffset(256)]
        public _MI_SYSTEM_PTE_TYPE NonCachedMappingsPteInfo;
        [FieldOffset(352)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _MI_SYSTEM_PTE_TYPE[] KernelStackPteInfo;
        [FieldOffset(544)]
        public uint StackGrowthFailures;
        [FieldOffset(548)]
        public byte KernelStackPages;
        [FieldOffset(549)]
        public byte TrackPtesAborted;
        [FieldOffset(550)]
        public byte AdjustCounter;
        [FieldOffset(552)]
        public int ReservedMappingLock;
        [FieldOffset(560)]
        public _RTL_AVL_TREE ReservedMappingTree;
        [FieldOffset(568)]
        public _MI_PAGE_CHAIN_HEAD ReservedMappingPageTablePfns;
        [FieldOffset(592)]
        public _RTL_AVL_TREE OutswappedKernelStackRoot;
        [FieldOffset(600)]
        public int OutswappedKernelStackLock;
        [FieldOffset(608)]
        public _MI_ULTRA_VA_CONTEXT UltraSpaceContext;
        [FieldOffset(672)]
        public uint NumberOfUltraMdlMaps;
        [FieldOffset(680)]
        public IntPtr UltraMdlNodeMappings;
        [FieldOffset(688)]
        public IntPtr UltraSpaceLowPpe;
        [FieldOffset(696)]
        public IntPtr UltraSpaceHighPpe;
        [FieldOffset(704)]
        public _EX_PUSH_LOCK SystemSpaceViewLock;
        [FieldOffset(712)]
        public _RTL_AVL_TREE ViewRoot;
        [FieldOffset(720)]
        public uint ViewCount;
        [FieldOffset(768)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_CACHE_ALIGNED_ARRAY[] WorkingSetLockArray;
        [FieldOffset(1024)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_CACHE_ALIGNED_ARRAY[] SystemDataViewsWorkingSetLockArray;
        [FieldOffset(1280)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _MI_HUGE_SYSTEM_VIEW_HEAD[] SystemViewBuckets;
    }
}