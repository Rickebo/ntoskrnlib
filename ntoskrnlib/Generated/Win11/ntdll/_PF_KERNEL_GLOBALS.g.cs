#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PF_KERNEL_GLOBALS
    {
        [FieldOffset(0)]
        public ulong AccessBufferAgeThreshold;
        [FieldOffset(8)]
        public int StreamSequenceNumber;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public int ScenarioPrefetchCount;
    }
}