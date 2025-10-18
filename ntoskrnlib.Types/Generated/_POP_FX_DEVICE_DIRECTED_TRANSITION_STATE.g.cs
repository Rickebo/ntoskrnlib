using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE
{
    [FieldOffset(0)]
    public IntPtr CompletionContext;
    [FieldOffset(8)]
    public int CompletionStatus;
}
