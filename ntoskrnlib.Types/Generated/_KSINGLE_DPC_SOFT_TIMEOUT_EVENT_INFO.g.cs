using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=80)]
public struct _KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO
{
    [FieldOffset(0)]
    public _KDPC EventDpc;
    [FieldOffset(64)]
    public IntPtr DeferredRoutine;
    [FieldOffset(72)]
    public uint TickCount;
}
