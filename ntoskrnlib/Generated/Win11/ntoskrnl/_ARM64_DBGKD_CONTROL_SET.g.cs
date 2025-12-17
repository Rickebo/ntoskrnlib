#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ARM64_DBGKD_CONTROL_SET
    {
        [FieldOffset(0)]
        public uint Continue;
        [FieldOffset(4)]
        public uint TraceFlag;
        [FieldOffset(8)]
        public ulong CurrentSymbolStart;
        [FieldOffset(16)]
        public ulong CurrentSymbolEnd;
    }
}