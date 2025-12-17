#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _PROC_PERF_LOAD
    {
        [FieldOffset(0)]
        public byte BusyPercentage;
        [FieldOffset(1)]
        public byte FrequencyPercentage;
    }
}