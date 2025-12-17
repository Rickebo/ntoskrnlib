using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_THERMAL_TELEMETRY_TRACKER")]
    public sealed class _POP_THERMAL_TELEMETRY_TRACKER : DynamicStructure
    {
        public byte AccountingDisabled { get; }
        public byte ActiveLevels { get; }
        public ulong LastPassiveUpdateTime { get; }
        public ulong LastActiveUpdateTime { get; }
        public ulong[] TotalPassiveTime { get; }
        public ulong[] PassiveTimeSnap { get; }
        public ulong[] TotalActiveTime { get; }
        public ulong[] ActiveTimeSnap { get; }
        public ulong TotalTime { get; }
        public ulong TotalTimeSnap { get; }

        public _POP_THERMAL_TELEMETRY_TRACKER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_THERMAL_TELEMETRY_TRACKER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.AccountingDisabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.ActiveLevels),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.LastPassiveUpdateTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.LastActiveUpdateTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.TotalPassiveTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.PassiveTimeSnap),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.TotalActiveTime),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.ActiveTimeSnap),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.TotalTime),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_POP_THERMAL_TELEMETRY_TRACKER.TotalTimeSnap),
                    new ulong[]
                    {
                        528UL
                    }
                }
            };
            Register<_POP_THERMAL_TELEMETRY_TRACKER>((mem, ptr) => new _POP_THERMAL_TELEMETRY_TRACKER(mem, ptr), offsets);
        }
    }
}