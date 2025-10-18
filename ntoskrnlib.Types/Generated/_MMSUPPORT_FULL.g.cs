using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=320)]
public struct _MMSUPPORT_FULL
{
    [FieldOffset(0)]
    public _MMSUPPORT_INSTANCE Instance;
    [FieldOffset(192)]
    public _MMSUPPORT_SHARED Shared;
}
