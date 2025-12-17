#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _KCLOCK_TICK_TRACE
    {
        [FieldOffset(0)]
        public ulong PerformanceCounter;
        [FieldOffset(8)]
        public ulong PreInterruptTime;
        [FieldOffset(16)]
        public ulong PostInterruptTime;
        [FieldOffset(24)]
        public ulong TimeStampCounter;
        [FieldOffset(32)]
        public byte IsClockOwner;
    }
}