using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INBV_MODE_INFORMATION")]
    public sealed class InbvModeInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Height { get => ReadHere<uint>(nameof(Height)); set => WriteHere(nameof(Height), value); }

        [Offset(4UL)]
        public uint Width { get => ReadHere<uint>(nameof(Width)); set => WriteHere(nameof(Width), value); }

        [Offset(8UL)]
        public uint Stride { get => ReadHere<uint>(nameof(Stride)); set => WriteHere(nameof(Stride), value); }

        [Offset(12UL)]
        public uint PixelFormat { get => ReadHere<uint>(nameof(PixelFormat)); set => WriteHere(nameof(PixelFormat), value); }

        public InbvModeInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InbvModeInformation>();
        }
    }
}