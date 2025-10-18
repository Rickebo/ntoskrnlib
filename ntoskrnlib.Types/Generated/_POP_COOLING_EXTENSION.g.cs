using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=144)]
public struct _POP_COOLING_EXTENSION
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public _LIST_ENTRY RequestListHead;
    [FieldOffset(32)]
    public _POP_RW_LOCK Lock;
    [FieldOffset(48)]
    public IntPtr DeviceObject;
    [FieldOffset(56)]
    public IntPtr NotificationEntry;
    [FieldOffset(64)]
    public byte Enabled;
    [FieldOffset(65)]
    public byte ActiveEngaged;
    [FieldOffset(66)]
    public byte ThrottleLimit;
    [FieldOffset(67)]
    public byte UpdatingToCurrent;
    [FieldOffset(72)]
    public IntPtr RemovalFlushEvent;
    [FieldOffset(80)]
    public IntPtr PnpFlushEvent;
    [FieldOffset(88)]
    public _THERMAL_COOLING_INTERFACE Interface;
}
