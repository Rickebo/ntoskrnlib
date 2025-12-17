using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LOCAL_SEGMENT_INFO")]
    public sealed class HeapLocalSegmentInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LocalData { get => ReadHere<IntPtr>(nameof(LocalData)); set => WriteHere(nameof(LocalData), value); }

        [Offset(8UL)]
        public IntPtr ActiveSubsegment { get => ReadHere<IntPtr>(nameof(ActiveSubsegment)); set => WriteHere(nameof(ActiveSubsegment), value); }

        [Offset(16UL)]
        [Length(16)]
        public DynamicArray CachedItems { get => ReadStructure<DynamicArray>(nameof(CachedItems)); set => WriteStructure(nameof(CachedItems), value); }

        [Offset(144UL)]
        public SlistHeader SListHeader { get => ReadStructure<SlistHeader>(nameof(SListHeader)); set => WriteStructure(nameof(SListHeader), value); }

        [Offset(160UL)]
        public HeapBucketCounters Counters { get => ReadStructure<HeapBucketCounters>(nameof(Counters)); set => WriteStructure(nameof(Counters), value); }

        [Offset(168UL)]
        public uint LastOpSequence { get => ReadHere<uint>(nameof(LastOpSequence)); set => WriteHere(nameof(LastOpSequence), value); }

        [Offset(172UL)]
        public ushort BucketIndex { get => ReadHere<ushort>(nameof(BucketIndex)); set => WriteHere(nameof(BucketIndex), value); }

        [Offset(174UL)]
        public ushort LastUsed { get => ReadHere<ushort>(nameof(LastUsed)); set => WriteHere(nameof(LastUsed), value); }

        [Offset(176UL)]
        public ushort NoThrashCount { get => ReadHere<ushort>(nameof(NoThrashCount)); set => WriteHere(nameof(NoThrashCount), value); }

        public HeapLocalSegmentInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLocalSegmentInfo>();
        }
    }
}