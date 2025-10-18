using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KI_SHARED_READY_QUEUE_LOCK_HANDLE
{
    [FieldOffset(0)]
    public _KSPIN_LOCK_QUEUE Queue;
}
