#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _PPC_DBGKD_CONTROL_SET
    {
        [FieldOffset(0)]
        public uint Continue;
        [FieldOffset(4)]
        public uint CurrentSymbolStart;
        [FieldOffset(8)]
        public uint CurrentSymbolEnd;
    }
}