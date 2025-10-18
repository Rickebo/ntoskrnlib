using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _KTIMER_TABLE_STATE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ulong[] LastTimerExpiration;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public uint[] LastTimerHand;
}
