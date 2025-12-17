using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_BUCKET_COUNTERS")]
    public sealed class _HEAP_BUCKET_COUNTERS : DynamicStructure
    {
        public uint TotalBlocks { get; }
        public uint SubSegmentCounts { get; }
        public long Aggregate64 { get; }

        public _HEAP_BUCKET_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_BUCKET_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_BUCKET_COUNTERS.TotalBlocks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET_COUNTERS.SubSegmentCounts),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET_COUNTERS.Aggregate64),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_BUCKET_COUNTERS>((mem, ptr) => new _HEAP_BUCKET_COUNTERS(mem, ptr), offsets);
        }
    }
}