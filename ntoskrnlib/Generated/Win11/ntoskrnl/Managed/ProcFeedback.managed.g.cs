using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_FEEDBACK")]
    public sealed class ProcFeedback : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public ulong CyclesLast { get => ReadHere<ulong>(nameof(CyclesLast)); set => WriteHere(nameof(CyclesLast), value); }

        [Offset(16UL)]
        public ulong CyclesActive { get => ReadHere<ulong>(nameof(CyclesActive)); set => WriteHere(nameof(CyclesActive), value); }

        [Offset(24UL)]
        [Length(2)]
        public DynamicArray Counters { get => ReadStructure<DynamicArray>(nameof(Counters)); set => WriteStructure(nameof(Counters), value); }

        [Offset(40UL)]
        public ulong LastUpdateTime { get => ReadHere<ulong>(nameof(LastUpdateTime)); set => WriteHere(nameof(LastUpdateTime), value); }

        [Offset(48UL)]
        public ulong UnscaledTime { get => ReadHere<ulong>(nameof(UnscaledTime)); set => WriteHere(nameof(UnscaledTime), value); }

        [Offset(56UL)]
        public long UnaccountedTime { get => ReadHere<long>(nameof(UnaccountedTime)); set => WriteHere(nameof(UnaccountedTime), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray ScaledTime { get => ReadStructure<DynamicArray>(nameof(ScaledTime)); set => WriteStructure(nameof(ScaledTime), value); }

        [Offset(80UL)]
        public ulong UnaccountedKernelTime { get => ReadHere<ulong>(nameof(UnaccountedKernelTime)); set => WriteHere(nameof(UnaccountedKernelTime), value); }

        [Offset(88UL)]
        public ulong PerformanceScaledKernelTime { get => ReadHere<ulong>(nameof(PerformanceScaledKernelTime)); set => WriteHere(nameof(PerformanceScaledKernelTime), value); }

        [Offset(96UL)]
        public uint UserTimeLast { get => ReadHere<uint>(nameof(UserTimeLast)); set => WriteHere(nameof(UserTimeLast), value); }

        [Offset(100UL)]
        public uint KernelTimeLast { get => ReadHere<uint>(nameof(KernelTimeLast)); set => WriteHere(nameof(KernelTimeLast), value); }

        [Offset(104UL)]
        public ulong IdleGenerationNumberLast { get => ReadHere<ulong>(nameof(IdleGenerationNumberLast)); set => WriteHere(nameof(IdleGenerationNumberLast), value); }

        [Offset(112UL)]
        public ulong HvActiveTimeLast { get => ReadHere<ulong>(nameof(HvActiveTimeLast)); set => WriteHere(nameof(HvActiveTimeLast), value); }

        [Offset(120UL)]
        public ulong StallCyclesLast { get => ReadHere<ulong>(nameof(StallCyclesLast)); set => WriteHere(nameof(StallCyclesLast), value); }

        [Offset(128UL)]
        public ulong StallTime { get => ReadHere<ulong>(nameof(StallTime)); set => WriteHere(nameof(StallTime), value); }

        [Offset(136UL)]
        public byte KernelTimesIndex { get => ReadHere<byte>(nameof(KernelTimesIndex)); set => WriteHere(nameof(KernelTimesIndex), value); }

        [Offset(137UL)]
        public byte CounterDiscardsIdleTime { get => ReadHere<byte>(nameof(CounterDiscardsIdleTime)); set => WriteHere(nameof(CounterDiscardsIdleTime), value); }

        [Offset(138UL)]
        public byte CounterReadOptimize { get => ReadHere<byte>(nameof(CounterReadOptimize)); set => WriteHere(nameof(CounterReadOptimize), value); }

        public ProcFeedback(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcFeedback>();
        }
    }
}