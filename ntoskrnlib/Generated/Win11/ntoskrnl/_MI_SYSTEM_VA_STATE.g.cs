#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4160)]
    public partial struct _MI_SYSTEM_VA_STATE
    {
        [FieldOffset(0)]
        public int SystemTablesLock;
        [FieldOffset(8)]
        public ulong AvailableSystemCacheVa;
        [FieldOffset(16)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapKernelStacks;
        [FieldOffset(88)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapKernelShadowStacks;
        [FieldOffset(160)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapSystemPtes;
        [FieldOffset(232)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapNonCachedMappings;
        [FieldOffset(304)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapDriverImages;
        [FieldOffset(376)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapPagedPool;
        [FieldOffset(448)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapSystemCache;
        [FieldOffset(520)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapSystemDataViews;
        [FieldOffset(592)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapSecureNonPagedPool;
        [FieldOffset(664)]
        public IntPtr HalPrivateVaStart;
        [FieldOffset(672)]
        public ulong HalPrivateVaSize;
        [FieldOffset(680)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] SystemVaAssignment;
        [FieldOffset(712)]
        public uint SystemVaAssignmentHint;
        [FieldOffset(716)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] VaRegionShadowed;
        [FieldOffset(748)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] TopLevelPteLockBits;
        [FieldOffset(896)]
        public _MMSUPPORT_FULL SoftWsleSystemVm;
        [FieldOffset(1216)]
        public IntPtr HyperSpaceBase;
        [FieldOffset(1224)]
        public IntPtr PagableHyperSpace;
        [FieldOffset(1232)]
        public IntPtr HyperSpaceEnd;
        [FieldOffset(1240)]
        public IntPtr UserSoftWsleBase;
        [FieldOffset(1248)]
        public ulong PagableHyperSpaceBytes;
        [FieldOffset(1256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] PageTableCommitmentOffset;
        [FieldOffset(1272)]
        public int SystemCacheViewLock;
        [FieldOffset(1280)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public _MMWSL_INSTANCE[] SystemWorkingSetList;
        [FieldOffset(3840)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] SelfmapLock;
        [FieldOffset(3904)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_CACHE_ALIGNED_ARRAY[] SystemCacheWorkingSetLockArray;
    }
}