using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _KSECURE_FAULT_INFORMATION
{
    [FieldOffset(0)]
    public ulong FaultCode;
    [FieldOffset(8)]
    public ulong FaultVa;
    [FieldOffset(16)]
    public ulong FaultPa;
}
