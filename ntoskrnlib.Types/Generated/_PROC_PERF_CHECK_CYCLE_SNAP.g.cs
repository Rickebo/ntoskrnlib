using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _PROC_PERF_CHECK_CYCLE_SNAP
{
    [FieldOffset(0)]
    public ulong CyclesActive;
    [FieldOffset(8)]
    public ulong CyclesAffinitized;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ulong[] TaggedThreadCycles;
    [FieldOffset(48)]
    public uint WorkloadClasses;
    [FieldOffset(56)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ulong[] ThreadTypeCycles;
}
