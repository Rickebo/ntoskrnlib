using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=2)]
public struct _PROCESS_EXECUTION_TRANSITION
{
    [FieldOffset(0)]
    public short TransitionState;
}
