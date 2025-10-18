using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _KSEMAPHORE
{
    [FieldOffset(0)]
    public _DISPATCHER_HEADER Header;
    [FieldOffset(24)]
    public int Limit;
}
