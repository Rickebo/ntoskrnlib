using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_PAGE_SEGMENT")]
    public sealed class HeapPageSegment : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(24UL)]
        public IntPtr SegmentCommitState { get => ReadHere<IntPtr>(nameof(SegmentCommitState)); set => WriteHere(nameof(SegmentCommitState), value); }

        [Offset(32UL)]
        public byte UnusedWatermark { get => ReadHere<byte>(nameof(UnusedWatermark)); set => WriteHere(nameof(UnusedWatermark), value); }

        [Offset(0UL)]
        [Length(256)]
        public DynamicArray DescArray { get => ReadStructure<DynamicArray>(nameof(DescArray)); set => WriteStructure(nameof(DescArray), value); }

        public HeapPageSegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapPageSegment>();
        }
    }
}