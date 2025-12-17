using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGING_FILE_SPACE_BITMAPS")]
    public sealed class MiPagingFileSpaceBitmaps : DynamicStructure
    {
        [Offset(0UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(0UL)]
        public IntPtr Anchor { get => ReadHere<IntPtr>(nameof(Anchor)); set => WriteHere(nameof(Anchor), value); }

        [Offset(8UL)]
        public RtlBitmap AllocationBitmap { get => ReadStructure<RtlBitmap>(nameof(AllocationBitmap)); set => WriteStructure(nameof(AllocationBitmap), value); }

        [Offset(24UL)]
        public RtlBitmap ReservationBitmap { get => ReadStructure<RtlBitmap>(nameof(ReservationBitmap)); set => WriteStructure(nameof(ReservationBitmap), value); }

        [Offset(24UL)]
        public RtlBitmap EvictedBitmap { get => ReadStructure<RtlBitmap>(nameof(EvictedBitmap)); set => WriteStructure(nameof(EvictedBitmap), value); }

        public MiPagingFileSpaceBitmaps(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPagingFileSpaceBitmaps>();
        }
    }
}