using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _IO_CLIENT_EXTENSION
{
    [FieldOffset(0)]
    public IntPtr NextExtension;
    [FieldOffset(8)]
    public IntPtr ClientIdentificationAddress;
}
