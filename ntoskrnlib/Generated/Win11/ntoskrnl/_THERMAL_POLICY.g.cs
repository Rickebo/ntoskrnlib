#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _THERMAL_POLICY
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public byte WaitForUpdate;
        [FieldOffset(5)]
        public byte Hibernate;
        [FieldOffset(6)]
        public byte Critical;
        [FieldOffset(7)]
        public byte ThermalStandby;
        [FieldOffset(8)]
        public uint ActivationReasons;
        [FieldOffset(12)]
        public uint PassiveLimit;
        [FieldOffset(16)]
        public uint ActiveLevel;
        [FieldOffset(20)]
        public byte OverThrottled;
    }
}