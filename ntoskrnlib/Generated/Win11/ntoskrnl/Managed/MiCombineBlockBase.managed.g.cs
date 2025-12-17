using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_BLOCK_BASE")]
    public sealed class MiCombineBlockBase : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public uint NumberOfActiveBlocks { get => ReadHere<uint>(nameof(NumberOfActiveBlocks)); set => WriteHere(nameof(NumberOfActiveBlocks), value); }

        [Offset(16UL)]
        public IntPtr Pcs { get => ReadHere<IntPtr>(nameof(Pcs)); set => WriteHere(nameof(Pcs), value); }

        public MiCombineBlockBase(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCombineBlockBase>();
        }
    }
}