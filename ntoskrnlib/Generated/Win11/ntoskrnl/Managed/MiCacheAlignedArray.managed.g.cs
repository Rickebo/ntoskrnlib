using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_CACHE_ALIGNED_ARRAY")]
    public sealed class MiCacheAlignedArray : DynamicStructure
    {
        [Offset(0UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public long SignedValue { get => ReadHere<long>(nameof(SignedValue)); set => WriteHere(nameof(SignedValue), value); }

        [Offset(0UL)]
        public MiCacheLine CacheLinePadding { get => ReadStructure<MiCacheLine>(nameof(CacheLinePadding)); set => WriteStructure(nameof(CacheLinePadding), value); }

        public MiCacheAlignedArray(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCacheAlignedArray>();
        }
    }
}