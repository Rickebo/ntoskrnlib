#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _LAZY_WRITER
    {
        [FieldOffset(0)]
        public _KTIMER ScanTimer;
        [FieldOffset(64)]
        public byte TimerInitialized;
        [FieldOffset(65)]
        public byte ScanActive;
        [FieldOffset(66)]
        public byte OtherWork;
        [FieldOffset(67)]
        public byte PendingTeardownScan;
        [FieldOffset(68)]
        public byte PendingPeriodicScan;
        [FieldOffset(69)]
        public byte PendingLowMemoryScan;
        [FieldOffset(70)]
        public byte PendingPowerScan;
        [FieldOffset(71)]
        public byte PendingCoalescingFlushScan;
    }
}