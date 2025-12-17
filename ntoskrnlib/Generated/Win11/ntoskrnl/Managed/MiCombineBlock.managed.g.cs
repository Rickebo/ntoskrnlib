using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_BLOCK")]
    public sealed class MiCombineBlock : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(24UL)]
        public ulong HashValue { get => ReadHere<ulong>(nameof(HashValue)); set => WriteHere(nameof(HashValue), value); }

        [Offset(32UL)]
        public MmcloneBlock Clone { get => ReadStructure<MmcloneBlock>(nameof(Clone)); set => WriteStructure(nameof(Clone), value); }

        [Offset(64UL)]
        public ulong CombineDomain { get => ReadHere<ulong>(nameof(CombineDomain)); set => WriteHere(nameof(CombineDomain), value); }

        public MiCombineBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCombineBlock>();
        }
    }
}