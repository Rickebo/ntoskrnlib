using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PERF_COUNTERS")]
    public sealed class _ETW_PERF_COUNTERS : DynamicStructure
    {
        public int TotalActiveSessions { get; }
        public int TotalBufferMemoryNonPagedPool { get; }
        public int TotalBufferMemoryPagedPool { get; }
        public int TotalGuidsEnabled { get; }
        public int TotalGuidsNotEnabled { get; }
        public int TotalGuidsPreEnabled { get; }

        public _ETW_PERF_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PERF_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_PERF_COUNTERS.TotalActiveSessions),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_PERF_COUNTERS.TotalBufferMemoryNonPagedPool),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETW_PERF_COUNTERS.TotalBufferMemoryPagedPool),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_PERF_COUNTERS.TotalGuidsEnabled),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ETW_PERF_COUNTERS.TotalGuidsNotEnabled),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_PERF_COUNTERS.TotalGuidsPreEnabled),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_ETW_PERF_COUNTERS>((mem, ptr) => new _ETW_PERF_COUNTERS(mem, ptr), offsets);
        }
    }
}