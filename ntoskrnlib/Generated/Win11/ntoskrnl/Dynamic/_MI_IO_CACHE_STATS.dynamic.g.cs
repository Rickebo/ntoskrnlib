using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_IO_CACHE_STATS")]
    public sealed class _MI_IO_CACHE_STATS : DynamicStructure
    {
        public uint UnmappedCacheFlush { get; }
        public uint UnmappedCacheConflict { get; }
        public uint PermanentIoAttributeConflict { get; }
        public uint PermanentIoNodeConflict { get; }
        public uint ExclusionReferenceConflict { get; }

        public _MI_IO_CACHE_STATS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_IO_CACHE_STATS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_IO_CACHE_STATS.UnmappedCacheFlush),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IO_CACHE_STATS.UnmappedCacheConflict),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_IO_CACHE_STATS.PermanentIoAttributeConflict),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_IO_CACHE_STATS.PermanentIoNodeConflict),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_IO_CACHE_STATS.ExclusionReferenceConflict),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MI_IO_CACHE_STATS>((mem, ptr) => new _MI_IO_CACHE_STATS(mem, ptr), offsets);
        }
    }
}