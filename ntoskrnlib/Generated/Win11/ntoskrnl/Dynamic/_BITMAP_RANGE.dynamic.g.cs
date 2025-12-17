using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BITMAP_RANGE")]
    public sealed class _BITMAP_RANGE : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public long BasePage { get; }
        public uint FirstDirtyPage { get; }
        public uint LastDirtyPage { get; }
        public uint DirtyPages { get; }
        public IntPtr Bitmap { get; }

        public _BITMAP_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BITMAP_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BITMAP_RANGE.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BITMAP_RANGE.BasePage),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_BITMAP_RANGE.FirstDirtyPage),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_BITMAP_RANGE.LastDirtyPage),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_BITMAP_RANGE.DirtyPages),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_BITMAP_RANGE.Bitmap),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_BITMAP_RANGE>((mem, ptr) => new _BITMAP_RANGE(mem, ptr), offsets);
        }
    }
}