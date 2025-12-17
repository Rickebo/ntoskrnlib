#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1064)]
    public partial struct _PLATFORM_IDLE_ACCOUNTING
    {
        [FieldOffset(0)]
        public uint ResetCount;
        [FieldOffset(4)]
        public uint StateCount;
        [FieldOffset(8)]
        public uint DeepSleepCount;
        [FieldOffset(16)]
        public ulong DripsWakeSkipCount;
        [FieldOffset(24)]
        public uint TimeUnit;
        [FieldOffset(32)]
        public ulong StartTime;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PLATFORM_IDLE_STATE_ACCOUNTING[] State;
    }
}