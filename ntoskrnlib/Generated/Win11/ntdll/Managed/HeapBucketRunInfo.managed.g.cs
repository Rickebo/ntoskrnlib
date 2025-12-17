using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_BUCKET_RUN_INFO")]
    public sealed class HeapBucketRunInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Bucket { get => ReadHere<uint>(nameof(Bucket)); set => WriteHere(nameof(Bucket), value); }

        [Offset(4UL)]
        public uint RunLength { get => ReadHere<uint>(nameof(RunLength)); set => WriteHere(nameof(RunLength), value); }

        [Offset(0UL)]
        public long Aggregate64 { get => ReadHere<long>(nameof(Aggregate64)); set => WriteHere(nameof(Aggregate64), value); }

        public HeapBucketRunInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapBucketRunInfo>();
        }
    }
}