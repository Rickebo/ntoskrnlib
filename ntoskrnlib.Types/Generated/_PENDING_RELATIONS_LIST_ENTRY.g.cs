using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=112)]
public struct _PENDING_RELATIONS_LIST_ENTRY
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public _WORK_QUEUE_ITEM WorkItem;
    [FieldOffset(48)]
    public IntPtr DeviceEvent;
    [FieldOffset(56)]
    public IntPtr DeviceObject;
    [FieldOffset(64)]
    public IntPtr RelationsList;
    [FieldOffset(72)]
    public IntPtr EjectIrp;
    [FieldOffset(80)]
    public IntPtr Lock;
    [FieldOffset(84)]
    public uint Problem;
    [FieldOffset(88)]
    public byte ProfileChangingEject;
    [FieldOffset(89)]
    public byte DisplaySafeRemovalDialog;
    [FieldOffset(92)]
    public IntPtr LightestSleepState;
    [FieldOffset(96)]
    public IntPtr DockInterface;
    [FieldOffset(104)]
    public byte DequeuePending;
    [FieldOffset(108)]
    public IntPtr DeleteType;
}
