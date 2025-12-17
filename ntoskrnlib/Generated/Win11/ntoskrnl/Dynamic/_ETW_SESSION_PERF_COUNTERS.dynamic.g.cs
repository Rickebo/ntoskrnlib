using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SESSION_PERF_COUNTERS")]
    public sealed class _ETW_SESSION_PERF_COUNTERS : DynamicStructure
    {
        public int BufferMemoryPagedPool { get; }
        public int BufferMemoryNonPagedPool { get; }
        public ulong EventsLoggedCount { get; }
        public int EventsLost { get; }
        public int NumConsumers { get; }

        public _ETW_SESSION_PERF_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SESSION_PERF_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_SESSION_PERF_COUNTERS.BufferMemoryPagedPool),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_SESSION_PERF_COUNTERS.BufferMemoryNonPagedPool),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETW_SESSION_PERF_COUNTERS.EventsLoggedCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_SESSION_PERF_COUNTERS.EventsLost),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_SESSION_PERF_COUNTERS.NumConsumers),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_ETW_SESSION_PERF_COUNTERS>((mem, ptr) => new _ETW_SESSION_PERF_COUNTERS(mem, ptr), offsets);
        }
    }
}