using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BITMAP_RANGE")]
    public sealed class BitmapRange : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public long BasePage { get => ReadHere<long>(nameof(BasePage)); set => WriteHere(nameof(BasePage), value); }

        [Offset(24UL)]
        public uint FirstDirtyPage { get => ReadHere<uint>(nameof(FirstDirtyPage)); set => WriteHere(nameof(FirstDirtyPage), value); }

        [Offset(28UL)]
        public uint LastDirtyPage { get => ReadHere<uint>(nameof(LastDirtyPage)); set => WriteHere(nameof(LastDirtyPage), value); }

        [Offset(32UL)]
        public uint DirtyPages { get => ReadHere<uint>(nameof(DirtyPages)); set => WriteHere(nameof(DirtyPages), value); }

        [Offset(40UL)]
        public IntPtr Bitmap { get => ReadHere<IntPtr>(nameof(Bitmap)); set => WriteHere(nameof(Bitmap), value); }

        public BitmapRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BitmapRange>();
        }
    }
}