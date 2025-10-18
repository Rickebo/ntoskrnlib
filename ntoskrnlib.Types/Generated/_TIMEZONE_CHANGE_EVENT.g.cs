using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=160)]
public struct _TIMEZONE_CHANGE_EVENT
{
    [FieldOffset(0)]
    public _KDPC Dpc;
    [FieldOffset(64)]
    public _KTIMER Timer;
    [FieldOffset(128)]
    public _WORK_QUEUE_ITEM WorkItem;
}
