using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _KTIMER_TABLE_ENTRY
{
    [FieldOffset(0)]
    public ulong Lock;
    [FieldOffset(8)]
    public _LIST_ENTRY Entry;
    [FieldOffset(24)]
    public _ULARGE_INTEGER Time;
}
