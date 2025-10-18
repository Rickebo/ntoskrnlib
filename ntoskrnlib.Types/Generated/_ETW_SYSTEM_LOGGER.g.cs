using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=2)]
public struct _ETW_SYSTEM_LOGGER
{
    [FieldOffset(0)]
    public byte LoggerId;
    [FieldOffset(1)]
    public byte ClockType;
}
