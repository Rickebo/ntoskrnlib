#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HAL_CHANNEL_MEMORY_RANGES
    {
        [FieldOffset(0)]
        public ulong PageFrameIndex;
        [FieldOffset(8)]
        public ushort MpnId;
        [FieldOffset(10)]
        public ushort Node;
        [FieldOffset(12)]
        public ushort Channel;
        [FieldOffset(14)]
        public byte IsPowerManageable;
        [FieldOffset(15)]
        public byte DeepPowerState;
    }
}