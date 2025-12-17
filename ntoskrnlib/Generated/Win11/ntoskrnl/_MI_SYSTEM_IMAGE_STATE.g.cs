#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 576)]
    public partial struct _MI_SYSTEM_IMAGE_STATE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY FixupList;
        [FieldOffset(16)]
        public IntPtr LoadLockOwner;
        [FieldOffset(24)]
        public uint LoadLockCount;
        [FieldOffset(28)]
        public int FixupLock;
        [FieldOffset(32)]
        public _EX_PUSH_LOCK EncodeDecodeLock;
        [FieldOffset(40)]
        public uint EncodeDecodeDepth;
        [FieldOffset(44)]
        public byte FirstLoadEver;
        [FieldOffset(45)]
        public byte SystemImagesLoaded;
        [FieldOffset(48)]
        public _LIST_ENTRY StrongCodeLoadFailureList;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] SystemBase;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _RTL_BITMAP_EX[] BaseImageDiscardedBitmaps;
        [FieldOffset(88)]
        public _EX_PUSH_LOCK MappingRangesPushLock;
        [FieldOffset(96)]
        public IntPtr MappingRanges;
        [FieldOffset(104)]
        public _MM_SYSTEM_PAGE_COUNTS PageCounts;
        [FieldOffset(120)]
        public _EX_PUSH_LOCK CollidedLock;
        [FieldOffset(128)]
        public _RTL_AVL_TREE ImageTree;
        [FieldOffset(136)]
        public _LIST_ENTRY LoadInProgress;
        [FieldOffset(152)]
        public ulong ImportEntriesReplaced;
        [FieldOffset(160)]
        public _EX_PUSH_LOCK SecurePteExclusionLock;
        [FieldOffset(168)]
        public IntPtr SecurePteExclusionBase;
        [FieldOffset(176)]
        public IntPtr SecurePteExclusionTop;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_CACHE_ALIGNED_ARRAY[] WorkingSetLockArray;
        [FieldOffset(448)]
        public _RTL_FUNCTION_OVERRIDE_CAPABILITIES FunctionOverrideCapabilities;
    }
}