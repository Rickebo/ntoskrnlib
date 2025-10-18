using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=104)]
public struct _EPROCESS_VALUES
{
    [FieldOffset(0)]
    public ulong KernelTime;
    [FieldOffset(8)]
    public ulong UserTime;
    [FieldOffset(16)]
    public ulong ReadyTime;
    [FieldOffset(24)]
    public ulong CycleTime;
    [FieldOffset(32)]
    public ulong ContextSwitches;
    [FieldOffset(40)]
    public long ReadOperationCount;
    [FieldOffset(48)]
    public long WriteOperationCount;
    [FieldOffset(56)]
    public long OtherOperationCount;
    [FieldOffset(64)]
    public long ReadTransferCount;
    [FieldOffset(72)]
    public long WriteTransferCount;
    [FieldOffset(80)]
    public long OtherTransferCount;
    [FieldOffset(88)]
    public ulong KernelWaitTime;
    [FieldOffset(96)]
    public ulong UserWaitTime;
}
