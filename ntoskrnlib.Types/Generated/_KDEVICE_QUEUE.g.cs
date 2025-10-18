using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _KDEVICE_QUEUE
{
    [FieldOffset(0)]
    public short Type;
    [FieldOffset(2)]
    public short Size;
    [FieldOffset(8)]
    public _LIST_ENTRY DeviceListHead;
    [FieldOffset(24)]
    public ulong Lock;
    [FieldOffset(32)]
    public byte Busy;
}
