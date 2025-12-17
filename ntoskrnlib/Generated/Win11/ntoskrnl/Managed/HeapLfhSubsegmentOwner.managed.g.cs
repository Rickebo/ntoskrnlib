using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT_OWNER")]
    public sealed class HeapLfhSubsegmentOwner : DynamicStructure
    {
        [Offset(0UL)]
        public byte IsBucket { get => ReadHere<byte>(nameof(IsBucket)); set => WriteHere(nameof(IsBucket), value); }

        [Offset(0UL)]
        public byte BucketIndex { get => ReadHere<byte>(nameof(BucketIndex)); set => WriteHere(nameof(BucketIndex), value); }

        [Offset(1UL)]
        public byte SlotCount { get => ReadHere<byte>(nameof(SlotCount)); set => WriteHere(nameof(SlotCount), value); }

        [Offset(1UL)]
        public byte AvailableSubsegmentCount { get => ReadHere<byte>(nameof(AvailableSubsegmentCount)); set => WriteHere(nameof(AvailableSubsegmentCount), value); }

        [Offset(2UL)]
        public ushort BucketRef { get => ReadHere<ushort>(nameof(BucketRef)); set => WriteHere(nameof(BucketRef), value); }

        [Offset(4UL)]
        public ushort PrivateSlotMapRef { get => ReadHere<ushort>(nameof(PrivateSlotMapRef)); set => WriteHere(nameof(PrivateSlotMapRef), value); }

        [Offset(6UL)]
        public ushort HeatMapRef { get => ReadHere<ushort>(nameof(HeatMapRef)); set => WriteHere(nameof(HeatMapRef), value); }

        [Offset(8UL)]
        public SingleListEntry OwnerFreeList { get => ReadStructure<SingleListEntry>(nameof(OwnerFreeList)); set => WriteStructure(nameof(OwnerFreeList), value); }

        [Offset(8UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(16UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(16UL)]
        public SingleListEntry SlotStandbyEntry { get => ReadStructure<SingleListEntry>(nameof(SlotStandbyEntry)); set => WriteStructure(nameof(SlotStandbyEntry), value); }

        [Offset(16UL)]
        public HeapLfhPtrrefList PrivSlotListEntry { get => ReadStructure<HeapLfhPtrrefList>(nameof(PrivSlotListEntry)); set => WriteStructure(nameof(PrivSlotListEntry), value); }

        [Offset(20UL)]
        public uint OwnerThreadId { get => ReadHere<uint>(nameof(OwnerThreadId)); set => WriteHere(nameof(OwnerThreadId), value); }

        [Offset(24UL)]
        public ListEntry AvailableSubsegmentList { get => ReadStructure<ListEntry>(nameof(AvailableSubsegmentList)); set => WriteStructure(nameof(AvailableSubsegmentList), value); }

        [Offset(40UL)]
        public ListEntry FullSubsegmentList { get => ReadStructure<ListEntry>(nameof(FullSubsegmentList)); set => WriteStructure(nameof(FullSubsegmentList), value); }

        public HeapLfhSubsegmentOwner(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhSubsegmentOwner>();
        }
    }
}