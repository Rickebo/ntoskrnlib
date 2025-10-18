using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _PEP_WORK_INFORMATION
{
    [FieldOffset(0)]
    public IntPtr WorkType;
    [FieldOffset(8)]
    public _PEP_WORK_ACTIVE_COMPLETE ActiveComplete;
    [FieldOffset(8)]
    public _PEP_WORK_IDLE_STATE IdleState;
    [FieldOffset(8)]
    public _PEP_WORK_DEVICE_POWER DevicePower;
    [FieldOffset(8)]
    public _PEP_WORK_POWER_CONTROL PowerControl;
    [FieldOffset(8)]
    public _PEP_WORK_DEVICE_IDLE DeviceIdle;
    [FieldOffset(8)]
    public _PEP_WORK_COMPLETE_IDLE_STATE CompleteIdleState;
    [FieldOffset(8)]
    public _PEP_WORK_COMPLETE_PERF_STATE CompletePerfState;
    [FieldOffset(8)]
    public _PEP_WORK_ACPI_NOTIFY AcpiNotify;
    [FieldOffset(8)]
    public _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE ControlMethodComplete;
}
