using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_PERF_SNAPSHOT")]
    public sealed class _PPM_PERF_SNAPSHOT : DynamicStructure
    {
        public uint Initiator { get; }
        public byte LogType { get; }
        public byte Reset { get; }
        public byte Remote { get; }
        public ulong InterruptTime { get; }
        public ulong RawUnscaledTime { get; }
        public ulong TotalUnscaleTime { get; }
        public uint[] CachedScalingFactor { get; }
        public ulong[] RawReferenceCount { get; }
        public ulong[] RawActualCount { get; }
        public ulong[] RawScaledTime { get; }
        public ulong[] TotalScaleTime { get; }
        public ulong HvCurrentTime { get; }
        public ulong IdleAccumulation { get; }
        public uint[] Value { get; }

        public _PPM_PERF_SNAPSHOT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_PERF_SNAPSHOT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_PERF_SNAPSHOT.Initiator),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.LogType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.Reset),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.Remote),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.InterruptTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.RawUnscaledTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.TotalUnscaleTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.CachedScalingFactor),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.RawReferenceCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.RawActualCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.RawScaledTime),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.TotalScaleTime),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.HvCurrentTime),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.IdleAccumulation),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PPM_PERF_SNAPSHOT.Value),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_PPM_PERF_SNAPSHOT>((mem, ptr) => new _PPM_PERF_SNAPSHOT(mem, ptr), offsets);
        }
    }
}