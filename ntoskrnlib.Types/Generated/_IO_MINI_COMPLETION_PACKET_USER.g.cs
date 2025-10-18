using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=80)]
public struct _IO_MINI_COMPLETION_PACKET_USER
{
    [FieldOffset(0)]
    public _LIST_ENTRY ListEntry;
    [FieldOffset(16)]
    public uint PacketType;
    [FieldOffset(24)]
    public IntPtr KeyContext;
    [FieldOffset(32)]
    public IntPtr ApcContext;
    [FieldOffset(40)]
    public int IoStatus;
    [FieldOffset(48)]
    public ulong IoStatusInformation;
    [FieldOffset(56)]
    public IntPtr MiniPacketCallback;
    [FieldOffset(64)]
    public IntPtr Context;
    [FieldOffset(72)]
    public byte Allocated;
}
