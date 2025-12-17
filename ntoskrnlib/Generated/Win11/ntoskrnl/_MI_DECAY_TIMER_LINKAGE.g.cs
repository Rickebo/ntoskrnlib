#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_DECAY_TIMER_LINKAGE
    {
        [FieldOffset(0)]
        public ulong Spare0;
        [FieldOffset(0)]
        public ulong PreviousDecayPfn;
        [FieldOffset(0)]
        public ulong TimerRemoved;
        [FieldOffset(0)]
        public ulong NextDecayPfn;
    }
}