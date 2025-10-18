using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _KTIMER
{
    [FieldOffset(0)]
    public _DISPATCHER_HEADER Header;
    [FieldOffset(24)]
    public _ULARGE_INTEGER DueTime;
    [FieldOffset(32)]
    public _LIST_ENTRY TimerListEntry;
    [FieldOffset(48)]
    public IntPtr Dpc;
    [FieldOffset(56)]
    public ushort Processor;
    [FieldOffset(58)]
    public ushort TimerType;
    [FieldOffset(60)]
    public uint Period;
}
