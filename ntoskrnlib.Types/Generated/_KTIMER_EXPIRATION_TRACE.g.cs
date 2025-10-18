using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KTIMER_EXPIRATION_TRACE
{
    [FieldOffset(0)]
    public ulong InterruptTime;
    [FieldOffset(8)]
    public _LARGE_INTEGER PerformanceCounter;
}
