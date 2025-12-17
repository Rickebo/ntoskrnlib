#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _KPRCB_TRACEPOINT_LOG_ENTRY
    {
        [FieldOffset(0)]
        public ulong OldPc;
        [FieldOffset(8)]
        public ulong OldSp;
        [FieldOffset(16)]
        public ulong NewPc;
        [FieldOffset(24)]
        public ulong NewSp;
    }
}