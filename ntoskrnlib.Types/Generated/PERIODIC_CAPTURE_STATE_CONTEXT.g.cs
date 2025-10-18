using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=72)]
public struct PERIODIC_CAPTURE_STATE_CONTEXT
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
    public IntPtr TimerState;
}
