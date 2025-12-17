using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_CHECK_CONTEXT")]
    public sealed class ProcPerfCheckContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Domain { get => ReadHere<IntPtr>(nameof(Domain)); set => WriteHere(nameof(Domain), value); }

        [Offset(8UL)]
        public IntPtr Constraint { get => ReadHere<IntPtr>(nameof(Constraint)); set => WriteHere(nameof(Constraint), value); }

        [Offset(16UL)]
        public IntPtr PerfCheck { get => ReadHere<IntPtr>(nameof(PerfCheck)); set => WriteHere(nameof(PerfCheck), value); }

        [Offset(24UL)]
        public IntPtr Load { get => ReadHere<IntPtr>(nameof(Load)); set => WriteHere(nameof(Load), value); }

        [Offset(32UL)]
        public IntPtr PerfHistory { get => ReadHere<IntPtr>(nameof(PerfHistory)); set => WriteHere(nameof(PerfHistory), value); }

        [Offset(40UL)]
        public uint Utility { get => ReadHere<uint>(nameof(Utility)); set => WriteHere(nameof(Utility), value); }

        [Offset(44UL)]
        public uint AffinitizedUtility { get => ReadHere<uint>(nameof(AffinitizedUtility)); set => WriteHere(nameof(AffinitizedUtility), value); }

        [Offset(48UL)]
        public uint MediaUtility { get => ReadHere<uint>(nameof(MediaUtility)); set => WriteHere(nameof(MediaUtility), value); }

        [Offset(52UL)]
        public uint ImportantUtility { get => ReadHere<uint>(nameof(ImportantUtility)); set => WriteHere(nameof(ImportantUtility), value); }

        [Offset(56UL)]
        public uint IdealUtility { get => ReadHere<uint>(nameof(IdealUtility)); set => WriteHere(nameof(IdealUtility), value); }

        [Offset(60UL)]
        public ushort LatestAffinitizedPercent { get => ReadHere<ushort>(nameof(LatestAffinitizedPercent)); set => WriteHere(nameof(LatestAffinitizedPercent), value); }

        [Offset(62UL)]
        public ushort AveragePerformancePercent { get => ReadHere<ushort>(nameof(AveragePerformancePercent)); set => WriteHere(nameof(AveragePerformancePercent), value); }

        [Offset(64UL)]
        public uint RelativePerformance { get => ReadHere<uint>(nameof(RelativePerformance)); set => WriteHere(nameof(RelativePerformance), value); }

        [Offset(68UL)]
        public byte NtProcessor { get => ReadHere<byte>(nameof(NtProcessor)); set => WriteHere(nameof(NtProcessor), value); }

        public ProcPerfCheckContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfCheckContext>();
        }
    }
}