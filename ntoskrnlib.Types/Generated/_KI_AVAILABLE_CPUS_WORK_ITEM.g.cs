using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _KI_AVAILABLE_CPUS_WORK_ITEM
{
    [FieldOffset(0)]
    public _WORK_QUEUE_ITEM ExWorkItem;
    [FieldOffset(32)]
    public _EX_RUNDOWN_REF RundownRef;
    [FieldOffset(40)]
    public _KI_AVAILABLE_CPUS_WORK_STATE WorkState;
    [FieldOffset(48)]
    public IntPtr Callback;
    [FieldOffset(56)]
    public IntPtr Context;
}
