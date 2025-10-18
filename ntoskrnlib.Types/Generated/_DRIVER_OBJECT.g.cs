using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=336)]
public struct _DRIVER_OBJECT
{
    [FieldOffset(0)]
    public short Type;
    [FieldOffset(2)]
    public short Size;
    [FieldOffset(8)]
    public IntPtr DeviceObject;
    [FieldOffset(16)]
    public uint Flags;
    [FieldOffset(24)]
    public IntPtr DriverStart;
    [FieldOffset(32)]
    public uint DriverSize;
    [FieldOffset(40)]
    public IntPtr DriverSection;
    [FieldOffset(48)]
    public IntPtr DriverExtension;
    [FieldOffset(56)]
    public _UNICODE_STRING DriverName;
    [FieldOffset(72)]
    public IntPtr HardwareDatabase;
    [FieldOffset(80)]
    public IntPtr FastIoDispatch;
    [FieldOffset(88)]
    public IntPtr DriverInit;
    [FieldOffset(96)]
    public IntPtr DriverStartIo;
    [FieldOffset(104)]
    public IntPtr DriverUnload;
    [FieldOffset(112)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=28)]
    public byte[] MajorFunction;
}
