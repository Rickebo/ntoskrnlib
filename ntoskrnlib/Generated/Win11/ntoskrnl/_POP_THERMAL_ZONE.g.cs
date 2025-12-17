#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1056)]
    public partial struct _POP_THERMAL_ZONE
    {
        [FieldOffset(0)]
        public _POP_POLICY_DEVICE PolicyDevice;
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public uint DeviceType;
        [FieldOffset(24)]
        public IntPtr Notification;
        [FieldOffset(32)]
        public _UNICODE_STRING Name;
        [FieldOffset(48)]
        public IntPtr Device;
        [FieldOffset(56)]
        public IntPtr Irp;
        [FieldOffset(64)]
        public byte State;
        [FieldOffset(65)]
        public byte Flags;
        [FieldOffset(66)]
        public byte Removing;
        [FieldOffset(67)]
        public byte Mode;
        [FieldOffset(68)]
        public byte PendingMode;
        [FieldOffset(69)]
        public byte ActivePoint;
        [FieldOffset(70)]
        public byte PendingActivePoint;
        [FieldOffset(71)]
        public byte Critical;
        [FieldOffset(72)]
        public byte ThermalStandby;
        [FieldOffset(73)]
        public byte OverThrottled;
        [FieldOffset(76)]
        public int HighPrecisionThrottle;
        [FieldOffset(80)]
        public int Throttle;
        [FieldOffset(84)]
        public int PendingThrottle;
        [FieldOffset(88)]
        public uint ThrottleReasons;
        [FieldOffset(96)]
        public ulong LastPassiveTime;
        [FieldOffset(104)]
        public uint SampleRate;
        [FieldOffset(108)]
        public uint LastTemp;
        [FieldOffset(112)]
        public _THERMAL_INFORMATION_EX Info;
        [FieldOffset(204)]
        public _THERMAL_POLICY Policy;
        [FieldOffset(228)]
        public byte PolicyDriver;
        [FieldOffset(232)]
        public ulong PollingRate;
        [FieldOffset(240)]
        public ulong LastTemperatureTime;
        [FieldOffset(248)]
        public ulong LastActiveStartTime;
        [FieldOffset(256)]
        public ulong LastPassiveStartTime;
        [FieldOffset(264)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(296)]
        public _KTIMER2 ZoneUpdateTimer;
        [FieldOffset(432)]
        public _POP_RW_LOCK Lock;
        [FieldOffset(448)]
        public _KEVENT ZoneStopped;
        [FieldOffset(472)]
        public _KEVENT TemperatureUpdated;
        [FieldOffset(496)]
        public uint InstanceId;
        [FieldOffset(504)]
        public _POP_THERMAL_TELEMETRY_TRACKER TelemetryTracker;
        [FieldOffset(1040)]
        public _UNICODE_STRING Description;
    }
}