#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _IA64_DBGKD_CONTROL_SET
    {
        [FieldOffset(0)]
        public uint Continue;
        [FieldOffset(4)]
        public ulong CurrentSymbolStart;
        [FieldOffset(12)]
        public ulong CurrentSymbolEnd;
    }
}