using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SHARED_CACHE_MAP_LIST_CURSOR")]
    public sealed class _SHARED_CACHE_MAP_LIST_CURSOR : DynamicStructure
    {
        public _LIST_ENTRY SharedCacheMapLinks { get; }
        public uint Flags { get; }

        public _SHARED_CACHE_MAP_LIST_CURSOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SHARED_CACHE_MAP_LIST_CURSOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SHARED_CACHE_MAP_LIST_CURSOR.SharedCacheMapLinks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP_LIST_CURSOR.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SHARED_CACHE_MAP_LIST_CURSOR>((mem, ptr) => new _SHARED_CACHE_MAP_LIST_CURSOR(mem, ptr), offsets);
        }
    }
}