using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_CACHED_PTES")]
    public sealed class MiCachedPtes : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray Bins { get => ReadStructure<DynamicArray>(nameof(Bins)); set => WriteStructure(nameof(Bins), value); }

        [Offset(64UL)]
        public long CachedPteCount { get => ReadHere<long>(nameof(CachedPteCount)); set => WriteHere(nameof(CachedPteCount), value); }

        public MiCachedPtes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCachedPtes>();
        }
    }
}