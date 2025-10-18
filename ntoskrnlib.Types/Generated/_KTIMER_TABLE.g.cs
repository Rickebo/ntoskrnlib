using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16920)]
public struct _KTIMER_TABLE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]
    public byte[] TimerExpiry;
    [FieldOffset(512)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] TimerEntries;
    [FieldOffset(16896)]
    public _KTIMER_TABLE_STATE TableState;
}
