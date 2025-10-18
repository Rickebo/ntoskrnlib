using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _KQUEUE
{
    [FieldOffset(0)]
    public _DISPATCHER_HEADER Header;
    [FieldOffset(24)]
    public _LIST_ENTRY EntryListHead;
    [FieldOffset(40)]
    public uint CurrentCount;
    [FieldOffset(44)]
    public uint MaximumCount;
    [FieldOffset(48)]
    public _LIST_ENTRY ThreadListHead;
}
