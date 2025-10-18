using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _OBJECT_DIRECTORY_ENTRY
{
    [FieldOffset(0)]
    public IntPtr ChainLink;
    [FieldOffset(8)]
    public IntPtr Object;
    [FieldOffset(16)]
    public uint HashValue;
}
