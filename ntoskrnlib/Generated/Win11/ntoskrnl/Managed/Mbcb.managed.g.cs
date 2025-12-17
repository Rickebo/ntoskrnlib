using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MBCB")]
    public sealed class Mbcb : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeIsInZone { get => ReadHere<short>(nameof(NodeIsInZone)); set => WriteHere(nameof(NodeIsInZone), value); }

        [Offset(4UL)]
        public uint PagesToWrite { get => ReadHere<uint>(nameof(PagesToWrite)); set => WriteHere(nameof(PagesToWrite), value); }

        [Offset(8UL)]
        public uint DirtyPages { get => ReadHere<uint>(nameof(DirtyPages)); set => WriteHere(nameof(DirtyPages), value); }

        [Offset(12UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public ListEntry BitmapRanges { get => ReadStructure<ListEntry>(nameof(BitmapRanges)); set => WriteStructure(nameof(BitmapRanges), value); }

        [Offset(32UL)]
        public long ResumeWritePage { get => ReadHere<long>(nameof(ResumeWritePage)); set => WriteHere(nameof(ResumeWritePage), value); }

        [Offset(40UL)]
        public long MostRecentlyDirtiedPage { get => ReadHere<long>(nameof(MostRecentlyDirtiedPage)); set => WriteHere(nameof(MostRecentlyDirtiedPage), value); }

        [Offset(48UL)]
        public BitmapRange BitmapRange1 { get => ReadStructure<BitmapRange>(nameof(BitmapRange1)); set => WriteStructure(nameof(BitmapRange1), value); }

        [Offset(96UL)]
        public BitmapRange BitmapRange2 { get => ReadStructure<BitmapRange>(nameof(BitmapRange2)); set => WriteStructure(nameof(BitmapRange2), value); }

        [Offset(144UL)]
        public BitmapRange BitmapRange3 { get => ReadStructure<BitmapRange>(nameof(BitmapRange3)); set => WriteStructure(nameof(BitmapRange3), value); }

        public Mbcb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mbcb>();
        }
    }
}