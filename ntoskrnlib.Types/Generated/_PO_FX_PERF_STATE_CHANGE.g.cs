using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PO_FX_PERF_STATE_CHANGE
{
    [FieldOffset(0)]
    public uint Set;
    [FieldOffset(8)]
    public uint StateIndex;
    [FieldOffset(8)]
    public ulong StateValue;
}
