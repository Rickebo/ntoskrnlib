using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=208)]
public struct _ETW_STACK_TRACE_BLOCK
{
    [FieldOffset(0)]
    public _ETW_APC_POOL ApcPool;
    [FieldOffset(192)]
    public int StackCaptureAttemptCount;
    [FieldOffset(196)]
    public int StackExpansionFailureCount;
}
