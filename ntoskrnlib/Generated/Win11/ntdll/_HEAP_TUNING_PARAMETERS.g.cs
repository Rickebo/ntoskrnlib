#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_TUNING_PARAMETERS
    {
        [FieldOffset(0)]
        public uint CommittThresholdShift;
        [FieldOffset(8)]
        public ulong MaxPreCommittThreshold;
    }
}