#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public partial struct SYSTEM_POWER_CAPABILITIES
    {
        [FieldOffset(0)]
        public byte PowerButtonPresent;
        [FieldOffset(1)]
        public byte SleepButtonPresent;
        [FieldOffset(2)]
        public byte LidPresent;
        [FieldOffset(3)]
        public byte SystemS1;
        [FieldOffset(4)]
        public byte SystemS2;
        [FieldOffset(5)]
        public byte SystemS3;
        [FieldOffset(6)]
        public byte SystemS4;
        [FieldOffset(7)]
        public byte SystemS5;
        [FieldOffset(8)]
        public byte HiberFilePresent;
        [FieldOffset(9)]
        public byte FullWake;
        [FieldOffset(10)]
        public byte VideoDimPresent;
        [FieldOffset(11)]
        public byte ApmPresent;
        [FieldOffset(12)]
        public byte UpsPresent;
        [FieldOffset(13)]
        public byte ThermalControl;
        [FieldOffset(14)]
        public byte ProcessorThrottle;
        [FieldOffset(15)]
        public byte ProcessorMinThrottle;
        [FieldOffset(16)]
        public byte ProcessorMaxThrottle;
        [FieldOffset(17)]
        public byte FastSystemS4;
        [FieldOffset(18)]
        public byte Hiberboot;
        [FieldOffset(19)]
        public byte WakeAlarmPresent;
        [FieldOffset(20)]
        public byte AoAc;
        [FieldOffset(21)]
        public byte DiskSpinDown;
        [FieldOffset(22)]
        public byte HiberFileType;
        [FieldOffset(23)]
        public byte AoAcConnectivitySupported;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] spare3;
        [FieldOffset(30)]
        public byte SystemBatteriesPresent;
        [FieldOffset(31)]
        public byte BatteriesAreShortTerm;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public BATTERY_REPORTING_SCALE[] BatteryScale;
        [FieldOffset(56)]
        public uint AcOnLineWake;
        [FieldOffset(60)]
        public uint SoftLidWake;
        [FieldOffset(64)]
        public uint RtcWake;
        [FieldOffset(68)]
        public uint MinDeviceWakeState;
        [FieldOffset(72)]
        public uint DefaultLowLatencyWake;
    }
}