using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=104)]
public struct _DEVICE_OBJECT_POWER_EXTENSION
{
    [FieldOffset(0)]
    public uint IdleCount;
    [FieldOffset(4)]
    public uint BusyCount;
    [FieldOffset(8)]
    public uint BusyReference;
    [FieldOffset(12)]
    public uint TotalBusyCount;
    [FieldOffset(16)]
    public uint ConservationIdleTime;
    [FieldOffset(20)]
    public uint PerformanceIdleTime;
    [FieldOffset(24)]
    public IntPtr DeviceObject;
    [FieldOffset(32)]
    public _LIST_ENTRY IdleList;
    [FieldOffset(48)]
    public IntPtr IdleType;
    [FieldOffset(52)]
    public IntPtr IdleState;
    [FieldOffset(56)]
    public IntPtr CurrentState;
    [FieldOffset(64)]
    public IntPtr CoolingExtension;
    [FieldOffset(72)]
    public IntPtr PowerLimitExtension;
    [FieldOffset(80)]
    public _LIST_ENTRY Volume;
    [FieldOffset(96)]
    public _unnamed_tag_ Specific;
}
