using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _POP_FX_LOG_ENTRY
{
    [FieldOffset(0)]
    public ulong Timestamp;
    [FieldOffset(8)]
    public byte Operation;
    [FieldOffset(9)]
    public byte Component;
    [FieldOffset(10)]
    public ushort Processor;
    [FieldOffset(12)]
    public ushort Process;
    [FieldOffset(14)]
    public ushort Thread;
    [FieldOffset(16)]
    public ulong Information;
}
