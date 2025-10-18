using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=160)]
public struct _PEBS_DS_SAVE_AREA
{
    [FieldOffset(0)]
    public _PEBS_DS_SAVE_AREA32 As32Bit;
    [FieldOffset(0)]
    public _PEBS_DS_SAVE_AREA64 As64Bit;
}
