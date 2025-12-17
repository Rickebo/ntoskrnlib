#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1304)]
    public partial struct _KCLOCK_TIMER_STATE
    {
        [FieldOffset(0)]
        public ulong NextTickDueTime;
        [FieldOffset(8)]
        public uint TimeIncrement;
        [FieldOffset(12)]
        public uint LastRequestedTimeIncrement;
        [FieldOffset(16)]
        public uint OneShotState;
        [FieldOffset(20)]
        public uint ExpectedWakeReason;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public _KCLOCK_TIMER_DEADLINE_ENTRY[] ClockTimerEntries;
        [FieldOffset(136)]
        public byte ClockActive;
        [FieldOffset(137)]
        public byte ClockArmedForIdle;
        [FieldOffset(140)]
        public uint ClockTickTraceIndex;
        [FieldOffset(144)]
        public uint ClockIncrementTraceIndex;
        [FieldOffset(152)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _KCLOCK_TICK_TRACE[] ClockTickTraces;
        [FieldOffset(792)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _KCLOCK_INCREMENT_TRACE[] ClockIncrementTraces;
    }
}