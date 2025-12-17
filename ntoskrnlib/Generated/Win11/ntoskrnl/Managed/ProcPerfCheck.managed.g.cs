using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_CHECK")]
    public sealed class ProcPerfCheck : DynamicStructure
    {
        [Offset(0UL)]
        public ulong LastActive { get => ReadHere<ulong>(nameof(LastActive)); set => WriteHere(nameof(LastActive), value); }

        [Offset(8UL)]
        public ulong LastTime { get => ReadHere<ulong>(nameof(LastTime)); set => WriteHere(nameof(LastTime), value); }

        [Offset(16UL)]
        public ulong LastStall { get => ReadHere<ulong>(nameof(LastStall)); set => WriteHere(nameof(LastStall), value); }

        [Offset(24UL)]
        public uint LastResponsivenessEvents { get => ReadHere<uint>(nameof(LastResponsivenessEvents)); set => WriteHere(nameof(LastResponsivenessEvents), value); }

        [Offset(32UL)]
        public ProcPerfCheckSnap LastPerfCheckSnap { get => ReadStructure<ProcPerfCheckSnap>(nameof(LastPerfCheckSnap)); set => WriteStructure(nameof(LastPerfCheckSnap), value); }

        [Offset(88UL)]
        public IntPtr LastPerfCheckCycleSnap { get => ReadHere<IntPtr>(nameof(LastPerfCheckCycleSnap)); set => WriteHere(nameof(LastPerfCheckCycleSnap), value); }

        [Offset(96UL)]
        public ProcPerfCheckSnap CurrentSnap { get => ReadStructure<ProcPerfCheckSnap>(nameof(CurrentSnap)); set => WriteStructure(nameof(CurrentSnap), value); }

        [Offset(152UL)]
        public IntPtr CurrentCycleSnap { get => ReadHere<IntPtr>(nameof(CurrentCycleSnap)); set => WriteHere(nameof(CurrentCycleSnap), value); }

        [Offset(160UL)]
        public ProcPerfCheckSnap LastDeliveredSnap { get => ReadStructure<ProcPerfCheckSnap>(nameof(LastDeliveredSnap)); set => WriteStructure(nameof(LastDeliveredSnap), value); }

        [Offset(216UL)]
        public IntPtr LastDeliveredCycleSnap { get => ReadHere<IntPtr>(nameof(LastDeliveredCycleSnap)); set => WriteHere(nameof(LastDeliveredCycleSnap), value); }

        [Offset(224UL)]
        public uint LastDeliveredPerformance { get => ReadHere<uint>(nameof(LastDeliveredPerformance)); set => WriteHere(nameof(LastDeliveredPerformance), value); }

        [Offset(228UL)]
        public uint LastDeliveredFrequency { get => ReadHere<uint>(nameof(LastDeliveredFrequency)); set => WriteHere(nameof(LastDeliveredFrequency), value); }

        [Offset(232UL)]
        [Length(4)]
        public DynamicArray TaggedThreadPercent { get => ReadStructure<DynamicArray>(nameof(TaggedThreadPercent)); set => WriteStructure(nameof(TaggedThreadPercent), value); }

        [Offset(236UL)]
        public byte ImportantPercent { get => ReadHere<byte>(nameof(ImportantPercent)); set => WriteHere(nameof(ImportantPercent), value); }

        [Offset(237UL)]
        public byte IdealPercent { get => ReadHere<byte>(nameof(IdealPercent)); set => WriteHere(nameof(IdealPercent), value); }

        [Offset(238UL)]
        public byte Class0FloorPerfSelection { get => ReadHere<byte>(nameof(Class0FloorPerfSelection)); set => WriteHere(nameof(Class0FloorPerfSelection), value); }

        [Offset(239UL)]
        public byte Class1MinimumPerfSelection { get => ReadHere<byte>(nameof(Class1MinimumPerfSelection)); set => WriteHere(nameof(Class1MinimumPerfSelection), value); }

        [Offset(240UL)]
        public uint CurrentResponsivenessEvents { get => ReadHere<uint>(nameof(CurrentResponsivenessEvents)); set => WriteHere(nameof(CurrentResponsivenessEvents), value); }

        [Offset(248UL)]
        [Length(3)]
        public DynamicArray CyclesByFreqBand { get => ReadStructure<DynamicArray>(nameof(CyclesByFreqBand)); set => WriteStructure(nameof(CyclesByFreqBand), value); }

        public ProcPerfCheck(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfCheck>();
        }
    }
}