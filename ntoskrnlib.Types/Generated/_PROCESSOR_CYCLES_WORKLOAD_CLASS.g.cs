using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PROCESSOR_CYCLES_WORKLOAD_CLASS
{
    [FieldOffset(0)]
    public uint Count;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ulong[] ProcessorCyclesClass;
}
