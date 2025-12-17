using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_RANGE_LIST")]
    public sealed class RtlRangeList : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(20UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(24UL)]
        public uint Stamp { get => ReadHere<uint>(nameof(Stamp)); set => WriteHere(nameof(Stamp), value); }

        public RtlRangeList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlRangeList>();
        }
    }
}