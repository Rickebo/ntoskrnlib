using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=80)]
public struct _PLUGPLAY_EVENT_BLOCK
{
    [FieldOffset(0)]
    public _GUID EventGuid;
    [FieldOffset(16)]
    public IntPtr EventCategory;
    [FieldOffset(24)]
    public IntPtr Result;
    [FieldOffset(32)]
    public uint Flags;
    [FieldOffset(36)]
    public uint TotalSize;
    [FieldOffset(40)]
    public IntPtr DeviceObject;
    [FieldOffset(48)]
    public _unnamed_tag_ u;
}
