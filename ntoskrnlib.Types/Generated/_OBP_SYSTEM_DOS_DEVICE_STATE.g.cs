using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=108)]
public struct _OBP_SYSTEM_DOS_DEVICE_STATE
{
    [FieldOffset(0)]
    public uint GlobalDeviceMap;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=26)]
    public uint[] LocalDeviceCount;
}
