using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KCLOCK_TIMER_DEADLINE_ENTRY
{
    [FieldOffset(0)]
    public ulong DueTime;
    [FieldOffset(8)]
    public uint TolerableDelay;
    [FieldOffset(12)]
    public byte TypeFlags;
}
