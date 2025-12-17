using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INBV_GRAPHICS_RECTANGLE")]
    public sealed class InbvGraphicsRectangle : DynamicStructure
    {
        [Offset(0UL)]
        public uint Height { get => ReadHere<uint>(nameof(Height)); set => WriteHere(nameof(Height), value); }

        [Offset(4UL)]
        public uint Width { get => ReadHere<uint>(nameof(Width)); set => WriteHere(nameof(Width), value); }

        [Offset(8UL)]
        public uint PixelFormat { get => ReadHere<uint>(nameof(PixelFormat)); set => WriteHere(nameof(PixelFormat), value); }

        [Offset(12UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(16UL)]
        public IntPtr Data { get => ReadHere<IntPtr>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        public InbvGraphicsRectangle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InbvGraphicsRectangle>();
        }
    }
}