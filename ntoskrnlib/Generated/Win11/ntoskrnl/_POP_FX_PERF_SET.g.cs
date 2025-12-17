#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _POP_FX_PERF_SET
    {
        [FieldOffset(0)]
        public IntPtr PerfSet;
        [FieldOffset(8)]
        public ulong CurrentPerf;
        [FieldOffset(16)]
        public ulong CurrentPerfStamp;
        [FieldOffset(24)]
        public byte CurrentPerfNominal;
    }
}