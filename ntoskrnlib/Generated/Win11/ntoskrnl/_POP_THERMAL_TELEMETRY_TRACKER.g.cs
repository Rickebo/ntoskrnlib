#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 536)]
    public partial struct _POP_THERMAL_TELEMETRY_TRACKER
    {
        [FieldOffset(0)]
        public byte AccountingDisabled;
        [FieldOffset(1)]
        public byte ActiveLevels;
        [FieldOffset(8)]
        public ulong LastPassiveUpdateTime;
        [FieldOffset(16)]
        public ulong LastActiveUpdateTime;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public ulong[] TotalPassiveTime;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public ulong[] PassiveTimeSnap;
        [FieldOffset(360)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ulong[] TotalActiveTime;
        [FieldOffset(440)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ulong[] ActiveTimeSnap;
        [FieldOffset(520)]
        public ulong TotalTime;
        [FieldOffset(528)]
        public ulong TotalTimeSnap;
    }
}