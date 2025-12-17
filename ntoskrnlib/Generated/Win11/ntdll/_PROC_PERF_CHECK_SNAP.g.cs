#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PROC_PERF_CHECK_SNAP
    {
        [FieldOffset(0)]
        public ulong Time;
        [FieldOffset(8)]
        public ulong Active;
        [FieldOffset(16)]
        public ulong Stall;
        [FieldOffset(24)]
        public ulong FrequencyScaledActive;
        [FieldOffset(32)]
        public ulong PerformanceScaledActive;
        [FieldOffset(40)]
        public ulong PerformanceScaledKernelActive;
        [FieldOffset(48)]
        public uint ResponsivenessEvents;
    }
}