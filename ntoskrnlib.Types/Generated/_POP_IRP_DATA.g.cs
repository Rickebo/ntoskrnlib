using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=312)]
public struct _POP_IRP_DATA
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public IntPtr Irp;
    [FieldOffset(24)]
    public IntPtr Pdo;
    [FieldOffset(32)]
    public IntPtr TargetDevice;
    [FieldOffset(40)]
    public IntPtr CurrentDevice;
    [FieldOffset(48)]
    public ulong WatchdogStart;
    [FieldOffset(56)]
    public _KTIMER WatchdogTimer;
    [FieldOffset(120)]
    public _KDPC WatchdogDpc;
    [FieldOffset(184)]
    public byte MinorFunction;
    [FieldOffset(188)]
    public IntPtr PowerStateType;
    [FieldOffset(192)]
    public _POWER_STATE PowerState;
    [FieldOffset(200)]
    public IntPtr FxDevice;
    [FieldOffset(208)]
    public byte SystemTransition;
    [FieldOffset(209)]
    public byte NotifyPEP;
    [FieldOffset(212)]
    public int IrpSequenceID;
    [FieldOffset(216)]
    public _unnamed_tag_ Device;
    [FieldOffset(216)]
    public _unnamed_tag_ System;
    [FieldOffset(280)]
    public IntPtr DStateReason;
    [FieldOffset(288)]
    public ulong WatchdogLock;
    [FieldOffset(296)]
    public IntPtr WatchdogState;
    [FieldOffset(304)]
    public ulong BlackboxWatchdogStartTime;
}
