using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_SEGMENT")]
    public sealed class HeapSegment : DynamicStructure
    {
        [Offset(0UL)]
        public HeapEntry Entry { get => ReadStructure<HeapEntry>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        [Offset(16UL)]
        public uint SegmentSignature { get => ReadHere<uint>(nameof(SegmentSignature)); set => WriteHere(nameof(SegmentSignature), value); }

        [Offset(20UL)]
        public uint SegmentFlags { get => ReadHere<uint>(nameof(SegmentFlags)); set => WriteHere(nameof(SegmentFlags), value); }

        [Offset(24UL)]
        public ListEntry SegmentListEntry { get => ReadStructure<ListEntry>(nameof(SegmentListEntry)); set => WriteStructure(nameof(SegmentListEntry), value); }

        [Offset(40UL)]
        public IntPtr Heap { get => ReadHere<IntPtr>(nameof(Heap)); set => WriteHere(nameof(Heap), value); }

        [Offset(48UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(56UL)]
        public uint NumberOfPages { get => ReadHere<uint>(nameof(NumberOfPages)); set => WriteHere(nameof(NumberOfPages), value); }

        [Offset(64UL)]
        public IntPtr FirstEntry { get => ReadHere<IntPtr>(nameof(FirstEntry)); set => WriteHere(nameof(FirstEntry), value); }

        [Offset(72UL)]
        public IntPtr LastValidEntry { get => ReadHere<IntPtr>(nameof(LastValidEntry)); set => WriteHere(nameof(LastValidEntry), value); }

        [Offset(80UL)]
        public uint NumberOfUnCommittedPages { get => ReadHere<uint>(nameof(NumberOfUnCommittedPages)); set => WriteHere(nameof(NumberOfUnCommittedPages), value); }

        [Offset(84UL)]
        public uint NumberOfUnCommittedRanges { get => ReadHere<uint>(nameof(NumberOfUnCommittedRanges)); set => WriteHere(nameof(NumberOfUnCommittedRanges), value); }

        [Offset(88UL)]
        public ushort SegmentAllocatorBackTraceIndex { get => ReadHere<ushort>(nameof(SegmentAllocatorBackTraceIndex)); set => WriteHere(nameof(SegmentAllocatorBackTraceIndex), value); }

        [Offset(90UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(96UL)]
        public ListEntry UCRSegmentList { get => ReadStructure<ListEntry>(nameof(UCRSegmentList)); set => WriteStructure(nameof(UCRSegmentList), value); }

        public HeapSegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapSegment>();
        }
    }
}