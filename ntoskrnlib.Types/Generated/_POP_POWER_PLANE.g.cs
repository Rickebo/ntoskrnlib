using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _POP_POWER_PLANE
{
    [FieldOffset(0)]
    public _UNICODE_STRING PowerPlaneId;
    [FieldOffset(16)]
    public ulong Lock;
    [FieldOffset(24)]
    public byte OldIrql;
    [FieldOffset(28)]
    public int DevicePowerMw;
    [FieldOffset(32)]
    public IntPtr PmaxHandle;
    [FieldOffset(40)]
    public IntPtr NotifyDevicePowerDraw;
    [FieldOffset(48)]
    public ulong DeviceCount;
    [FieldOffset(56)]
    public IntPtr Devices;
}
