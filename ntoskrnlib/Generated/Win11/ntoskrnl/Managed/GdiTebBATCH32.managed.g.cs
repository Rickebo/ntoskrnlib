using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GDI_TEB_BATCH32")]
    public sealed class GdiTebBATCH32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(0UL)]
        public uint InProcessing { get => ReadHere<uint>(nameof(InProcessing)); set => WriteHere(nameof(InProcessing), value); }

        [Offset(0UL)]
        public uint HasRenderingCommand { get => ReadHere<uint>(nameof(HasRenderingCommand)); set => WriteHere(nameof(HasRenderingCommand), value); }

        [Offset(4UL)]
        public uint HDC { get => ReadHere<uint>(nameof(HDC)); set => WriteHere(nameof(HDC), value); }

        [Offset(8UL)]
        [Length(310)]
        public DynamicArray Buffer { get => ReadStructure<DynamicArray>(nameof(Buffer)); set => WriteStructure(nameof(Buffer), value); }

        public GdiTebBATCH32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GdiTebBATCH32>();
        }
    }
}