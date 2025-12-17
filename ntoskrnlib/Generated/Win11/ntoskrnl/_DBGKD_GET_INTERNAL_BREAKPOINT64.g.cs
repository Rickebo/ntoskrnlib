#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _DBGKD_GET_INTERNAL_BREAKPOINT64
    {
        [FieldOffset(0)]
        public ulong BreakpointAddress;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(12)]
        public uint Calls;
        [FieldOffset(16)]
        public uint MaxCallsPerPeriod;
        [FieldOffset(20)]
        public uint MinInstructions;
        [FieldOffset(24)]
        public uint MaxInstructions;
        [FieldOffset(28)]
        public uint TotalInstructions;
    }
}