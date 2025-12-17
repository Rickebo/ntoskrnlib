#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ENERGY_STATE_DURATION
    {
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public uint LastChangeTime;
        [FieldOffset(4)]
        public uint Duration;
        [FieldOffset(4)]
        public uint IsInState;
    }
}