using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_GENERAL_LOOKASIDE_POOL")]
    public sealed class GeneralLookasidePool : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader ListHead { get => ReadStructure<SlistHeader>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(0UL)]
        public SingleListEntry SingleListHead { get => ReadStructure<SingleListEntry>(nameof(SingleListHead)); set => WriteStructure(nameof(SingleListHead), value); }

        [Offset(16UL)]
        public ushort Depth { get => ReadHere<ushort>(nameof(Depth)); set => WriteHere(nameof(Depth), value); }

        [Offset(18UL)]
        public ushort MaximumDepth { get => ReadHere<ushort>(nameof(MaximumDepth)); set => WriteHere(nameof(MaximumDepth), value); }

        [Offset(20UL)]
        public uint TotalAllocates { get => ReadHere<uint>(nameof(TotalAllocates)); set => WriteHere(nameof(TotalAllocates), value); }

        [Offset(24UL)]
        public uint AllocateMisses { get => ReadHere<uint>(nameof(AllocateMisses)); set => WriteHere(nameof(AllocateMisses), value); }

        [Offset(24UL)]
        public uint AllocateHits { get => ReadHere<uint>(nameof(AllocateHits)); set => WriteHere(nameof(AllocateHits), value); }

        [Offset(28UL)]
        public uint TotalFrees { get => ReadHere<uint>(nameof(TotalFrees)); set => WriteHere(nameof(TotalFrees), value); }

        [Offset(32UL)]
        public uint FreeMisses { get => ReadHere<uint>(nameof(FreeMisses)); set => WriteHere(nameof(FreeMisses), value); }

        [Offset(32UL)]
        public uint FreeHits { get => ReadHere<uint>(nameof(FreeHits)); set => WriteHere(nameof(FreeHits), value); }

        [Offset(36UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(40UL)]
        public uint Tag { get => ReadHere<uint>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        [Offset(44UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(48UL)]
        public IntPtr AllocateEx { get => ReadHere<IntPtr>(nameof(AllocateEx)); set => WriteHere(nameof(AllocateEx), value); }

        [Offset(48UL)]
        public IntPtr Allocate { get => ReadHere<IntPtr>(nameof(Allocate)); set => WriteHere(nameof(Allocate), value); }

        [Offset(56UL)]
        public IntPtr FreeEx { get => ReadHere<IntPtr>(nameof(FreeEx)); set => WriteHere(nameof(FreeEx), value); }

        [Offset(56UL)]
        public IntPtr Free { get => ReadHere<IntPtr>(nameof(Free)); set => WriteHere(nameof(Free), value); }

        [Offset(64UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(80UL)]
        public uint LastTotalAllocates { get => ReadHere<uint>(nameof(LastTotalAllocates)); set => WriteHere(nameof(LastTotalAllocates), value); }

        [Offset(84UL)]
        public uint LastAllocateMisses { get => ReadHere<uint>(nameof(LastAllocateMisses)); set => WriteHere(nameof(LastAllocateMisses), value); }

        [Offset(84UL)]
        public uint LastAllocateHits { get => ReadHere<uint>(nameof(LastAllocateHits)); set => WriteHere(nameof(LastAllocateHits), value); }

        [Offset(88UL)]
        [Length(2)]
        public DynamicArray Future { get => ReadStructure<DynamicArray>(nameof(Future)); set => WriteStructure(nameof(Future), value); }

        public GeneralLookasidePool(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GeneralLookasidePool>();
        }
    }
}