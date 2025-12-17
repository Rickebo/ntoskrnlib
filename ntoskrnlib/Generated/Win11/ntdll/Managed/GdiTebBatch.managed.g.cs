using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_GDI_TEB_BATCH")]
    public sealed class GdiTebBatch : DynamicStructure
    {
        [Offset(0UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(0UL)]
        public uint InProcessing { get => ReadHere<uint>(nameof(InProcessing)); set => WriteHere(nameof(InProcessing), value); }

        [Offset(0UL)]
        public uint HasRenderingCommand { get => ReadHere<uint>(nameof(HasRenderingCommand)); set => WriteHere(nameof(HasRenderingCommand), value); }

        [Offset(8UL)]
        public ulong HDC { get => ReadHere<ulong>(nameof(HDC)); set => WriteHere(nameof(HDC), value); }

        [Offset(16UL)]
        [Length(310)]
        public DynamicArray Buffer { get => ReadStructure<DynamicArray>(nameof(Buffer)); set => WriteStructure(nameof(Buffer), value); }

        public GdiTebBatch(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GdiTebBatch>();
        }
    }
}