using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=256)]
public struct _MMWSL_INSTANCE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] PteResumePoint;
    [FieldOffset(24)]
    public uint LastAccessClearingRemainder;
    [FieldOffset(28)]
    public uint LastAgingRemainder;
    [FieldOffset(32)]
    public ulong LockedEntries;
    [FieldOffset(64)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public byte[] ActivePageTableLinks;
}
