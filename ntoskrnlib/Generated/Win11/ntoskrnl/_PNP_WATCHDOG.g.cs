#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _PNP_WATCHDOG
    {
        [FieldOffset(0)]
        public ulong WatchdogStart;
        [FieldOffset(8)]
        public IntPtr WatchdogTimer;
        [FieldOffset(16)]
        public uint WatchdogContextType;
        [FieldOffset(24)]
        public IntPtr WatchdogContext;
        [FieldOffset(32)]
        public byte FirstChanceTriggered;
        [FieldOffset(33)]
        public byte TelemetryGenerated;
        [FieldOffset(40)]
        public _UNICODE_STRING DriverToBlame;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] DriverToBlameBuffer;
    }
}