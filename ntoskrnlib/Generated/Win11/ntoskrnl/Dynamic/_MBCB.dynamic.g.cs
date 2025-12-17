using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MBCB")]
    public sealed class _MBCB : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeIsInZone { get; }
        public uint PagesToWrite { get; }
        public uint DirtyPages { get; }
        public uint Reserved { get; }
        public _LIST_ENTRY BitmapRanges { get; }
        public long ResumeWritePage { get; }
        public long MostRecentlyDirtiedPage { get; }
        public _BITMAP_RANGE BitmapRange1 { get; }
        public _BITMAP_RANGE BitmapRange2 { get; }
        public _BITMAP_RANGE BitmapRange3 { get; }

        public _MBCB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MBCB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MBCB.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MBCB.NodeIsInZone),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MBCB.PagesToWrite),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MBCB.DirtyPages),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MBCB.Reserved),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MBCB.BitmapRanges),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MBCB.ResumeWritePage),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MBCB.MostRecentlyDirtiedPage),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MBCB.BitmapRange1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MBCB.BitmapRange2),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MBCB.BitmapRange3),
                    new ulong[]
                    {
                        144UL
                    }
                }
            };
            Register<_MBCB>((mem, ptr) => new _MBCB(mem, ptr), offsets);
        }
    }
}