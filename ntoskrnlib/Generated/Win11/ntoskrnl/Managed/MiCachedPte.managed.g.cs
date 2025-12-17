using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_CACHED_PTE")]
    public sealed class MiCachedPte : DynamicStructure
    {
        [Offset(0UL)]
        public ulong GlobalTimeStamp { get => ReadHere<ulong>(nameof(GlobalTimeStamp)); set => WriteHere(nameof(GlobalTimeStamp), value); }

        [Offset(0UL)]
        public ulong PteIndex { get => ReadHere<ulong>(nameof(PteIndex)); set => WriteHere(nameof(PteIndex), value); }

        [Offset(0UL)]
        public ulong Long { get => ReadHere<ulong>(nameof(Long)); set => WriteHere(nameof(Long), value); }

        public MiCachedPte(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCachedPte>();
        }
    }
}