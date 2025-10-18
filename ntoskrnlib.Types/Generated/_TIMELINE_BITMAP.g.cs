using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _TIMELINE_BITMAP
{
    [FieldOffset(0)]
    public ulong Value;
    [FieldOffset(0)]
    public uint EndTime;
    [FieldOffset(4)]
    public uint Bitmap;
}
