using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=88)]
public struct _POP_DEVICE_POWER_PROFILE
{
    [FieldOffset(0)]
    public _UNICODE_STRING DeviceId;
    [FieldOffset(16)]
    public IntPtr PowerPlane;
    [FieldOffset(24)]
    public IntPtr FxDevice;
    [FieldOffset(32)]
    public int PowerDrawMw;
    [FieldOffset(36)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] DxPower;
    [FieldOffset(72)]
    public ulong ComponentCount;
    [FieldOffset(80)]
    public IntPtr Components;
}
