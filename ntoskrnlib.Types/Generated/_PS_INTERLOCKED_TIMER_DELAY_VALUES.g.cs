using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _PS_INTERLOCKED_TIMER_DELAY_VALUES
{
    [FieldOffset(0)]
    public ulong All;
}
