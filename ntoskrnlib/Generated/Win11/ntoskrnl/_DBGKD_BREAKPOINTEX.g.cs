#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _DBGKD_BREAKPOINTEX
    {
        [FieldOffset(0)]
        public uint BreakPointCount;
        [FieldOffset(4)]
        public int ContinueStatus;
    }
}