using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PROCESS_NETWORK_COUNTERS
{
    [FieldOffset(0)]
    public ulong BytesIn;
    [FieldOffset(8)]
    public ulong BytesOut;
}
