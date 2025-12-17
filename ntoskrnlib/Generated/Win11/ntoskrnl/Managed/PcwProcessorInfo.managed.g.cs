using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_PROCESSOR_INFO")]
    public sealed class PcwProcessorInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ulong IdleTime { get => ReadHere<ulong>(nameof(IdleTime)); set => WriteHere(nameof(IdleTime), value); }

        [Offset(8UL)]
        public ulong AvailableTime { get => ReadHere<ulong>(nameof(AvailableTime)); set => WriteHere(nameof(AvailableTime), value); }

        [Offset(16UL)]
        public ulong UserTime { get => ReadHere<ulong>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(24UL)]
        public ulong KernelTime { get => ReadHere<ulong>(nameof(KernelTime)); set => WriteHere(nameof(KernelTime), value); }

        [Offset(32UL)]
        public uint Interrupts { get => ReadHere<uint>(nameof(Interrupts)); set => WriteHere(nameof(Interrupts), value); }

        [Offset(40UL)]
        public ulong DpcTime { get => ReadHere<ulong>(nameof(DpcTime)); set => WriteHere(nameof(DpcTime), value); }

        [Offset(48UL)]
        public ulong InterruptTime { get => ReadHere<ulong>(nameof(InterruptTime)); set => WriteHere(nameof(InterruptTime), value); }

        [Offset(56UL)]
        public uint ClockInterrupts { get => ReadHere<uint>(nameof(ClockInterrupts)); set => WriteHere(nameof(ClockInterrupts), value); }

        [Offset(60UL)]
        public uint DpcCount { get => ReadHere<uint>(nameof(DpcCount)); set => WriteHere(nameof(DpcCount), value); }

        [Offset(64UL)]
        public uint DpcRate { get => ReadHere<uint>(nameof(DpcRate)); set => WriteHere(nameof(DpcRate), value); }

        [Offset(72UL)]
        public ulong C1Time { get => ReadHere<ulong>(nameof(C1Time)); set => WriteHere(nameof(C1Time), value); }

        [Offset(80UL)]
        public ulong C2Time { get => ReadHere<ulong>(nameof(C2Time)); set => WriteHere(nameof(C2Time), value); }

        [Offset(88UL)]
        public ulong C3Time { get => ReadHere<ulong>(nameof(C3Time)); set => WriteHere(nameof(C3Time), value); }

        [Offset(96UL)]
        public ulong C1Transitions { get => ReadHere<ulong>(nameof(C1Transitions)); set => WriteHere(nameof(C1Transitions), value); }

        [Offset(104UL)]
        public ulong C2Transitions { get => ReadHere<ulong>(nameof(C2Transitions)); set => WriteHere(nameof(C2Transitions), value); }

        [Offset(112UL)]
        public ulong C3Transitions { get => ReadHere<ulong>(nameof(C3Transitions)); set => WriteHere(nameof(C3Transitions), value); }

        [Offset(120UL)]
        public ulong StallTime { get => ReadHere<ulong>(nameof(StallTime)); set => WriteHere(nameof(StallTime), value); }

        [Offset(128UL)]
        public uint ParkingStatus { get => ReadHere<uint>(nameof(ParkingStatus)); set => WriteHere(nameof(ParkingStatus), value); }

        [Offset(132UL)]
        public uint CurrentFrequency { get => ReadHere<uint>(nameof(CurrentFrequency)); set => WriteHere(nameof(CurrentFrequency), value); }

        [Offset(136UL)]
        public uint PercentMaxFrequency { get => ReadHere<uint>(nameof(PercentMaxFrequency)); set => WriteHere(nameof(PercentMaxFrequency), value); }

        [Offset(140UL)]
        public uint StateFlags { get => ReadHere<uint>(nameof(StateFlags)); set => WriteHere(nameof(StateFlags), value); }

        [Offset(144UL)]
        public uint NominalThroughput { get => ReadHere<uint>(nameof(NominalThroughput)); set => WriteHere(nameof(NominalThroughput), value); }

        [Offset(148UL)]
        public uint ActiveThroughput { get => ReadHere<uint>(nameof(ActiveThroughput)); set => WriteHere(nameof(ActiveThroughput), value); }

        [Offset(152UL)]
        public ulong ScaledThroughput { get => ReadHere<ulong>(nameof(ScaledThroughput)); set => WriteHere(nameof(ScaledThroughput), value); }

        [Offset(160UL)]
        public ulong ScaledKernelThroughput { get => ReadHere<ulong>(nameof(ScaledKernelThroughput)); set => WriteHere(nameof(ScaledKernelThroughput), value); }

        [Offset(168UL)]
        public ulong AverageIdleTime { get => ReadHere<ulong>(nameof(AverageIdleTime)); set => WriteHere(nameof(AverageIdleTime), value); }

        [Offset(176UL)]
        public ulong IdleBreakEvents { get => ReadHere<ulong>(nameof(IdleBreakEvents)); set => WriteHere(nameof(IdleBreakEvents), value); }

        [Offset(184UL)]
        public uint PerformanceLimit { get => ReadHere<uint>(nameof(PerformanceLimit)); set => WriteHere(nameof(PerformanceLimit), value); }

        [Offset(188UL)]
        public uint PerformanceLimitFlags { get => ReadHere<uint>(nameof(PerformanceLimitFlags)); set => WriteHere(nameof(PerformanceLimitFlags), value); }

        [Offset(192UL)]
        public ulong ScaledFrequency { get => ReadHere<ulong>(nameof(ScaledFrequency)); set => WriteHere(nameof(ScaledFrequency), value); }

        public PcwProcessorInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwProcessorInfo>();
        }
    }
}