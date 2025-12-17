using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_CHAIN_HEAD")]
    public sealed class MiPageChainHead : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Head { get => ReadHere<IntPtr>(nameof(Head)); set => WriteHere(nameof(Head), value); }

        [Offset(8UL)]
        public IntPtr Tail { get => ReadHere<IntPtr>(nameof(Tail)); set => WriteHere(nameof(Tail), value); }

        [Offset(16UL)]
        public ulong NumberOfEntries { get => ReadHere<ulong>(nameof(NumberOfEntries)); set => WriteHere(nameof(NumberOfEntries), value); }

        public MiPageChainHead(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPageChainHead>();
        }
    }
}