using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CACHE_MANAGER_CALLBACKS")]
    public sealed class CacheManagerCallbacks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr AcquireForLazyWrite { get => ReadHere<IntPtr>(nameof(AcquireForLazyWrite)); set => WriteHere(nameof(AcquireForLazyWrite), value); }

        [Offset(8UL)]
        public IntPtr ReleaseFromLazyWrite { get => ReadHere<IntPtr>(nameof(ReleaseFromLazyWrite)); set => WriteHere(nameof(ReleaseFromLazyWrite), value); }

        [Offset(16UL)]
        public IntPtr AcquireForReadAhead { get => ReadHere<IntPtr>(nameof(AcquireForReadAhead)); set => WriteHere(nameof(AcquireForReadAhead), value); }

        [Offset(24UL)]
        public IntPtr ReleaseFromReadAhead { get => ReadHere<IntPtr>(nameof(ReleaseFromReadAhead)); set => WriteHere(nameof(ReleaseFromReadAhead), value); }

        public CacheManagerCallbacks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CacheManagerCallbacks>();
        }
    }
}