#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _DBGKD_GET_INTERNAL_BREAKPOINT32
    {
        [FieldOffset(0)]
        public uint BreakpointAddress;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public uint Calls;
        [FieldOffset(12)]
        public uint MaxCallsPerPeriod;
        [FieldOffset(16)]
        public uint MinInstructions;
        [FieldOffset(20)]
        public uint MaxInstructions;
        [FieldOffset(24)]
        public uint TotalInstructions;
    }
}