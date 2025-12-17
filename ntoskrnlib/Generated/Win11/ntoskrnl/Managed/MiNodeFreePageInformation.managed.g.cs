using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_NODE_FREE_PAGE_INFORMATION")]
    public sealed class MiNodeFreePageInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint PageColorHand { get => ReadHere<uint>(nameof(PageColorHand)); set => WriteHere(nameof(PageColorHand), value); }

        [Offset(8UL)]
        [Length(2)]
        public DynamicArray FreeCount { get => ReadStructure<DynamicArray>(nameof(FreeCount)); set => WriteStructure(nameof(FreeCount), value); }

        [Offset(24UL)]
        [Length(2)]
        public DynamicArray FreeZeroCountByAttribute { get => ReadStructure<DynamicArray>(nameof(FreeZeroCountByAttribute)); set => WriteStructure(nameof(FreeZeroCountByAttribute), value); }

        [Offset(128UL)]
        [Length(2)]
        public DynamicArray FreePageListHeadsBitmap { get => ReadStructure<DynamicArray>(nameof(FreePageListHeadsBitmap)); set => WriteStructure(nameof(FreePageListHeadsBitmap), value); }

        [Offset(384UL)]
        [Length(64)]
        public DynamicArray FreePageListHeadsBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(FreePageListHeadsBitmapBuffer)); set => WriteStructure(nameof(FreePageListHeadsBitmapBuffer), value); }

        [Offset(896UL)]
        [Length(2)]
        public DynamicArray LargePageFreeCountHiLow { get => ReadStructure<DynamicArray>(nameof(LargePageFreeCountHiLow)); set => WriteStructure(nameof(LargePageFreeCountHiLow), value); }

        [Offset(928UL)]
        [Length(2)]
        public DynamicArray LargePageCount { get => ReadStructure<DynamicArray>(nameof(LargePageCount)); set => WriteStructure(nameof(LargePageCount), value); }

        [Offset(992UL)]
        [Length(2)]
        public DynamicArray LargePageEntries { get => ReadStructure<DynamicArray>(nameof(LargePageEntries)); set => WriteStructure(nameof(LargePageEntries), value); }

        public MiNodeFreePageInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiNodeFreePageInformation>();
        }
    }
}