using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=200)]
public struct _POP_POWER_LIMIT_EXTENSION
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public _LIST_ENTRY RequestListHead;
    [FieldOffset(32)]
    public _POP_RW_LOCK Lock;
    [FieldOffset(48)]
    public byte Enabled;
    [FieldOffset(56)]
    public IntPtr DeviceObject;
    [FieldOffset(64)]
    public IntPtr NotificationEntry;
    [FieldOffset(72)]
    public uint LimitCount;
    [FieldOffset(80)]
    public IntPtr LimitAttributes;
    [FieldOffset(88)]
    public IntPtr LimitValues;
    [FieldOffset(96)]
    public uint UpdateMaskCount;
    [FieldOffset(104)]
    public IntPtr UpdateMask;
    [FieldOffset(112)]
    public _POWER_LIMIT_INTERFACE Interface;
    [FieldOffset(176)]
    public uint PendingSetCount;
    [FieldOffset(180)]
    public uint PendingQueryCount;
    [FieldOffset(184)]
    public IntPtr RemovalFlushEvent;
    [FieldOffset(192)]
    public IntPtr PnpFlushEvent;
}
