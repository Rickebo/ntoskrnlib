#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _PS_INTERLOCKED_TIMER_DELAY_VALUES
    {
        [FieldOffset(0)]
        public ulong DelayMs;
        [FieldOffset(0)]
        public ulong CoalescingWindowMs;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong NewTimerWheel;
        [FieldOffset(0)]
        public ulong Retry;
        [FieldOffset(0)]
        public ulong Locked;
        [FieldOffset(0)]
        public ulong All;
    }
}