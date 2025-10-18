using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _PNP_WATCHDOG
{
    [FieldOffset(0)]
    public ulong WatchdogStart;
    [FieldOffset(8)]
    public IntPtr WatchdogTimer;
    [FieldOffset(16)]
    public IntPtr WatchdogContextType;
    [FieldOffset(24)]
    public IntPtr WatchdogContext;
    [FieldOffset(32)]
    public byte FirstChanceTriggered;
    [FieldOffset(33)]
    public byte TelemetryGenerated;
    [FieldOffset(40)]
    public _UNICODE_STRING DriverToBlame;
    [FieldOffset(56)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public short[] DriverToBlameBuffer;
}
