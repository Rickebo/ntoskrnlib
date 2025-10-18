using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _KRANK_LIST
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]
    public byte[] Ranks;
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public ulong[] AsUlong64s;
}
