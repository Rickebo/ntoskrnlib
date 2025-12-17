using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_THERMAL_INFORMATION")]
    public sealed class _THERMAL_INFORMATION : DynamicStructure
    {
        public uint ThermalStamp { get; }
        public uint ThermalConstant1 { get; }
        public uint ThermalConstant2 { get; }
        public ulong Processors { get; }
        public uint SamplingPeriod { get; }
        public uint CurrentTemperature { get; }
        public uint PassiveTripPoint { get; }
        public uint CriticalTripPoint { get; }
        public byte ActiveTripPointCount { get; }
        public uint[] ActiveTripPoint { get; }

        public _THERMAL_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THERMAL_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THERMAL_INFORMATION.ThermalStamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.ThermalConstant1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.ThermalConstant2),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.Processors),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.SamplingPeriod),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.CurrentTemperature),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.PassiveTripPoint),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.CriticalTripPoint),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.ActiveTripPointCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_THERMAL_INFORMATION.ActiveTripPoint),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_THERMAL_INFORMATION>((mem, ptr) => new _THERMAL_INFORMATION(mem, ptr), offsets);
        }
    }
}