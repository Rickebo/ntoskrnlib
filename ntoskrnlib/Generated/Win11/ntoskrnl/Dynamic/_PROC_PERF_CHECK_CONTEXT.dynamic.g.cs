using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_CHECK_CONTEXT")]
    public sealed class _PROC_PERF_CHECK_CONTEXT : DynamicStructure
    {
        public IntPtr Domain { get; }
        public IntPtr Constraint { get; }
        public IntPtr PerfCheck { get; }
        public IntPtr Load { get; }
        public IntPtr PerfHistory { get; }
        public uint Utility { get; }
        public uint AffinitizedUtility { get; }
        public uint MediaUtility { get; }
        public uint ImportantUtility { get; }
        public uint IdealUtility { get; }
        public ushort LatestAffinitizedPercent { get; }
        public ushort AveragePerformancePercent { get; }
        public uint RelativePerformance { get; }
        public byte NtProcessor { get; }

        public _PROC_PERF_CHECK_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_CHECK_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.Domain),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.Constraint),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.PerfCheck),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.Load),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.PerfHistory),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.Utility),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.AffinitizedUtility),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.MediaUtility),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.ImportantUtility),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.IdealUtility),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.LatestAffinitizedPercent),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.AveragePerformancePercent),
                    new ulong[]
                    {
                        62UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.RelativePerformance),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CONTEXT.NtProcessor),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_PROC_PERF_CHECK_CONTEXT>((mem, ptr) => new _PROC_PERF_CHECK_CONTEXT(mem, ptr), offsets);
        }
    }
}