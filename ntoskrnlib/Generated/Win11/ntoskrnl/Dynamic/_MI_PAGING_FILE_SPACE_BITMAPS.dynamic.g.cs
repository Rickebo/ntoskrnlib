using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGING_FILE_SPACE_BITMAPS")]
    public sealed class _MI_PAGING_FILE_SPACE_BITMAPS : DynamicStructure
    {
        public uint RefCount { get; }
        public IntPtr Anchor { get; }
        public _RTL_BITMAP AllocationBitmap { get; }
        public _RTL_BITMAP ReservationBitmap { get; }
        public _RTL_BITMAP EvictedBitmap { get; }

        public _MI_PAGING_FILE_SPACE_BITMAPS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGING_FILE_SPACE_BITMAPS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGING_FILE_SPACE_BITMAPS.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGING_FILE_SPACE_BITMAPS.Anchor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGING_FILE_SPACE_BITMAPS.AllocationBitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGING_FILE_SPACE_BITMAPS.ReservationBitmap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGING_FILE_SPACE_BITMAPS.EvictedBitmap),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_PAGING_FILE_SPACE_BITMAPS>((mem, ptr) => new _MI_PAGING_FILE_SPACE_BITMAPS(mem, ptr), offsets);
        }
    }
}