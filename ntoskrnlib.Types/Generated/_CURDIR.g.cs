using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _CURDIR
{
    [FieldOffset(0)]
    public _UNICODE_STRING DosPath;
    [FieldOffset(16)]
    public IntPtr Handle;
}
