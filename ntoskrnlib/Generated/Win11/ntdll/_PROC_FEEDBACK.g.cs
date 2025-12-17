#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial struct _PROC_FEEDBACK
    {
        [FieldOffset(0)]
        public ulong Lock;
        [FieldOffset(8)]
        public ulong CyclesLast;
        [FieldOffset(16)]
        public ulong CyclesActive;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] Counters;
        [FieldOffset(40)]
        public ulong LastUpdateTime;
        [FieldOffset(48)]
        public ulong UnscaledTime;
        [FieldOffset(56)]
        public long UnaccountedTime;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] ScaledTime;
        [FieldOffset(80)]
        public ulong UnaccountedKernelTime;
        [FieldOffset(88)]
        public ulong PerformanceScaledKernelTime;
        [FieldOffset(96)]
        public uint UserTimeLast;
        [FieldOffset(100)]
        public uint KernelTimeLast;
        [FieldOffset(104)]
        public ulong IdleGenerationNumberLast;
        [FieldOffset(112)]
        public ulong HvActiveTimeLast;
        [FieldOffset(120)]
        public ulong StallCyclesLast;
        [FieldOffset(128)]
        public ulong StallTime;
        [FieldOffset(136)]
        public byte KernelTimesIndex;
        [FieldOffset(137)]
        public byte CounterDiscardsIdleTime;
        [FieldOffset(138)]
        public byte CounterReadOptimize;
    }
}