using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _KREQUEST_PACKET
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] CurrentPacket;
    [FieldOffset(24)]
    public IntPtr WorkerRoutine;
}
