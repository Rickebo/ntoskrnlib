#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DBGKD_WRITE_CUSTOM_BREAKPOINT
    {
        [FieldOffset(0)]
        public ulong BreakPointAddress;
        [FieldOffset(8)]
        public ulong BreakPointInstruction;
        [FieldOffset(16)]
        public uint BreakPointHandle;
        [FieldOffset(20)]
        public byte BreakPointInstructionSize;
        [FieldOffset(21)]
        public byte BreakPointInstructionAlignment;
    }
}