using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _ETW_HW_TRACE_EXT_INTERFACE
{
    [FieldOffset(0)]
    public IntPtr StartProcessorTraceOnEachCore;
    [FieldOffset(8)]
    public IntPtr StopProcessorTraceOnEachCore;
    [FieldOffset(16)]
    public IntPtr LogProcessorTraceOnCurrentCore;
}
