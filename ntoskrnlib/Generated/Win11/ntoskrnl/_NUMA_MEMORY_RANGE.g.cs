#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _NUMA_MEMORY_RANGE
    {
        [FieldOffset(0)]
        public uint ProximityId;
        [FieldOffset(8)]
        public ulong BasePage;
        [FieldOffset(16)]
        public ulong EndPage;
    }
}