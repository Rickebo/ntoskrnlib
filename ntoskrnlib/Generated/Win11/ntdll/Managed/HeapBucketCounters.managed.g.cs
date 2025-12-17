using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_BUCKET_COUNTERS")]
    public sealed class HeapBucketCounters : DynamicStructure
    {
        [Offset(0UL)]
        public uint TotalBlocks { get => ReadHere<uint>(nameof(TotalBlocks)); set => WriteHere(nameof(TotalBlocks), value); }

        [Offset(4UL)]
        public uint SubSegmentCounts { get => ReadHere<uint>(nameof(SubSegmentCounts)); set => WriteHere(nameof(SubSegmentCounts), value); }

        [Offset(0UL)]
        public long Aggregate64 { get => ReadHere<long>(nameof(Aggregate64)); set => WriteHere(nameof(Aggregate64), value); }

        public HeapBucketCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapBucketCounters>();
        }
    }
}