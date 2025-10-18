using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _OBJECT_NAME_INFORMATION
{
    [FieldOffset(0)]
    public _UNICODE_STRING Name;
}
