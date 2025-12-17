#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PROC_PERF_CHECK_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr Domain;
        [FieldOffset(8)]
        public IntPtr Constraint;
        [FieldOffset(16)]
        public IntPtr PerfCheck;
        [FieldOffset(24)]
        public IntPtr Load;
        [FieldOffset(32)]
        public IntPtr PerfHistory;
        [FieldOffset(40)]
        public uint Utility;
        [FieldOffset(44)]
        public uint AffinitizedUtility;
        [FieldOffset(48)]
        public uint MediaUtility;
        [FieldOffset(52)]
        public uint ImportantUtility;
        [FieldOffset(56)]
        public uint IdealUtility;
        [FieldOffset(60)]
        public ushort LatestAffinitizedPercent;
        [FieldOffset(62)]
        public ushort AveragePerformancePercent;
        [FieldOffset(64)]
        public uint RelativePerformance;
        [FieldOffset(68)]
        public byte NtProcessor;
    }
}