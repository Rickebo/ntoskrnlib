using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_TRANSLATION_BUFFER")]
    public sealed class HalpDmaTranslationBuffer : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public uint EntryCount { get => ReadHere<uint>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        [Offset(16UL)]
        public IntPtr Entries { get => ReadHere<IntPtr>(nameof(Entries)); set => WriteHere(nameof(Entries), value); }

        public HalpDmaTranslationBuffer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaTranslationBuffer>();
        }
    }
}