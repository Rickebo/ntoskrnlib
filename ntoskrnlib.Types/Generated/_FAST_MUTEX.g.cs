using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _FAST_MUTEX
{
    [FieldOffset(0)]
    public int Count;
    [FieldOffset(8)]
    public IntPtr Owner;
    [FieldOffset(16)]
    public uint Contention;
    [FieldOffset(24)]
    public _KEVENT Event;
    [FieldOffset(48)]
    public uint OldIrql;
}
