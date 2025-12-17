using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_SYSTEM_PAGE_COUNTS")]
    public sealed class MmSystemPageCounts : DynamicStructure
    {
        [Offset(0UL)]
        public uint SystemCodePage { get => ReadHere<uint>(nameof(SystemCodePage)); set => WriteHere(nameof(SystemCodePage), value); }

        [Offset(4UL)]
        public uint SystemDriverPage { get => ReadHere<uint>(nameof(SystemDriverPage)); set => WriteHere(nameof(SystemDriverPage), value); }

        [Offset(8UL)]
        public int TotalSystemCodePages { get => ReadHere<int>(nameof(TotalSystemCodePages)); set => WriteHere(nameof(TotalSystemCodePages), value); }

        [Offset(12UL)]
        public int TotalSystemDriverPages { get => ReadHere<int>(nameof(TotalSystemDriverPages)); set => WriteHere(nameof(TotalSystemDriverPages), value); }

        public MmSystemPageCounts(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmSystemPageCounts>();
        }
    }
}