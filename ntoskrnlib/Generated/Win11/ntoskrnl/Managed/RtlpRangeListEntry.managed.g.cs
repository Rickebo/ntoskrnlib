using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTLP_RANGE_LIST_ENTRY")]
    public sealed class RtlpRangeListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Start { get => ReadHere<ulong>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(8UL)]
        public ulong End { get => ReadHere<ulong>(nameof(End)); set => WriteHere(nameof(End), value); }

        [Offset(16UL)]
        public UnnamedTag Allocated { get => ReadStructure<UnnamedTag>(nameof(Allocated)); set => WriteStructure(nameof(Allocated), value); }

        [Offset(16UL)]
        public UnnamedTag Merged { get => ReadStructure<UnnamedTag>(nameof(Merged)); set => WriteStructure(nameof(Merged), value); }

        [Offset(32UL)]
        public byte Attributes { get => ReadHere<byte>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        [Offset(33UL)]
        public byte PublicFlags { get => ReadHere<byte>(nameof(PublicFlags)); set => WriteHere(nameof(PublicFlags), value); }

        [Offset(34UL)]
        public ushort PrivateFlags { get => ReadHere<ushort>(nameof(PrivateFlags)); set => WriteHere(nameof(PrivateFlags), value); }

        [Offset(40UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        public RtlpRangeListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpRangeListEntry>();
        }
    }
}