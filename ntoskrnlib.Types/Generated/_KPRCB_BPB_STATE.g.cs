using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=2)]
public struct _KPRCB_BPB_STATE
{
    [FieldOffset(0)]
    public ushort AllFlags;
}
