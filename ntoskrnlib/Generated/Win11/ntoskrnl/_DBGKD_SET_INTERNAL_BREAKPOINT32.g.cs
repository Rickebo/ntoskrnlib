#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _DBGKD_SET_INTERNAL_BREAKPOINT32
    {
        [FieldOffset(0)]
        public uint BreakpointAddress;
        [FieldOffset(4)]
        public uint Flags;
    }
}