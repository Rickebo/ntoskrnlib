using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=112)]
public struct _DEVOBJ_EXTENSION
{
    [FieldOffset(0)]
    public short Type;
    [FieldOffset(2)]
    public ushort Size;
    [FieldOffset(8)]
    public IntPtr DeviceObject;
    [FieldOffset(16)]
    public uint PowerFlags;
    [FieldOffset(24)]
    public IntPtr Dope;
    [FieldOffset(32)]
    public uint ExtensionFlags;
    [FieldOffset(40)]
    public IntPtr DeviceNode;
    [FieldOffset(48)]
    public IntPtr AttachedTo;
    [FieldOffset(56)]
    public int StartIoCount;
    [FieldOffset(60)]
    public int StartIoKey;
    [FieldOffset(64)]
    public uint StartIoFlags;
    [FieldOffset(72)]
    public IntPtr Vpb;
    [FieldOffset(80)]
    public IntPtr DependencyNode;
    [FieldOffset(88)]
    public IntPtr InterruptContext;
    [FieldOffset(96)]
    public int InterruptCount;
    [FieldOffset(104)]
    public IntPtr VerifierContext;
}
