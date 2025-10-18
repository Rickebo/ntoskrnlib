using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=512)]
public struct _XSAVE_FORMAT
{
    [FieldOffset(0)]
    public ushort ControlWord;
    [FieldOffset(2)]
    public ushort StatusWord;
    [FieldOffset(4)]
    public byte TagWord;
    [FieldOffset(5)]
    public byte Reserved1;
    [FieldOffset(6)]
    public ushort ErrorOpcode;
    [FieldOffset(8)]
    public uint ErrorOffset;
    [FieldOffset(12)]
    public ushort ErrorSelector;
    [FieldOffset(14)]
    public ushort Reserved2;
    [FieldOffset(16)]
    public uint DataOffset;
    [FieldOffset(20)]
    public ushort DataSelector;
    [FieldOffset(22)]
    public ushort Reserved3;
    [FieldOffset(24)]
    public uint MxCsr;
    [FieldOffset(28)]
    public uint MxCsr_Mask;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public byte[] FloatRegisters;
    [FieldOffset(160)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] XmmRegisters;
    [FieldOffset(416)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=96)]
    public byte[] Reserved4;
}
