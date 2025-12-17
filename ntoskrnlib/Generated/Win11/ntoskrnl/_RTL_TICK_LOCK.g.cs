#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_TICK_LOCK
    {
        [FieldOffset(0)]
        public ulong AsULong64;
        [FieldOffset(0)]
        public ulong Busy;
        [FieldOffset(0)]
        public ulong Ticks;
    }
}