using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=472)]
public struct _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK
{
    [FieldOffset(0)]
    public _KI_PROCESS_CONCURRENCY_COUNT ExpectedConcurrencyCount;
    [FieldOffset(4)]
    public _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS Breakpoints;
    [FieldOffset(12)]
    public _unnamed_tag_ AssignmentFlags;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ushort[] ThreadSeed;
    [FieldOffset(80)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ushort[] IdealProcessor;
    [FieldOffset(144)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ushort[] IdealNode;
    [FieldOffset(208)]
    public _KAFFINITY_EX IdealProcessorSets;
}
