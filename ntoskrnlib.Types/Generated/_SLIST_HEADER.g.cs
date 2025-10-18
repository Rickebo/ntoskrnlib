using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _SLIST_HEADER
{
    [FieldOffset(0)]
    public ulong Alignment;
    [FieldOffset(8)]
    public ulong Region;
    [FieldOffset(0)]
    public _unnamed_tag_ HeaderX64;
}
