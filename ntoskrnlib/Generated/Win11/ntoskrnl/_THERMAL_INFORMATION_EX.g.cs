#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial struct _THERMAL_INFORMATION_EX
    {
        [FieldOffset(0)]
        public uint ThermalStamp;
        [FieldOffset(4)]
        public uint ThermalConstant1;
        [FieldOffset(8)]
        public uint ThermalConstant2;
        [FieldOffset(12)]
        public uint SamplingPeriod;
        [FieldOffset(16)]
        public uint CurrentTemperature;
        [FieldOffset(20)]
        public uint PassiveTripPoint;
        [FieldOffset(24)]
        public uint ThermalStandbyTripPoint;
        [FieldOffset(28)]
        public uint CriticalTripPoint;
        [FieldOffset(32)]
        public byte ActiveTripPointCount;
        [FieldOffset(33)]
        public byte PassiveCoolingDevicesPresent;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] ActiveTripPoint;
        [FieldOffset(76)]
        public uint S4TransitionTripPoint;
        [FieldOffset(80)]
        public uint MinimumThrottle;
        [FieldOffset(84)]
        public uint OverThrottleThreshold;
        [FieldOffset(88)]
        public uint PollingPeriod;
    }
}