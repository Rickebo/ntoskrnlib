using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT")]
    public sealed class HeapLfhSubsegment : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public HeapLfhSubsegmentState State { get => ReadStructure<HeapLfhSubsegmentState>(nameof(State)); set => WriteStructure(nameof(State), value); }

        [Offset(24UL)]
        public SingleListEntry OwnerFreeListEntry { get => ReadStructure<SingleListEntry>(nameof(OwnerFreeListEntry)); set => WriteStructure(nameof(OwnerFreeListEntry), value); }

        [Offset(24UL)]
        public byte CommitStateOffset { get => ReadHere<byte>(nameof(CommitStateOffset)); set => WriteHere(nameof(CommitStateOffset), value); }

        [Offset(25UL)]
        public byte Spare0 { get => ReadHere<byte>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(32UL)]
        public ushort FreeCount { get => ReadHere<ushort>(nameof(FreeCount)); set => WriteHere(nameof(FreeCount), value); }

        [Offset(34UL)]
        public ushort BlockCount { get => ReadHere<ushort>(nameof(BlockCount)); set => WriteHere(nameof(BlockCount), value); }

        [Offset(36UL)]
        public byte FreeHint { get => ReadHere<byte>(nameof(FreeHint)); set => WriteHere(nameof(FreeHint), value); }

        [Offset(37UL)]
        public byte WitheldBlockCount { get => ReadHere<byte>(nameof(WitheldBlockCount)); set => WriteHere(nameof(WitheldBlockCount), value); }

        [Offset(38UL)]
        public byte CommitUnitShift { get => ReadHere<byte>(nameof(CommitUnitShift)); set => WriteHere(nameof(CommitUnitShift), value); }

        [Offset(39UL)]
        public byte CommitUnitCount { get => ReadHere<byte>(nameof(CommitUnitCount)); set => WriteHere(nameof(CommitUnitCount), value); }

        [Offset(38UL)]
        public HeapLfhCommitUnitInfo CommitUnitInfo { get => ReadStructure<HeapLfhCommitUnitInfo>(nameof(CommitUnitInfo)); set => WriteStructure(nameof(CommitUnitInfo), value); }

        [Offset(40UL)]
        public HeapLfhSubsegmentEncodedOffsets BlockOffsets { get => ReadStructure<HeapLfhSubsegmentEncodedOffsets>(nameof(BlockOffsets)); set => WriteStructure(nameof(BlockOffsets), value); }

        [Offset(44UL)]
        public ushort BucketRef { get => ReadHere<ushort>(nameof(BucketRef)); set => WriteHere(nameof(BucketRef), value); }

        [Offset(46UL)]
        public ushort PrivateSlotMapRef { get => ReadHere<ushort>(nameof(PrivateSlotMapRef)); set => WriteHere(nameof(PrivateSlotMapRef), value); }

        [Offset(48UL)]
        public ushort HighWatermarkBlockIndex { get => ReadHere<ushort>(nameof(HighWatermarkBlockIndex)); set => WriteHere(nameof(HighWatermarkBlockIndex), value); }

        [Offset(50UL)]
        public byte BitmapSearchWidth { get => ReadHere<byte>(nameof(BitmapSearchWidth)); set => WriteHere(nameof(BitmapSearchWidth), value); }

        [Offset(51UL)]
        public byte PrivateFormat { get => ReadHere<byte>(nameof(PrivateFormat)); set => WriteHere(nameof(PrivateFormat), value); }

        [Offset(51UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(51UL)]
        public HeapLfhSubsegmentUcharFields UChar { get => ReadStructure<HeapLfhSubsegmentUcharFields>(nameof(UChar)); set => WriteStructure(nameof(UChar), value); }

        [Offset(52UL)]
        public uint Spare3 { get => ReadHere<uint>(nameof(Spare3)); set => WriteHere(nameof(Spare3), value); }

        [Offset(56UL)]
        public ulong CommitLock { get => ReadHere<ulong>(nameof(CommitLock)); set => WriteHere(nameof(CommitLock), value); }

        [Offset(64UL)]
        [Length(1)]
        public DynamicArray BlockBitmap { get => ReadStructure<DynamicArray>(nameof(BlockBitmap)); set => WriteStructure(nameof(BlockBitmap), value); }

        public HeapLfhSubsegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhSubsegment>();
        }
    }
}