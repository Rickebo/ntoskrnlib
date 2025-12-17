#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KCLOCK_TIMER_DEADLINE_ENTRY
    {
        [FieldOffset(0)]
        public ulong DueTime;
        [FieldOffset(8)]
        public uint TolerableDelay;
        [FieldOffset(12)]
        public byte TypeFlags;
        [FieldOffset(12)]
        public byte Valid;
        [FieldOffset(12)]
        public byte NoWake;
        [FieldOffset(12)]
        public byte Unused;
    }
}