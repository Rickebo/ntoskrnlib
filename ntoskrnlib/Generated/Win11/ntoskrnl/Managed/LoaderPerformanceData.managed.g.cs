using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_PERFORMANCE_DATA")]
    public sealed class LoaderPerformanceData : DynamicStructure
    {
        [Offset(0UL)]
        public ulong StartTime { get => ReadHere<ulong>(nameof(StartTime)); set => WriteHere(nameof(StartTime), value); }

        [Offset(8UL)]
        public ulong EndTime { get => ReadHere<ulong>(nameof(EndTime)); set => WriteHere(nameof(EndTime), value); }

        [Offset(16UL)]
        public ulong PreloadEndTime { get => ReadHere<ulong>(nameof(PreloadEndTime)); set => WriteHere(nameof(PreloadEndTime), value); }

        [Offset(24UL)]
        public ulong TcbLoaderStartTime { get => ReadHere<ulong>(nameof(TcbLoaderStartTime)); set => WriteHere(nameof(TcbLoaderStartTime), value); }

        [Offset(32UL)]
        public ulong LoadHypervisorTime { get => ReadHere<ulong>(nameof(LoadHypervisorTime)); set => WriteHere(nameof(LoadHypervisorTime), value); }

        [Offset(40UL)]
        public ulong LaunchHypervisorTime { get => ReadHere<ulong>(nameof(LaunchHypervisorTime)); set => WriteHere(nameof(LaunchHypervisorTime), value); }

        [Offset(48UL)]
        public ulong LoadVsmTime { get => ReadHere<ulong>(nameof(LoadVsmTime)); set => WriteHere(nameof(LoadVsmTime), value); }

        [Offset(56UL)]
        public ulong LaunchVsmTime { get => ReadHere<ulong>(nameof(LaunchVsmTime)); set => WriteHere(nameof(LaunchVsmTime), value); }

        [Offset(64UL)]
        public ulong ExecuteTransitionStartTime { get => ReadHere<ulong>(nameof(ExecuteTransitionStartTime)); set => WriteHere(nameof(ExecuteTransitionStartTime), value); }

        [Offset(72UL)]
        public ulong ExecuteTransitionEndTime { get => ReadHere<ulong>(nameof(ExecuteTransitionEndTime)); set => WriteHere(nameof(ExecuteTransitionEndTime), value); }

        [Offset(80UL)]
        public ulong LoadDriversTime { get => ReadHere<ulong>(nameof(LoadDriversTime)); set => WriteHere(nameof(LoadDriversTime), value); }

        [Offset(88UL)]
        public ulong CleanupVsmTime { get => ReadHere<ulong>(nameof(CleanupVsmTime)); set => WriteHere(nameof(CleanupVsmTime), value); }

        public LoaderPerformanceData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderPerformanceData>();
        }
    }
}