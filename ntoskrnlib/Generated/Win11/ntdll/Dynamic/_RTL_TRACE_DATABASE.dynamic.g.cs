using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_TRACE_DATABASE")]
    public sealed class _RTL_TRACE_DATABASE : DynamicStructure
    {
        public uint Magic { get; }
        public uint Flags { get; }
        public uint Tag { get; }
        public IntPtr SegmentList { get; }
        public ulong MaximumSize { get; }
        public ulong CurrentSize { get; }
        public IntPtr Owner { get; }
        public _RTL_CRITICAL_SECTION Lock { get; }
        public uint NoOfBuckets { get; }
        public IntPtr Buckets { get; }
        public IntPtr HashFunction { get; }
        public ulong NoOfTraces { get; }
        public ulong NoOfHits { get; }
        public uint[] HashCounter { get; }

        public _RTL_TRACE_DATABASE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_TRACE_DATABASE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_TRACE_DATABASE.Magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.Tag),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.SegmentList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.MaximumSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.CurrentSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.Owner),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.Lock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.NoOfBuckets),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.Buckets),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.HashFunction),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.NoOfTraces),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.NoOfHits),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_RTL_TRACE_DATABASE.HashCounter),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_RTL_TRACE_DATABASE>((mem, ptr) => new _RTL_TRACE_DATABASE(mem, ptr), offsets);
        }
    }
}