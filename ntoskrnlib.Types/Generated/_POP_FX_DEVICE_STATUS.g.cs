using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _POP_FX_DEVICE_STATUS
{
    [FieldOffset(0)]
    public int Value;
}
