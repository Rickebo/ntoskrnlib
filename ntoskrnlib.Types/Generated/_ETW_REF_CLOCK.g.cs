using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _ETW_REF_CLOCK
{
    [FieldOffset(0)]
    public _LARGE_INTEGER StartTime;
    [FieldOffset(8)]
    public _LARGE_INTEGER StartPerfClock;
}
