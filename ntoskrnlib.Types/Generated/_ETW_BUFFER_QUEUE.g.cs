using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _ETW_BUFFER_QUEUE
{
    [FieldOffset(0)]
    public IntPtr QueueTail;
    [FieldOffset(8)]
    public _SINGLE_LIST_ENTRY QueueEntry;
}
