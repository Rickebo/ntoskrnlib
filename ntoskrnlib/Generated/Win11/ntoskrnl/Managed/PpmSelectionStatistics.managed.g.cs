using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_SELECTION_STATISTICS")]
    public sealed class PpmSelectionStatistics : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SelectedCount { get => ReadHere<ulong>(nameof(SelectedCount)); set => WriteHere(nameof(SelectedCount), value); }

        [Offset(8UL)]
        public ulong VetoCount { get => ReadHere<ulong>(nameof(VetoCount)); set => WriteHere(nameof(VetoCount), value); }

        [Offset(16UL)]
        public ulong PreVetoCount { get => ReadHere<ulong>(nameof(PreVetoCount)); set => WriteHere(nameof(PreVetoCount), value); }

        [Offset(24UL)]
        public ulong WrongProcessorCount { get => ReadHere<ulong>(nameof(WrongProcessorCount)); set => WriteHere(nameof(WrongProcessorCount), value); }

        [Offset(32UL)]
        public ulong LatencyCount { get => ReadHere<ulong>(nameof(LatencyCount)); set => WriteHere(nameof(LatencyCount), value); }

        [Offset(40UL)]
        public ulong IdleDurationCount { get => ReadHere<ulong>(nameof(IdleDurationCount)); set => WriteHere(nameof(IdleDurationCount), value); }

        [Offset(48UL)]
        public ulong DeviceDependencyCount { get => ReadHere<ulong>(nameof(DeviceDependencyCount)); set => WriteHere(nameof(DeviceDependencyCount), value); }

        [Offset(56UL)]
        public ulong ProcessorDependencyCount { get => ReadHere<ulong>(nameof(ProcessorDependencyCount)); set => WriteHere(nameof(ProcessorDependencyCount), value); }

        [Offset(64UL)]
        public ulong PlatformOnlyCount { get => ReadHere<ulong>(nameof(PlatformOnlyCount)); set => WriteHere(nameof(PlatformOnlyCount), value); }

        [Offset(72UL)]
        public ulong InterruptibleCount { get => ReadHere<ulong>(nameof(InterruptibleCount)); set => WriteHere(nameof(InterruptibleCount), value); }

        [Offset(80UL)]
        public ulong LegacyOverrideCount { get => ReadHere<ulong>(nameof(LegacyOverrideCount)); set => WriteHere(nameof(LegacyOverrideCount), value); }

        [Offset(88UL)]
        public ulong CstateCheckCount { get => ReadHere<ulong>(nameof(CstateCheckCount)); set => WriteHere(nameof(CstateCheckCount), value); }

        [Offset(96UL)]
        public ulong NoCStateCount { get => ReadHere<ulong>(nameof(NoCStateCount)); set => WriteHere(nameof(NoCStateCount), value); }

        [Offset(104UL)]
        public ulong CoordinatedDependencyCount { get => ReadHere<ulong>(nameof(CoordinatedDependencyCount)); set => WriteHere(nameof(CoordinatedDependencyCount), value); }

        [Offset(112UL)]
        public ulong NotClockOwnerCount { get => ReadHere<ulong>(nameof(NotClockOwnerCount)); set => WriteHere(nameof(NotClockOwnerCount), value); }

        [Offset(120UL)]
        public ulong DependencyIdleDurationCount { get => ReadHere<ulong>(nameof(DependencyIdleDurationCount)); set => WriteHere(nameof(DependencyIdleDurationCount), value); }

        [Offset(128UL)]
        public ulong DependencyLatencyCount { get => ReadHere<ulong>(nameof(DependencyLatencyCount)); set => WriteHere(nameof(DependencyLatencyCount), value); }

        [Offset(136UL)]
        public IntPtr PreVetoAccounting { get => ReadHere<IntPtr>(nameof(PreVetoAccounting)); set => WriteHere(nameof(PreVetoAccounting), value); }

        public PpmSelectionStatistics(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmSelectionStatistics>();
        }
    }
}