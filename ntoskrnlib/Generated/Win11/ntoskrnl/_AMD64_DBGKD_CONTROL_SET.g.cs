#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _AMD64_DBGKD_CONTROL_SET
    {
        [FieldOffset(0)]
        public uint TraceFlag;
        [FieldOffset(4)]
        public ulong Dr7;
        [FieldOffset(12)]
        public ulong CurrentSymbolStart;
        [FieldOffset(20)]
        public ulong CurrentSymbolEnd;
    }
}