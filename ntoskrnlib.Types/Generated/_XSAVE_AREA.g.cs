using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=576)]
public struct _XSAVE_AREA
{
    [FieldOffset(0)]
    public _XSAVE_FORMAT LegacyState;
    [FieldOffset(512)]
    public _XSAVE_AREA_HEADER Header;
}
