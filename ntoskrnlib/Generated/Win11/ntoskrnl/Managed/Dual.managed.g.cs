using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DUAL")]
    public sealed class Dual : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public IntPtr Map { get => ReadHere<IntPtr>(nameof(Map)); set => WriteHere(nameof(Map), value); }

        [Offset(16UL)]
        public IntPtr SmallDir { get => ReadHere<IntPtr>(nameof(SmallDir)); set => WriteHere(nameof(SmallDir), value); }

        [Offset(24UL)]
        public uint Guard { get => ReadHere<uint>(nameof(Guard)); set => WriteHere(nameof(Guard), value); }

        [Offset(32UL)]
        [Length(24)]
        public DynamicArray FreeDisplay { get => ReadStructure<DynamicArray>(nameof(FreeDisplay)); set => WriteStructure(nameof(FreeDisplay), value); }

        [Offset(608UL)]
        public ListEntry FreeBins { get => ReadStructure<ListEntry>(nameof(FreeBins)); set => WriteStructure(nameof(FreeBins), value); }

        [Offset(624UL)]
        public uint FreeSummary { get => ReadHere<uint>(nameof(FreeSummary)); set => WriteHere(nameof(FreeSummary), value); }

        public Dual(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Dual>();
        }
    }
}