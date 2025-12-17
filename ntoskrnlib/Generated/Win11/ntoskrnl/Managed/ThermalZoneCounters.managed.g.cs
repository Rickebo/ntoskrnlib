using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_THERMAL_ZONE_COUNTERS")]
    public sealed class ThermalZoneCounters : DynamicStructure
    {
        [Offset(0UL)]
        public uint Temperature { get => ReadHere<uint>(nameof(Temperature)); set => WriteHere(nameof(Temperature), value); }

        [Offset(4UL)]
        public uint ThrottleLimit { get => ReadHere<uint>(nameof(ThrottleLimit)); set => WriteHere(nameof(ThrottleLimit), value); }

        [Offset(8UL)]
        public uint ThrottleReasons { get => ReadHere<uint>(nameof(ThrottleReasons)); set => WriteHere(nameof(ThrottleReasons), value); }

        [Offset(12UL)]
        public uint TemperatureHighPrecision { get => ReadHere<uint>(nameof(TemperatureHighPrecision)); set => WriteHere(nameof(TemperatureHighPrecision), value); }

        public ThermalZoneCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ThermalZoneCounters>();
        }
    }
}