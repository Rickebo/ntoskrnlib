using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _POP_FX_PERF_SET
{
    [FieldOffset(0)]
    public IntPtr PerfSet;
    [FieldOffset(8)]
    public ulong CurrentPerf;
    [FieldOffset(16)]
    public ulong CurrentPerfStamp;
    [FieldOffset(24)]
    public byte CurrentPerfNominal;
}
