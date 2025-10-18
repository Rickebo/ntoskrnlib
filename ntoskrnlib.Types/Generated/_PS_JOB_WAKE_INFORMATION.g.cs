using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=72)]
public struct _PS_JOB_WAKE_INFORMATION
{
    [FieldOffset(0)]
    public ulong NotificationChannel;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public ulong[] WakeCounters;
    [FieldOffset(64)]
    public ulong NoWakeCounter;
}
