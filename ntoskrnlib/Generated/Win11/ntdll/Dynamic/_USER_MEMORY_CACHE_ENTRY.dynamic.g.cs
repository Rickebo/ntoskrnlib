using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_USER_MEMORY_CACHE_ENTRY")]
    public sealed class _USER_MEMORY_CACHE_ENTRY : DynamicStructure
    {
        public _SLIST_HEADER UserBlocks { get; }
        public uint AvailableBlocks { get; }
        public uint MinimumDepth { get; }
        public uint CacheShiftThreshold { get; }
        public ushort Allocations { get; }
        public ushort Frees { get; }
        public ushort CacheHits { get; }

        public _USER_MEMORY_CACHE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _USER_MEMORY_CACHE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.UserBlocks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.AvailableBlocks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.MinimumDepth),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.CacheShiftThreshold),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.Allocations),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.Frees),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_USER_MEMORY_CACHE_ENTRY.CacheHits),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_USER_MEMORY_CACHE_ENTRY>((mem, ptr) => new _USER_MEMORY_CACHE_ENTRY(mem, ptr), offsets);
        }
    }
}