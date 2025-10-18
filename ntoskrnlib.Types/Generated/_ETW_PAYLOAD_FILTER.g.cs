using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=88)]
public struct _ETW_PAYLOAD_FILTER
{
    [FieldOffset(0)]
    public int RefCount;
    [FieldOffset(8)]
    public _AGGREGATED_PAYLOAD_FILTER PayloadFilter;
}
