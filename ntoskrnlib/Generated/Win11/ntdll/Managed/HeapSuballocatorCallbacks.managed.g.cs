using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_SUBALLOCATOR_CALLBACKS")]
    public sealed class HeapSuballocatorCallbacks : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Allocate { get => ReadHere<ulong>(nameof(Allocate)); set => WriteHere(nameof(Allocate), value); }

        [Offset(8UL)]
        public ulong Free { get => ReadHere<ulong>(nameof(Free)); set => WriteHere(nameof(Free), value); }

        [Offset(16UL)]
        public ulong Commit { get => ReadHere<ulong>(nameof(Commit)); set => WriteHere(nameof(Commit), value); }

        [Offset(24UL)]
        public ulong Decommit { get => ReadHere<ulong>(nameof(Decommit)); set => WriteHere(nameof(Decommit), value); }

        [Offset(32UL)]
        public ulong ExtendContext { get => ReadHere<ulong>(nameof(ExtendContext)); set => WriteHere(nameof(ExtendContext), value); }

        [Offset(40UL)]
        public ulong TlsCleanup { get => ReadHere<ulong>(nameof(TlsCleanup)); set => WriteHere(nameof(TlsCleanup), value); }

        public HeapSuballocatorCallbacks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapSuballocatorCallbacks>();
        }
    }
}