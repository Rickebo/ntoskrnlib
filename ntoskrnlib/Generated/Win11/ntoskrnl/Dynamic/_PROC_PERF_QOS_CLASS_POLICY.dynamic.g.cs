using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_QOS_CLASS_POLICY")]
    public sealed class _PROC_PERF_QOS_CLASS_POLICY : DynamicStructure
    {
        public uint MaxPolicyPercent { get; }
        public uint MaxEquivalentFrequencyPercent { get; }
        public uint MinPolicyPercent { get; }
        public uint AutonomousActivityWindow { get; }
        public uint EnergyPerfPreference { get; }
        public byte ProvideGuidance { get; }
        public byte AllowThrottling { get; }
        public byte PerfBoostMode { get; }
        public byte LatencyHintPerf { get; }
        public byte LatencyHintEpp { get; }
        public byte TrackDesiredCrossClass { get; }
        public uint ResourcePriority { get; }

        public _PROC_PERF_QOS_CLASS_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_QOS_CLASS_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.MaxPolicyPercent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.MaxEquivalentFrequencyPercent),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.MinPolicyPercent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.AutonomousActivityWindow),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.EnergyPerfPreference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.ProvideGuidance),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.AllowThrottling),
                    new ulong[]
                    {
                        21UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.PerfBoostMode),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.LatencyHintPerf),
                    new ulong[]
                    {
                        23UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.LatencyHintEpp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.TrackDesiredCrossClass),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_PROC_PERF_QOS_CLASS_POLICY.ResourcePriority),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_PROC_PERF_QOS_CLASS_POLICY>((mem, ptr) => new _PROC_PERF_QOS_CLASS_POLICY(mem, ptr), offsets);
        }
    }
}