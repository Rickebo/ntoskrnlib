#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 344)]
    public partial struct _ARBITER_INSTANCE
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(8)]
        public IntPtr MutexEvent;
        [FieldOffset(16)]
        public IntPtr Name;
        [FieldOffset(24)]
        public IntPtr OrderingName;
        [FieldOffset(32)]
        public int ResourceType;
        [FieldOffset(40)]
        public IntPtr Allocation;
        [FieldOffset(48)]
        public IntPtr PossibleAllocation;
        [FieldOffset(56)]
        public _ARBITER_ORDERING_LIST OrderingList;
        [FieldOffset(72)]
        public _ARBITER_ORDERING_LIST ReservedList;
        [FieldOffset(88)]
        public int ReferenceCount;
        [FieldOffset(96)]
        public IntPtr Interface;
        [FieldOffset(104)]
        public uint AllocationStackMaxSize;
        [FieldOffset(112)]
        public IntPtr AllocationStack;
        [FieldOffset(120)]
        public IntPtr UnpackRequirement;
        [FieldOffset(128)]
        public IntPtr PackResource;
        [FieldOffset(136)]
        public IntPtr UnpackResource;
        [FieldOffset(144)]
        public IntPtr ScoreRequirement;
        [FieldOffset(152)]
        public IntPtr TestAllocation;
        [FieldOffset(160)]
        public IntPtr RetestAllocation;
        [FieldOffset(168)]
        public IntPtr CommitAllocation;
        [FieldOffset(176)]
        public IntPtr RollbackAllocation;
        [FieldOffset(184)]
        public IntPtr BootAllocation;
        [FieldOffset(192)]
        public IntPtr QueryArbitrate;
        [FieldOffset(200)]
        public IntPtr QueryConflict;
        [FieldOffset(208)]
        public IntPtr AddReserved;
        [FieldOffset(216)]
        public IntPtr StartArbiter;
        [FieldOffset(224)]
        public IntPtr PreprocessEntry;
        [FieldOffset(232)]
        public IntPtr AllocateEntry;
        [FieldOffset(240)]
        public IntPtr GetNextAllocationRange;
        [FieldOffset(248)]
        public IntPtr FindSuitableRange;
        [FieldOffset(256)]
        public IntPtr AddAllocation;
        [FieldOffset(264)]
        public IntPtr BacktrackAllocation;
        [FieldOffset(272)]
        public IntPtr OverrideConflict;
        [FieldOffset(280)]
        public IntPtr InitializeRangeList;
        [FieldOffset(288)]
        public IntPtr DeleteOwnerRanges;
        [FieldOffset(296)]
        public byte TransactionInProgress;
        [FieldOffset(304)]
        public IntPtr TransactionEvent;
        [FieldOffset(312)]
        public IntPtr Extension;
        [FieldOffset(320)]
        public IntPtr BusDeviceObject;
        [FieldOffset(328)]
        public IntPtr ConflictCallbackContext;
        [FieldOffset(336)]
        public IntPtr ConflictCallback;
    }
}