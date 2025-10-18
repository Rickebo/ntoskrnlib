using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _MACHINE_FRAME
{
    [FieldOffset(0)]
    public ulong Rip;
    [FieldOffset(8)]
    public ushort SegCs;
    [FieldOffset(10)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public ushort[] Fill1;
    [FieldOffset(16)]
    public uint EFlags;
    [FieldOffset(20)]
    public uint Fill2;
    [FieldOffset(24)]
    public ulong Rsp;
    [FieldOffset(32)]
    public ushort SegSs;
    [FieldOffset(34)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public ushort[] Fill3;
}
