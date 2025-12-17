#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _PCW_PROCESSOR_INFO
    {
        [FieldOffset(0)]
        public ulong IdleTime;
        [FieldOffset(8)]
        public ulong AvailableTime;
        [FieldOffset(16)]
        public ulong UserTime;
        [FieldOffset(24)]
        public ulong KernelTime;
        [FieldOffset(32)]
        public uint Interrupts;
        [FieldOffset(40)]
        public ulong DpcTime;
        [FieldOffset(48)]
        public ulong InterruptTime;
        [FieldOffset(56)]
        public uint ClockInterrupts;
        [FieldOffset(60)]
        public uint DpcCount;
        [FieldOffset(64)]
        public uint DpcRate;
        [FieldOffset(72)]
        public ulong C1Time;
        [FieldOffset(80)]
        public ulong C2Time;
        [FieldOffset(88)]
        public ulong C3Time;
        [FieldOffset(96)]
        public ulong C1Transitions;
        [FieldOffset(104)]
        public ulong C2Transitions;
        [FieldOffset(112)]
        public ulong C3Transitions;
        [FieldOffset(120)]
        public ulong StallTime;
        [FieldOffset(128)]
        public uint ParkingStatus;
        [FieldOffset(132)]
        public uint CurrentFrequency;
        [FieldOffset(136)]
        public uint PercentMaxFrequency;
        [FieldOffset(140)]
        public uint StateFlags;
        [FieldOffset(144)]
        public uint NominalThroughput;
        [FieldOffset(148)]
        public uint ActiveThroughput;
        [FieldOffset(152)]
        public ulong ScaledThroughput;
        [FieldOffset(160)]
        public ulong ScaledKernelThroughput;
        [FieldOffset(168)]
        public ulong AverageIdleTime;
        [FieldOffset(176)]
        public ulong IdleBreakEvents;
        [FieldOffset(184)]
        public uint PerformanceLimit;
        [FieldOffset(188)]
        public uint PerformanceLimitFlags;
        [FieldOffset(192)]
        public ulong ScaledFrequency;
    }
}