using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct DOCK_INTERFACE
{
    [FieldOffset(0)]
    public ushort Size;
    [FieldOffset(2)]
    public ushort Version;
    [FieldOffset(8)]
    public IntPtr Context;
    [FieldOffset(16)]
    public IntPtr InterfaceReference;
    [FieldOffset(24)]
    public IntPtr InterfaceDereference;
    [FieldOffset(32)]
    public IntPtr ProfileDepartureSetMode;
    [FieldOffset(40)]
    public IntPtr ProfileDepartureUpdate;
}
