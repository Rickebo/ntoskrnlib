using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _POP_COMPONENT_POWER_PROFILE
{
    [FieldOffset(0)]
    public _GUID ComponentGuid;
    [FieldOffset(16)]
    public IntPtr Device;
    [FieldOffset(24)]
    public ulong FxCount;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] FxPower;
}
