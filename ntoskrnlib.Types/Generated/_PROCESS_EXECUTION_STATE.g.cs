using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1)]
public struct _PROCESS_EXECUTION_STATE
{
    [FieldOffset(0)]
    public sbyte State;
}
