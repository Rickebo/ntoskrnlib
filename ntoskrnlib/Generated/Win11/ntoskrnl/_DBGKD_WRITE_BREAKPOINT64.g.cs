#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DBGKD_WRITE_BREAKPOINT64
    {
        [FieldOffset(0)]
        public ulong BreakPointAddress;
        [FieldOffset(8)]
        public uint BreakPointHandle;
    }
}