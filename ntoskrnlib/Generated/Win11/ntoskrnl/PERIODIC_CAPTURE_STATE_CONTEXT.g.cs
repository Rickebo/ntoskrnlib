#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct PERIODIC_CAPTURE_STATE_CONTEXT
    {
        [FieldOffset(0)]
        public long RelativeTimerDueTime;
        [FieldOffset(8)]
        public IntPtr Timer;
        [FieldOffset(16)]
        public _PERIODIC_CAPTURE_STATE_GUIDS Guids;
        [FieldOffset(32)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(64)]
        public uint TimerState;
    }
}