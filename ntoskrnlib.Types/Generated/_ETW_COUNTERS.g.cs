using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _ETW_COUNTERS
{
    [FieldOffset(0)]
    public int GuidCount;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public int[] PoolUsage;
    [FieldOffset(12)]
    public int SessionCount;
}
