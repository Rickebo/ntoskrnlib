using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_CACHE_ALIGNED_ARRAY")]
    public sealed class _MI_CACHE_ALIGNED_ARRAY : DynamicStructure
    {
        public int Lock { get; }
        public ulong Value { get; }
        public long SignedValue { get; }
        public _MI_CACHE_LINE CacheLinePadding { get; }

        public _MI_CACHE_ALIGNED_ARRAY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_CACHE_ALIGNED_ARRAY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_CACHE_ALIGNED_ARRAY.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHE_ALIGNED_ARRAY.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHE_ALIGNED_ARRAY.SignedValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHE_ALIGNED_ARRAY.CacheLinePadding),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_CACHE_ALIGNED_ARRAY>((mem, ptr) => new _MI_CACHE_ALIGNED_ARRAY(mem, ptr), offsets);
        }
    }
}