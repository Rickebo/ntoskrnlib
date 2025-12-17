using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_FEEDBACK")]
    public sealed class _PROC_FEEDBACK : DynamicStructure
    {
        public ulong Lock { get; }
        public ulong CyclesLast { get; }
        public ulong CyclesActive { get; }
        public byte[] Counters { get; }
        public ulong LastUpdateTime { get; }
        public ulong UnscaledTime { get; }
        public long UnaccountedTime { get; }
        public ulong[] ScaledTime { get; }
        public ulong UnaccountedKernelTime { get; }
        public ulong PerformanceScaledKernelTime { get; }
        public uint UserTimeLast { get; }
        public uint KernelTimeLast { get; }
        public ulong IdleGenerationNumberLast { get; }
        public ulong HvActiveTimeLast { get; }
        public ulong StallCyclesLast { get; }
        public ulong StallTime { get; }
        public byte KernelTimesIndex { get; }
        public byte CounterDiscardsIdleTime { get; }
        public byte CounterReadOptimize { get; }

        public _PROC_FEEDBACK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_FEEDBACK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_FEEDBACK.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.CyclesLast),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.CyclesActive),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.Counters),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.LastUpdateTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.UnscaledTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.UnaccountedTime),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.ScaledTime),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.UnaccountedKernelTime),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.PerformanceScaledKernelTime),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.UserTimeLast),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.KernelTimeLast),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.IdleGenerationNumberLast),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.HvActiveTimeLast),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.StallCyclesLast),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.StallTime),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.KernelTimesIndex),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.CounterDiscardsIdleTime),
                    new ulong[]
                    {
                        137UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK.CounterReadOptimize),
                    new ulong[]
                    {
                        138UL
                    }
                }
            };
            Register<_PROC_FEEDBACK>((mem, ptr) => new _PROC_FEEDBACK(mem, ptr), offsets);
        }
    }
}