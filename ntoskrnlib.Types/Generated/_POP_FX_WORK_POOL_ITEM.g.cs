using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _POP_FX_WORK_POOL_ITEM
{
    [FieldOffset(0)]
    public IntPtr WorkPool;
    [FieldOffset(8)]
    public _WORK_QUEUE_ITEM WorkItem;
}
