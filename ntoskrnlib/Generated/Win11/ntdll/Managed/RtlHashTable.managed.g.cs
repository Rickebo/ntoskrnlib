using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_HASH_TABLE")]
    public sealed class RtlHashTable : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntryCount { get => ReadHere<uint>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        [Offset(4UL)]
        public uint MaskBitCount { get => ReadHere<uint>(nameof(MaskBitCount)); set => WriteHere(nameof(MaskBitCount), value); }

        [Offset(4UL)]
        public uint BucketCount { get => ReadHere<uint>(nameof(BucketCount)); set => WriteHere(nameof(BucketCount), value); }

        [Offset(8UL)]
        public IntPtr Buckets { get => ReadHere<IntPtr>(nameof(Buckets)); set => WriteHere(nameof(Buckets), value); }

        public RtlHashTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHashTable>();
        }
    }
}