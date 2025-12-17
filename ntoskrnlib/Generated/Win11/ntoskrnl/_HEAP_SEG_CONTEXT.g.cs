#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _HEAP_SEG_CONTEXT
    {
        [FieldOffset(0)]
        public ulong SegmentMask;
        [FieldOffset(8)]
        public byte UnitShift;
        [FieldOffset(9)]
        public byte PagesPerUnitShift;
        [FieldOffset(10)]
        public byte FirstDescriptorIndex;
        [FieldOffset(11)]
        public byte CachedCommitSoftShift;
        [FieldOffset(12)]
        public byte CachedCommitHighShift;
        [FieldOffset(13)]
        public _unnamed_tag_ Flags;
        [FieldOffset(16)]
        public uint MaxAllocationSize;
        [FieldOffset(20)]
        public short OlpStatsOffset;
        [FieldOffset(22)]
        public short MemStatsOffset;
        [FieldOffset(24)]
        public IntPtr LfhContext;
        [FieldOffset(32)]
        public IntPtr VsContext;
        [FieldOffset(40)]
        public RTL_HP_ENV_HANDLE EnvHandle;
        [FieldOffset(56)]
        public IntPtr Heap;
        [FieldOffset(64)]
        public ulong SegmentLock;
        [FieldOffset(72)]
        public _LIST_ENTRY SegmentListHead;
        [FieldOffset(88)]
        public ulong SegmentCount;
        [FieldOffset(96)]
        public _RTL_RB_TREE FreePageRanges;
        [FieldOffset(112)]
        public ulong FreeSegmentListLock;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _SINGLE_LIST_ENTRY[] FreeSegmentList;
    }
}