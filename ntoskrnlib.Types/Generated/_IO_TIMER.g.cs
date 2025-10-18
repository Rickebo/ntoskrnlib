using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _IO_TIMER
{
    [FieldOffset(0)]
    public short Type;
    [FieldOffset(2)]
    public short TimerFlag;
    [FieldOffset(8)]
    public _LIST_ENTRY TimerList;
    [FieldOffset(24)]
    public IntPtr TimerRoutine;
    [FieldOffset(32)]
    public IntPtr Context;
    [FieldOffset(40)]
    public IntPtr DeviceObject;
}
