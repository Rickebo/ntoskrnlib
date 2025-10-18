using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=96)]
public struct _VPB
{
    [FieldOffset(0)]
    public short Type;
    [FieldOffset(2)]
    public short Size;
    [FieldOffset(4)]
    public ushort Flags;
    [FieldOffset(6)]
    public ushort VolumeLabelLength;
    [FieldOffset(8)]
    public IntPtr DeviceObject;
    [FieldOffset(16)]
    public IntPtr RealDevice;
    [FieldOffset(24)]
    public uint SerialNumber;
    [FieldOffset(28)]
    public uint ReferenceCount;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public short[] VolumeLabel;
}
