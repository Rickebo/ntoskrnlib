using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KLOCK_ENTRY_BOOST_BITMAP
{
    [FieldOffset(0)]
    public ulong AllFields;
    [FieldOffset(0)]
    public uint AllBoosts;
    [FieldOffset(4)]
    public uint WaiterCounts;
}
