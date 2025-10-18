using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1)]
public struct _KWAIT_STATUS_REGISTER
{
    [FieldOffset(0)]
    public byte Flags;
}
