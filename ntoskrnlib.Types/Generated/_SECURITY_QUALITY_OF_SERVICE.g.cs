using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _SECURITY_QUALITY_OF_SERVICE
{
    [FieldOffset(0)]
    public uint Length;
    [FieldOffset(4)]
    public IntPtr ImpersonationLevel;
    [FieldOffset(8)]
    public byte ContextTrackingMode;
    [FieldOffset(9)]
    public byte EffectiveOnly;
}
