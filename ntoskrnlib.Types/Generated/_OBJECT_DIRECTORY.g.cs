using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=344)]
public struct _OBJECT_DIRECTORY
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=37)]
    public byte[] HashBuckets;
    [FieldOffset(296)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(304)]
    public IntPtr DeviceMap;
    [FieldOffset(312)]
    public IntPtr ShadowDirectory;
    [FieldOffset(320)]
    public IntPtr NamespaceEntry;
    [FieldOffset(328)]
    public IntPtr SessionObject;
    [FieldOffset(336)]
    public uint Flags;
    [FieldOffset(340)]
    public uint SessionId;
}
