using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LIST_LOOKUP")]
    public sealed class _HEAP_LIST_LOOKUP : DynamicStructure
    {
        public IntPtr ExtendedLookup { get; }
        public uint ArraySize { get; }
        public uint ExtraItem { get; }
        public uint ItemCount { get; }
        public uint OutOfRangeItems { get; }
        public uint BaseIndex { get; }
        public IntPtr ListHead { get; }
        public IntPtr ListsInUseUlong { get; }
        public IntPtr ListHints { get; }

        public _HEAP_LIST_LOOKUP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LIST_LOOKUP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LIST_LOOKUP.ExtendedLookup),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.ArraySize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.ExtraItem),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.ItemCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.OutOfRangeItems),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.BaseIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.ListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.ListsInUseUlong),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_LIST_LOOKUP.ListHints),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_HEAP_LIST_LOOKUP>((mem, ptr) => new _HEAP_LIST_LOOKUP(mem, ptr), offsets);
        }
    }
}