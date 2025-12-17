using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_PSEUDO_TAG_ENTRY")]
    public sealed class HeapPseudoTagEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint Allocs { get => ReadHere<uint>(nameof(Allocs)); set => WriteHere(nameof(Allocs), value); }

        [Offset(4UL)]
        public uint Frees { get => ReadHere<uint>(nameof(Frees)); set => WriteHere(nameof(Frees), value); }

        [Offset(8UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public HeapPseudoTagEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapPseudoTagEntry>();
        }
    }
}