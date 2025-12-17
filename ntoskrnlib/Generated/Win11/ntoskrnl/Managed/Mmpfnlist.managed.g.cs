using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPFNLIST")]
    public sealed class Mmpfnlist : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Total { get => ReadHere<ulong>(nameof(Total)); set => WriteHere(nameof(Total), value); }

        [Offset(8UL)]
        public MiColor Color { get => ReadStructure<MiColor>(nameof(Color)); set => WriteStructure(nameof(Color), value); }

        [Offset(12UL)]
        public uint ListName { get => ReadHere<uint>(nameof(ListName)); set => WriteHere(nameof(ListName), value); }

        [Offset(16UL)]
        public ulong Flink { get => ReadHere<ulong>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(24UL)]
        public ulong Blink { get => ReadHere<ulong>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        [Offset(32UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(40UL)]
        public Mmpfn EmbeddedPfn { get => ReadStructure<Mmpfn>(nameof(EmbeddedPfn)); set => WriteStructure(nameof(EmbeddedPfn), value); }

        public Mmpfnlist(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mmpfnlist>();
        }
    }
}