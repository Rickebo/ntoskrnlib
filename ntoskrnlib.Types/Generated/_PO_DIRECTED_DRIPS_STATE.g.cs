using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _PO_DIRECTED_DRIPS_STATE
{
    [FieldOffset(0)]
    public _LIST_ENTRY QueueLink;
    [FieldOffset(16)]
    public _LIST_ENTRY VisitedQueueLink;
    [FieldOffset(32)]
    public uint Flags;
    [FieldOffset(36)]
    public uint CachedFlags;
    [FieldOffset(40)]
    public uint DeviceUsageCount;
    [FieldOffset(48)]
    public IntPtr Diagnostic;
}
