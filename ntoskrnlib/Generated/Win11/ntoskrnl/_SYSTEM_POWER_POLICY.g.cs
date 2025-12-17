#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 232)]
    public partial struct _SYSTEM_POWER_POLICY
    {
        [FieldOffset(0)]
        public uint Revision;
        [FieldOffset(4)]
        public POWER_ACTION_POLICY PowerButton;
        [FieldOffset(16)]
        public POWER_ACTION_POLICY SleepButton;
        [FieldOffset(28)]
        public POWER_ACTION_POLICY LidClose;
        [FieldOffset(40)]
        public uint LidOpenWake;
        [FieldOffset(44)]
        public uint Reserved;
        [FieldOffset(48)]
        public POWER_ACTION_POLICY Idle;
        [FieldOffset(60)]
        public uint IdleTimeout;
        [FieldOffset(64)]
        public byte IdleSensitivity;
        [FieldOffset(65)]
        public byte DynamicThrottle;
        [FieldOffset(66)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Spare2;
        [FieldOffset(68)]
        public uint MinSleep;
        [FieldOffset(72)]
        public uint MaxSleep;
        [FieldOffset(76)]
        public uint ReducedLatencySleep;
        [FieldOffset(80)]
        public uint WinLogonFlags;
        [FieldOffset(84)]
        public uint Spare3;
        [FieldOffset(88)]
        public uint DozeS4Timeout;
        [FieldOffset(92)]
        public uint BroadcastCapacityResolution;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public SYSTEM_POWER_LEVEL[] DischargePolicy;
        [FieldOffset(192)]
        public uint VideoTimeout;
        [FieldOffset(196)]
        public byte VideoDimDisplay;
        [FieldOffset(200)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] VideoReserved;
        [FieldOffset(212)]
        public uint SpindownTimeout;
        [FieldOffset(216)]
        public byte OptimizeForPower;
        [FieldOffset(217)]
        public byte FanThrottleTolerance;
        [FieldOffset(218)]
        public byte ForcedThrottle;
        [FieldOffset(219)]
        public byte MinThrottle;
        [FieldOffset(220)]
        public POWER_ACTION_POLICY OverThrottled;
    }
}