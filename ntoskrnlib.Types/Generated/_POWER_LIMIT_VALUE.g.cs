using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _POWER_LIMIT_VALUE
{
    [FieldOffset(0)]
    public IntPtr Type;
    [FieldOffset(4)]
    public uint DomainId;
    [FieldOffset(8)]
    public uint TargetValue;
    [FieldOffset(12)]
    public uint TimeParameter;
}
