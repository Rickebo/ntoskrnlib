#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _THERMAL_INFORMATION
    {
        [FieldOffset(0)]
        public uint ThermalStamp;
        [FieldOffset(4)]
        public uint ThermalConstant1;
        [FieldOffset(8)]
        public uint ThermalConstant2;
        [FieldOffset(16)]
        public ulong Processors;
        [FieldOffset(24)]
        public uint SamplingPeriod;
        [FieldOffset(28)]
        public uint CurrentTemperature;
        [FieldOffset(32)]
        public uint PassiveTripPoint;
        [FieldOffset(36)]
        public uint CriticalTripPoint;
        [FieldOffset(40)]
        public byte ActiveTripPointCount;
        [FieldOffset(44)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] ActiveTripPoint;
    }
}