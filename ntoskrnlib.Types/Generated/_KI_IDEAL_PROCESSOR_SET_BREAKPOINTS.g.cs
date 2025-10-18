using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS
{
    [FieldOffset(0)]
    public _KI_PROCESS_CONCURRENCY_COUNT Low;
    [FieldOffset(4)]
    public _KI_PROCESS_CONCURRENCY_COUNT High;
}
