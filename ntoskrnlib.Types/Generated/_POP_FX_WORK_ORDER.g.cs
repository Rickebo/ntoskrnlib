using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _POP_FX_WORK_ORDER
{
    [FieldOffset(0)]
    public _WORK_QUEUE_ITEM WorkItem;
    [FieldOffset(32)]
    public int WorkCount;
    [FieldOffset(40)]
    public IntPtr Context;
    [FieldOffset(48)]
    public IntPtr WatchdogTimerInfo;
}
