using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _ETW_LAST_ENABLE_INFO
{
    [FieldOffset(0)]
    public _LARGE_INTEGER EnableFlags;
    [FieldOffset(8)]
    public ushort LoggerId;
    [FieldOffset(10)]
    public byte Level;
}
