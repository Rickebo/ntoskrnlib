using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_LOOKASIDE")]
    public sealed class RtlLookaside : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader ListHead { get => ReadStructure<SlistHeader>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(16UL)]
        public ushort Depth { get => ReadHere<ushort>(nameof(Depth)); set => WriteHere(nameof(Depth), value); }

        [Offset(18UL)]
        public ushort MaximumDepth { get => ReadHere<ushort>(nameof(MaximumDepth)); set => WriteHere(nameof(MaximumDepth), value); }

        [Offset(20UL)]
        public uint TotalAllocates { get => ReadHere<uint>(nameof(TotalAllocates)); set => WriteHere(nameof(TotalAllocates), value); }

        [Offset(24UL)]
        public uint AllocateMisses { get => ReadHere<uint>(nameof(AllocateMisses)); set => WriteHere(nameof(AllocateMisses), value); }

        [Offset(28UL)]
        public uint TotalFrees { get => ReadHere<uint>(nameof(TotalFrees)); set => WriteHere(nameof(TotalFrees), value); }

        [Offset(32UL)]
        public uint FreeMisses { get => ReadHere<uint>(nameof(FreeMisses)); set => WriteHere(nameof(FreeMisses), value); }

        [Offset(36UL)]
        public uint LastTotalAllocates { get => ReadHere<uint>(nameof(LastTotalAllocates)); set => WriteHere(nameof(LastTotalAllocates), value); }

        [Offset(40UL)]
        public uint LastAllocateMisses { get => ReadHere<uint>(nameof(LastAllocateMisses)); set => WriteHere(nameof(LastAllocateMisses), value); }

        [Offset(44UL)]
        public uint LastTotalFrees { get => ReadHere<uint>(nameof(LastTotalFrees)); set => WriteHere(nameof(LastTotalFrees), value); }

        public RtlLookaside(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlLookaside>();
        }
    }
}