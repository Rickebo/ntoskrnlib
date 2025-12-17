#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _PS_PROCESS_WAKE_INFORMATION
    {
        [FieldOffset(0)]
        public ulong NotificationChannel;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public uint[] WakeCounters;
        [FieldOffset(36)]
        public _JOBOBJECT_WAKE_FILTER WakeFilter;
        [FieldOffset(44)]
        public uint NoWakeCounter;
    }
}