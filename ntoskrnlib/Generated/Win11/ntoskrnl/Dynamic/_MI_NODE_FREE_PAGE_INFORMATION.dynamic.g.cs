using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_NODE_FREE_PAGE_INFORMATION")]
    public sealed class _MI_NODE_FREE_PAGE_INFORMATION : DynamicStructure
    {
        public uint PageColorHand { get; }
        public ulong[] FreeCount { get; }
        public byte[] FreeZeroCountByAttribute { get; }
        public byte[] FreePageListHeadsBitmap { get; }
        public ulong[] FreePageListHeadsBitmapBuffer { get; }
        public byte[] LargePageFreeCountHiLow { get; }
        public byte[] LargePageCount { get; }
        public byte[] LargePageEntries { get; }

        public _MI_NODE_FREE_PAGE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_NODE_FREE_PAGE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.PageColorHand),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.FreeCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.FreeZeroCountByAttribute),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.FreePageListHeadsBitmap),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.FreePageListHeadsBitmapBuffer),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.LargePageFreeCountHiLow),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.LargePageCount),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_MI_NODE_FREE_PAGE_INFORMATION.LargePageEntries),
                    new ulong[]
                    {
                        992UL
                    }
                }
            };
            Register<_MI_NODE_FREE_PAGE_INFORMATION>((mem, ptr) => new _MI_NODE_FREE_PAGE_INFORMATION(mem, ptr), offsets);
        }
    }
}