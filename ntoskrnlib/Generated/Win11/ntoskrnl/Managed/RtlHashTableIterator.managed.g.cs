using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_HASH_TABLE_ITERATOR")]
    public sealed class RtlHashTableIterator : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Hash { get => ReadHere<IntPtr>(nameof(Hash)); set => WriteHere(nameof(Hash), value); }

        [Offset(8UL)]
        public IntPtr HashEntry { get => ReadHere<IntPtr>(nameof(HashEntry)); set => WriteHere(nameof(HashEntry), value); }

        [Offset(16UL)]
        public IntPtr Bucket { get => ReadHere<IntPtr>(nameof(Bucket)); set => WriteHere(nameof(Bucket), value); }

        public RtlHashTableIterator(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHashTableIterator>();
        }
    }
}