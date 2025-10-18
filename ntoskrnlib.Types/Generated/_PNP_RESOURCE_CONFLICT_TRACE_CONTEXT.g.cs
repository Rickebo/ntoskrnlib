using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT
{
    [FieldOffset(0)]
    public byte ResourceType;
    [FieldOffset(4)]
    public uint AlternativeCount;
    [FieldOffset(8)]
    public IntPtr ResourceRequests;
    [FieldOffset(16)]
    public IntPtr ArbiterInstance;
}
