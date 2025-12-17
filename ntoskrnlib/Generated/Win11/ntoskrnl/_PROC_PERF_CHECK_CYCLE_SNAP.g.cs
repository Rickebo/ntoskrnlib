#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _PROC_PERF_CHECK_CYCLE_SNAP
    {
        [FieldOffset(0)]
        public ulong CyclesActive;
        [FieldOffset(8)]
        public ulong CyclesAffinitized;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] TaggedThreadCycles;
        [FieldOffset(48)]
        public uint WorkloadClasses;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] ThreadTypeCycles;
    }
}