using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _KHETERO_HWFEEDBACK_CLASS
{
    [FieldOffset(0)]
    public byte PerformanceClass;
    [FieldOffset(1)]
    public byte EfficiencyClass;
    [FieldOffset(2)]
    public byte PerformanceClassRawValue;
    [FieldOffset(3)]
    public byte EfficiencyClassRawValue;
}
