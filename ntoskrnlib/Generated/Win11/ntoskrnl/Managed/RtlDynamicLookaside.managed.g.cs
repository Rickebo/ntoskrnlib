using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_DYNAMIC_LOOKASIDE")]
    public sealed class RtlDynamicLookaside : DynamicStructure
    {
        [Offset(0UL)]
        public ulong EnabledBucketBitmap { get => ReadHere<ulong>(nameof(EnabledBucketBitmap)); set => WriteHere(nameof(EnabledBucketBitmap), value); }

        [Offset(8UL)]
        public uint BucketCount { get => ReadHere<uint>(nameof(BucketCount)); set => WriteHere(nameof(BucketCount), value); }

        [Offset(12UL)]
        public uint ActiveBucketCount { get => ReadHere<uint>(nameof(ActiveBucketCount)); set => WriteHere(nameof(ActiveBucketCount), value); }

        [Offset(64UL)]
        [Length(64)]
        public DynamicArray Buckets { get => ReadStructure<DynamicArray>(nameof(Buckets)); set => WriteStructure(nameof(Buckets), value); }

        public RtlDynamicLookaside(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlDynamicLookaside>();
        }
    }
}