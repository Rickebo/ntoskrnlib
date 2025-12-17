#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _X86_DBGKD_CONTROL_SET
    {
        [FieldOffset(0)]
        public uint TraceFlag;
        [FieldOffset(4)]
        public uint Dr7;
        [FieldOffset(8)]
        public uint CurrentSymbolStart;
        [FieldOffset(12)]
        public uint CurrentSymbolEnd;
    }
}