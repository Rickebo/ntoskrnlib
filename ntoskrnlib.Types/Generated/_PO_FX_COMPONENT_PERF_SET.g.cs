using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _PO_FX_COMPONENT_PERF_SET
{
    [FieldOffset(0)]
    public _UNICODE_STRING Name;
    [FieldOffset(16)]
    public ulong Flags;
    [FieldOffset(24)]
    public IntPtr Unit;
    [FieldOffset(28)]
    public IntPtr Type;
    [FieldOffset(32)]
    public _unnamed_tag_ Discrete;
    [FieldOffset(32)]
    public _unnamed_tag_ Range;
}
