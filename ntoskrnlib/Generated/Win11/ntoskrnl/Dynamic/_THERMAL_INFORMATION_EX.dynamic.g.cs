using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_THERMAL_INFORMATION_EX")]
    public sealed class _THERMAL_INFORMATION_EX : DynamicStructure
    {
        public uint ThermalStamp { get; }
        public uint ThermalConstant1 { get; }
        public uint ThermalConstant2 { get; }
        public uint SamplingPeriod { get; }
        public uint CurrentTemperature { get; }
        public uint PassiveTripPoint { get; }
        public uint ThermalStandbyTripPoint { get; }
        public uint CriticalTripPoint { get; }
        public byte ActiveTripPointCount { get; }
        public byte PassiveCoolingDevicesPresent { get; }
        public uint[] ActiveTripPoint { get; }
        public uint S4TransitionTripPoint { get; }
        public uint MinimumThrottle { get; }
        public uint OverThrottleThreshold { get; }
        public uint PollingPeriod { get; }

        public _THERMAL_INFORMATION_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THERMAL_INFORMATION_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THERMAL_INFORMATION_EX.ThermalStamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.ThermalConstant1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.ThermalConstant2),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.SamplingPeriod),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.CurrentTemperature),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.PassiveTripPoint),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.ThermalStandbyTripPoint),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.CriticalTripPoint),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.ActiveTripPointCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.PassiveCoolingDevicesPresent),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.ActiveTripPoint),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.S4TransitionTripPoint),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.MinimumThrottle),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.OverThrottleThreshold),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION_EX.PollingPeriod),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_THERMAL_INFORMATION_EX>((mem, ptr) => new _THERMAL_INFORMATION_EX(mem, ptr), offsets);
        }
    }
}