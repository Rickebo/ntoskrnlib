using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGEFILE_BITMAPS_CACHE_ENTRY")]
    public sealed class MiPagefileBitmapsCacheEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode LengthTreeNode { get => ReadStructure<RtlBalancedNode>(nameof(LengthTreeNode)); set => WriteStructure(nameof(LengthTreeNode), value); }

        [Offset(0UL)]
        public ListEntry FreeListEntry { get => ReadStructure<ListEntry>(nameof(FreeListEntry)); set => WriteStructure(nameof(FreeListEntry), value); }

        [Offset(24UL)]
        public RtlBalancedNode LocationTreeNode { get => ReadStructure<RtlBalancedNode>(nameof(LocationTreeNode)); set => WriteStructure(nameof(LocationTreeNode), value); }

        [Offset(48UL)]
        public uint StartingIndex { get => ReadHere<uint>(nameof(StartingIndex)); set => WriteHere(nameof(StartingIndex), value); }

        [Offset(52UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        public MiPagefileBitmapsCacheEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPagefileBitmapsCacheEntry>();
        }
    }
}