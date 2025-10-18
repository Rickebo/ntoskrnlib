using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _WORK_QUEUE_ITEM
{
    [FieldOffset(0)]
    public _LIST_ENTRY List;
    [FieldOffset(16)]
    public IntPtr WorkerRoutine;
    [FieldOffset(24)]
    public IntPtr Parameter;
}
