using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MIPFNFLINK")]
    public sealed class Mipfnflink : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr NextSlistPfn { get => ReadHere<IntPtr>(nameof(NextSlistPfn)); set => WriteHere(nameof(NextSlistPfn), value); }

        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(0UL)]
        public ulong Flink { get => ReadHere<ulong>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(0UL)]
        public ulong NodeFlinkLow { get => ReadHere<ulong>(nameof(NodeFlinkLow)); set => WriteHere(nameof(NodeFlinkLow), value); }

        [Offset(0UL)]
        public ulong EntireField { get => ReadHere<ulong>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        [Offset(0UL)]
        public MiActivePfn Active { get => ReadStructure<MiActivePfn>(nameof(Active)); set => WriteStructure(nameof(Active), value); }

        public Mipfnflink(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mipfnflink>();
        }
    }
}