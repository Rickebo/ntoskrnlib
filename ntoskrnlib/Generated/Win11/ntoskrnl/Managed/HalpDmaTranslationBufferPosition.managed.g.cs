using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_TRANSLATION_BUFFER_POSITION")]
    public sealed class HalpDmaTranslationBufferPosition : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        [Offset(8UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        public HalpDmaTranslationBufferPosition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaTranslationBufferPosition>();
        }
    }
}