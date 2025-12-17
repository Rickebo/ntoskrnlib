using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PRIVATE_CACHE_MAP_FLAGS")]
    public sealed class _PRIVATE_CACHE_MAP_FLAGS : DynamicStructure
    {
        public uint DontUse { get; }
        public uint ReadAheadActive { get; }
        public uint ReadAheadEnabled { get; }
        public uint PagePriority { get; }
        public uint PipelineReadAheads { get; }
        public uint Available { get; }
        public uint EntireField { get; }

        public _PRIVATE_CACHE_MAP_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PRIVATE_CACHE_MAP_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.DontUse),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.ReadAheadActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.ReadAheadEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.PagePriority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.PipelineReadAheads),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.Available),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PRIVATE_CACHE_MAP_FLAGS>((mem, ptr) => new _PRIVATE_CACHE_MAP_FLAGS(mem, ptr), offsets);
        }
    }
}