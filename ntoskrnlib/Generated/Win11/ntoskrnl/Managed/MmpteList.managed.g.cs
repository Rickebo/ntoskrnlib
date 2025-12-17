using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_LIST")]
    public sealed class MmpteList : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(0UL)]
        public ulong OneEntry { get => ReadHere<ulong>(nameof(OneEntry)); set => WriteHere(nameof(OneEntry), value); }

        [Offset(0UL)]
        public ulong filler0 { get => ReadHere<ulong>(nameof(filler0)); set => WriteHere(nameof(filler0), value); }

        [Offset(0UL)]
        public ulong SwizzleBit { get => ReadHere<ulong>(nameof(SwizzleBit)); set => WriteHere(nameof(SwizzleBit), value); }

        [Offset(0UL)]
        public ulong Protection { get => ReadHere<ulong>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong Transition { get => ReadHere<ulong>(nameof(Transition)); set => WriteHere(nameof(Transition), value); }

        [Offset(0UL)]
        public ulong filler1 { get => ReadHere<ulong>(nameof(filler1)); set => WriteHere(nameof(filler1), value); }

        [Offset(0UL)]
        public ulong NextEntry { get => ReadHere<ulong>(nameof(NextEntry)); set => WriteHere(nameof(NextEntry), value); }

        public MmpteList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpteList>();
        }
    }
}