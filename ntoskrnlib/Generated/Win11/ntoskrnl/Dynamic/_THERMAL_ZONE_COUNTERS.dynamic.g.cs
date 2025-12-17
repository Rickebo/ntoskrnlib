using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_THERMAL_ZONE_COUNTERS")]
    public sealed class _THERMAL_ZONE_COUNTERS : DynamicStructure
    {
        public uint Temperature { get; }
        public uint ThrottleLimit { get; }
        public uint ThrottleReasons { get; }
        public uint TemperatureHighPrecision { get; }

        public _THERMAL_ZONE_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THERMAL_ZONE_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THERMAL_ZONE_COUNTERS.Temperature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THERMAL_ZONE_COUNTERS.ThrottleLimit),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_THERMAL_ZONE_COUNTERS.ThrottleReasons),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_THERMAL_ZONE_COUNTERS.TemperatureHighPrecision),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_THERMAL_ZONE_COUNTERS>((mem, ptr) => new _THERMAL_ZONE_COUNTERS(mem, ptr), offsets);
        }
    }
}