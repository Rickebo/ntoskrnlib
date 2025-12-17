using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_RUNDOWN_REF_CACHE_AWARE")]
    public sealed class ExRundownRefCacheAware : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr RunRefs { get => ReadHere<IntPtr>(nameof(RunRefs)); set => WriteHere(nameof(RunRefs), value); }

        [Offset(8UL)]
        public IntPtr PoolToFree { get => ReadHere<IntPtr>(nameof(PoolToFree)); set => WriteHere(nameof(PoolToFree), value); }

        [Offset(16UL)]
        public uint RunRefSize { get => ReadHere<uint>(nameof(RunRefSize)); set => WriteHere(nameof(RunRefSize), value); }

        [Offset(20UL)]
        public uint Number { get => ReadHere<uint>(nameof(Number)); set => WriteHere(nameof(Number), value); }

        public ExRundownRefCacheAware(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExRundownRefCacheAware>();
        }
    }
}