#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 480)]
    public partial struct _POP_POWER_ACTION
    {
        [FieldOffset(0)]
        public byte Updates;
        [FieldOffset(1)]
        public byte State;
        [FieldOffset(2)]
        public byte Shutdown;
        [FieldOffset(4)]
        public uint Action;
        [FieldOffset(8)]
        public uint LightestState;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public int Status;
        [FieldOffset(20)]
        public uint DeviceType;
        [FieldOffset(24)]
        public uint DeviceTypeFlags;
        [FieldOffset(32)]
        public IntPtr RequestorInformation;
        [FieldOffset(40)]
        public byte IrpMinor;
        [FieldOffset(41)]
        public byte Waking;
        [FieldOffset(44)]
        public uint SystemState;
        [FieldOffset(48)]
        public uint NextSystemState;
        [FieldOffset(52)]
        public uint EffectiveSystemState;
        [FieldOffset(56)]
        public uint CurrentSystemState;
        [FieldOffset(64)]
        public IntPtr ShutdownBugCode;
        [FieldOffset(72)]
        public IntPtr DevState;
        [FieldOffset(80)]
        public IntPtr HiberContext;
        [FieldOffset(88)]
        public ulong WakeTime;
        [FieldOffset(96)]
        public ulong SleepTime;
        [FieldOffset(104)]
        public ulong WakeFirstUnattendedTime;
        [FieldOffset(112)]
        public uint WakeAlarmSignaled;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _unnamed_tag_[] WakeAlarm;
        [FieldOffset(192)]
        public byte WakeAlarmPaused;
        [FieldOffset(200)]
        public ulong WakeAlarmLastTime;
        [FieldOffset(208)]
        public ulong DozeDeferralStartTime;
        [FieldOffset(216)]
        public SYSTEM_POWER_CAPABILITIES FilteredCapabilities;
        [FieldOffset(296)]
        public ulong WatchdogLock;
        [FieldOffset(304)]
        public _KDPC WatchdogDpc;
        [FieldOffset(368)]
        public _KTIMER WatchdogTimer;
        [FieldOffset(432)]
        public byte WatchdogInitialized;
        [FieldOffset(436)]
        public uint WatchdogState;
        [FieldOffset(440)]
        public ulong WatchdogStartTime;
        [FieldOffset(448)]
        public uint WatchdogTimeout;
        [FieldOffset(456)]
        public IntPtr ActionWorkerThread;
        [FieldOffset(464)]
        public IntPtr PromoteActionWorkerThread;
        [FieldOffset(472)]
        public IntPtr UnlockAfterSleepWorkerThread;
    }
}