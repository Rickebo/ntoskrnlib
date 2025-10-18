using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _KLOCK_QUEUE_HANDLE
{
    [FieldOffset(0)]
    public _KSPIN_LOCK_QUEUE LockQueue;
    [FieldOffset(16)]
    public byte OldIrql;
}
