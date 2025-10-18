using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _PROCESS_EXECUTION
{
    [FieldOffset(0)]
    public int State;
    [FieldOffset(0)]
    public _PROCESS_EXECUTION_TRANSITION Transition;
    [FieldOffset(2)]
    public _PROCESS_EXECUTION_STATE Current;
    [FieldOffset(3)]
    public _PROCESS_EXECUTION_STATE Requested;
}
