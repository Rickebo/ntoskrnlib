#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PS_JOB_WAKE_INFORMATION
    {
        [FieldOffset(0)]
        public ulong NotificationChannel;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public ulong[] WakeCounters;
        [FieldOffset(64)]
        public ulong NoWakeCounter;
    }
}