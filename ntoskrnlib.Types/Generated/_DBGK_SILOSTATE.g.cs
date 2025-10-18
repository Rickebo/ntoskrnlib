using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _DBGK_SILOSTATE
{
    [FieldOffset(0)]
    public _EX_PUSH_LOCK ErrorPortLock;
    [FieldOffset(8)]
    public IntPtr ErrorPort;
    [FieldOffset(16)]
    public IntPtr ErrorProcess;
    [FieldOffset(24)]
    public IntPtr ErrorPortRegisteredEvent;
}
