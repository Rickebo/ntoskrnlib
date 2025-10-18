using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1056)]
public struct _PROC_IDLE_ACCOUNTING
{
    [FieldOffset(0)]
    public uint StateCount;
    [FieldOffset(4)]
    public uint TotalTransitions;
    [FieldOffset(8)]
    public uint ResetCount;
    [FieldOffset(12)]
    public uint AbortCount;
    [FieldOffset(16)]
    public ulong StartTime;
    [FieldOffset(24)]
    public ulong PriorIdleTime;
    [FieldOffset(32)]
    public IntPtr TimeUnit;
    [FieldOffset(40)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] State;
}
