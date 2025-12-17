using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PFN_FLAGS4")]
    public sealed class MiPfnFLAGS4 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PteFrame { get => ReadHere<ulong>(nameof(PteFrame)); set => WriteHere(nameof(PteFrame), value); }

        [Offset(0UL)]
        public ulong ResidentPage { get => ReadHere<ulong>(nameof(ResidentPage)); set => WriteHere(nameof(ResidentPage), value); }

        [Offset(0UL)]
        public ulong ResidentPageContainsBadPages { get => ReadHere<ulong>(nameof(ResidentPageContainsBadPages)); set => WriteHere(nameof(ResidentPageContainsBadPages), value); }

        [Offset(0UL)]
        public ulong Unused1 { get => ReadHere<ulong>(nameof(Unused1)); set => WriteHere(nameof(Unused1), value); }

        [Offset(0UL)]
        public ulong Partition { get => ReadHere<ulong>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(0UL)]
        public ulong FileOnly { get => ReadHere<ulong>(nameof(FileOnly)); set => WriteHere(nameof(FileOnly), value); }

        [Offset(0UL)]
        public ulong PfnExists { get => ReadHere<ulong>(nameof(PfnExists)); set => WriteHere(nameof(PfnExists), value); }

        [Offset(0UL)]
        public ulong NodeFlinkHigh { get => ReadHere<ulong>(nameof(NodeFlinkHigh)); set => WriteHere(nameof(NodeFlinkHigh), value); }

        [Offset(0UL)]
        public ulong PageIdentity { get => ReadHere<ulong>(nameof(PageIdentity)); set => WriteHere(nameof(PageIdentity), value); }

        [Offset(0UL)]
        public ulong PrototypePte { get => ReadHere<ulong>(nameof(PrototypePte)); set => WriteHere(nameof(PrototypePte), value); }

        [Offset(0UL)]
        public ulong EntireField { get => ReadHere<ulong>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiPfnFLAGS4(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPfnFLAGS4>();
        }
    }
}