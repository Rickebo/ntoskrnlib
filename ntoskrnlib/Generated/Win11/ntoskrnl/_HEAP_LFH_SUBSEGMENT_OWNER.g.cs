#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _HEAP_LFH_SUBSEGMENT_OWNER
    {
        [FieldOffset(0)]
        public byte IsBucket;
        [FieldOffset(0)]
        public byte BucketIndex;
        [FieldOffset(1)]
        public byte SlotCount;
        [FieldOffset(1)]
        public byte AvailableSubsegmentCount;
        [FieldOffset(2)]
        public ushort BucketRef;
        [FieldOffset(4)]
        public ushort PrivateSlotMapRef;
        [FieldOffset(6)]
        public ushort HeatMapRef;
        [FieldOffset(8)]
        public _SINGLE_LIST_ENTRY OwnerFreeList;
        [FieldOffset(8)]
        public ushort Spare;
        [FieldOffset(16)]
        public ulong Lock;
        [FieldOffset(16)]
        public _SINGLE_LIST_ENTRY SlotStandbyEntry;
        [FieldOffset(16)]
        public _HEAP_LFH_PTRREF_LIST PrivSlotListEntry;
        [FieldOffset(20)]
        public uint OwnerThreadId;
        [FieldOffset(24)]
        public _LIST_ENTRY AvailableSubsegmentList;
        [FieldOffset(40)]
        public _LIST_ENTRY FullSubsegmentList;
    }
}