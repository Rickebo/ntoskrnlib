using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _IO_COMPLETION_CONTEXT
{
    [FieldOffset(0)]
    public IntPtr Port;
    [FieldOffset(8)]
    public IntPtr Key;
    [FieldOffset(16)]
    public long UsageCount;
}
