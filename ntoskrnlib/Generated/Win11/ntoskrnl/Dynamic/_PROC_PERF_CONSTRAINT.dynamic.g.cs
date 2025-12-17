using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_CONSTRAINT")]
    public sealed class _PROC_PERF_CONSTRAINT : DynamicStructure
    {
        public IntPtr CheckContext { get; }
        public ulong PerfContext { get; }
        public uint Presence { get; }
        public uint ProcessorId { get; }
        public uint PlatformCap { get; }
        public uint ThermalCap { get; }
        public uint LimitReasons { get; }
        public ulong PlatformCapStartTime { get; }
        public uint ProcCap { get; }
        public uint ProcFloor { get; }
        public uint TargetPercent { get; }
        public byte EngageResponsivenessOverrides { get; }
        public byte ResponsivenessChangeCount { get; }
        public _PERF_CONTROL_STATE_SELECTION Selection { get; }
        public uint DomainSelectionGeneration { get; }
        public uint PreviousFrequency { get; }
        public uint PreviousPercent { get; }
        public uint LatestFrequencyPercent { get; }
        public uint LatestPerformancePercent { get; }
        public byte Force { get; }
        public byte UseQosUpdateLock { get; }
        public ulong QosUpdateLock { get; }
        public uint CurrentLogEntry { get; }
        public byte[] SnapshotLog { get; }
        public uint IncreasePerfCheckCount { get; }
        public uint DecreasePerfCheckCount { get; }

        public _PROC_PERF_CONSTRAINT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_CONSTRAINT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_CONSTRAINT.CheckContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.PerfContext),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.Presence),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.ProcessorId),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.PlatformCap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.ThermalCap),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.LimitReasons),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.PlatformCapStartTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.ProcCap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.ProcFloor),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.TargetPercent),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.EngageResponsivenessOverrides),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.ResponsivenessChangeCount),
                    new ulong[]
                    {
                        61UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.Selection),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.DomainSelectionGeneration),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.PreviousFrequency),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.PreviousPercent),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.LatestFrequencyPercent),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.LatestPerformancePercent),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.Force),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.UseQosUpdateLock),
                    new ulong[]
                    {
                        141UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.QosUpdateLock),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.CurrentLogEntry),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.SnapshotLog),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.IncreasePerfCheckCount),
                    new ulong[]
                    {
                        1184UL
                    }
                },
                {
                    nameof(_PROC_PERF_CONSTRAINT.DecreasePerfCheckCount),
                    new ulong[]
                    {
                        1188UL
                    }
                }
            };
            Register<_PROC_PERF_CONSTRAINT>((mem, ptr) => new _PROC_PERF_CONSTRAINT(mem, ptr), offsets);
        }
    }
}