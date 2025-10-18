using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=296)]
public struct _DEVICE_MAP
{
    [FieldOffset(0)]
    public IntPtr DosDevicesDirectory;
    [FieldOffset(8)]
    public IntPtr GlobalDosDevicesDirectory;
    [FieldOffset(16)]
    public IntPtr ServerSilo;
    [FieldOffset(24)]
    public IntPtr GlobalDeviceMap;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=26)]
    public byte[] DriveObject;
    [FieldOffset(240)]
    public long ReferenceCount;
    [FieldOffset(248)]
    public IntPtr DosDevicesDirectoryHandle;
    [FieldOffset(256)]
    public uint DriveMap;
    [FieldOffset(260)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] DriveType;
}
