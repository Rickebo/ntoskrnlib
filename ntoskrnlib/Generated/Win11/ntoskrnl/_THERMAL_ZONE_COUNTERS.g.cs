#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _THERMAL_ZONE_COUNTERS
    {
        [FieldOffset(0)]
        public uint Temperature;
        [FieldOffset(4)]
        public uint ThrottleLimit;
        [FieldOffset(8)]
        public uint ThrottleReasons;
        [FieldOffset(12)]
        public uint TemperatureHighPrecision;
    }
}