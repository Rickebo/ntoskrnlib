using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _PS_PROCESS_WAKE_INFORMATION
{
    [FieldOffset(0)]
    public ulong NotificationChannel;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public uint[] WakeCounters;
    [FieldOffset(36)]
    public _JOBOBJECT_WAKE_FILTER WakeFilter;
    [FieldOffset(44)]
    public uint NoWakeCounter;
}
