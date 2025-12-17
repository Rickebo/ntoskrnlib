#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _THREAD_ENERGY_VALUES
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] Cycles;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] AttributedCycles;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] WorkOnBehalfCycles;
        [FieldOffset(192)]
        public _TIMELINE_BITMAP CpuTimeline;
    }
}