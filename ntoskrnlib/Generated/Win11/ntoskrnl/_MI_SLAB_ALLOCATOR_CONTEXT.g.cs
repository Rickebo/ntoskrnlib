#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 232)]
    public partial struct _MI_SLAB_ALLOCATOR_CONTEXT
    {
        [FieldOffset(0)]
        public _RTL_RB_TREE SlabTree;
        [FieldOffset(16)]
        public int Lock;
        [FieldOffset(24)]
        public IntPtr Partition;
        [FieldOffset(32)]
        public _unnamed_tag_ Hints;
        [FieldOffset(64)]
        public IntPtr StandbyPageCache;
        [FieldOffset(72)]
        public IntPtr StandbyPageList;
        [FieldOffset(80)]
        public IntPtr RepurposedStandbyPageList;
        [FieldOffset(88)]
        public IntPtr SlabListsByIdentity;
        [FieldOffset(96)]
        public ulong FreePageCount;
        [FieldOffset(104)]
        public ulong AvailablePagesGoal;
        [FieldOffset(112)]
        public ulong ChargedPageCount;
        [FieldOffset(120)]
        public ulong SlabEntryCount;
        [FieldOffset(128)]
        public uint Type;
        [FieldOffset(132)]
        public _MI_NODE_NUMBER_ZERO_BASED NumaNodeIndex;
        [FieldOffset(136)]
        public _unnamed_tag_ Flags;
        [FieldOffset(140)]
        public int ReEvaluateAllocationHint;
        [FieldOffset(144)]
        public uint SlabEntriesAllocated;
        [FieldOffset(148)]
        public uint SlabEntriesDemoted;
        [FieldOffset(152)]
        public uint SlabEntriesFailedFast;
        [FieldOffset(156)]
        public uint SlabEntriesFailedSlow;
        [FieldOffset(160)]
        public uint SlabPagesFreedNonZeroed;
        [FieldOffset(164)]
        public uint SlabPagesCrossIdentity;
        [FieldOffset(168)]
        public ulong LastReplenishTime;
        [FieldOffset(176)]
        public ulong LastFailureTime;
        [FieldOffset(184)]
        public _WORK_QUEUE_ITEM ReplenishWorkItem;
        [FieldOffset(216)]
        public _LIST_ENTRY ReplenishWaitList;
    }
}