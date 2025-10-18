using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _KEVENT
{
    [FieldOffset(0)]
    public _DISPATCHER_HEADER Header;
}
