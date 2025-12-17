using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGEFILE_BITMAPS_CACHE_ENTRY")]
    public sealed class _MI_PAGEFILE_BITMAPS_CACHE_ENTRY : DynamicStructure
    {
        public _RTL_BALANCED_NODE LengthTreeNode { get; }
        public _LIST_ENTRY FreeListEntry { get; }
        public _RTL_BALANCED_NODE LocationTreeNode { get; }
        public uint StartingIndex { get; }
        public uint Length { get; }

        public _MI_PAGEFILE_BITMAPS_CACHE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGEFILE_BITMAPS_CACHE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGEFILE_BITMAPS_CACHE_ENTRY.LengthTreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_BITMAPS_CACHE_ENTRY.FreeListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_BITMAPS_CACHE_ENTRY.LocationTreeNode),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_BITMAPS_CACHE_ENTRY.StartingIndex),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_BITMAPS_CACHE_ENTRY.Length),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_MI_PAGEFILE_BITMAPS_CACHE_ENTRY>((mem, ptr) => new _MI_PAGEFILE_BITMAPS_CACHE_ENTRY(mem, ptr), offsets);
        }
    }
}