using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _RTL_BITMAP
{
    [FieldOffset(0)]
    public uint SizeOfBitMap;
    [FieldOffset(8)]
    public IntPtr Buffer;
}
