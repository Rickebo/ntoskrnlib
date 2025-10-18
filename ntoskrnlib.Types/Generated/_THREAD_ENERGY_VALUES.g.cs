using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=200)]
public struct _THREAD_ENERGY_VALUES
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] Cycles;
    [FieldOffset(64)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] AttributedCycles;
    [FieldOffset(128)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] WorkOnBehalfCycles;
    [FieldOffset(192)]
    public _TIMELINE_BITMAP CpuTimeline;
}
