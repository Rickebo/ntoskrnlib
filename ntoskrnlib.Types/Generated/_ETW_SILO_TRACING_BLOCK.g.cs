using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _ETW_SILO_TRACING_BLOCK
{
    [FieldOffset(0)]
    public IntPtr ProcessorBuffers;
    [FieldOffset(8)]
    public IntPtr EventsLoggedCount;
    [FieldOffset(16)]
    public IntPtr QpcDelta;
}
