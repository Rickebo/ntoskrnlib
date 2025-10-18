using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=88)]
public struct _DRIVER_EXTENSION
{
    [FieldOffset(0)]
    public IntPtr DriverObject;
    [FieldOffset(8)]
    public IntPtr AddDevice;
    [FieldOffset(16)]
    public uint Count;
    [FieldOffset(24)]
    public _UNICODE_STRING ServiceKeyName;
    [FieldOffset(40)]
    public IntPtr ClientDriverExtension;
    [FieldOffset(48)]
    public IntPtr FsFilterCallbacks;
    [FieldOffset(56)]
    public IntPtr KseCallbacks;
    [FieldOffset(64)]
    public IntPtr DvCallbacks;
    [FieldOffset(72)]
    public IntPtr VerifierContext;
    [FieldOffset(80)]
    public IntPtr DriverProxyExtension;
}
