using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROC_PERF_CHECK_SNAP")]
    public sealed class ProcPerfCheckSnap : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Time { get => ReadHere<ulong>(nameof(Time)); set => WriteHere(nameof(Time), value); }

        [Offset(8UL)]
        public ulong Active { get => ReadHere<ulong>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        [Offset(16UL)]
        public ulong Stall { get => ReadHere<ulong>(nameof(Stall)); set => WriteHere(nameof(Stall), value); }

        [Offset(24UL)]
        public ulong FrequencyScaledActive { get => ReadHere<ulong>(nameof(FrequencyScaledActive)); set => WriteHere(nameof(FrequencyScaledActive), value); }

        [Offset(32UL)]
        public ulong PerformanceScaledActive { get => ReadHere<ulong>(nameof(PerformanceScaledActive)); set => WriteHere(nameof(PerformanceScaledActive), value); }

        [Offset(40UL)]
        public ulong PerformanceScaledKernelActive { get => ReadHere<ulong>(nameof(PerformanceScaledKernelActive)); set => WriteHere(nameof(PerformanceScaledKernelActive), value); }

        [Offset(48UL)]
        public uint ResponsivenessEvents { get => ReadHere<uint>(nameof(ResponsivenessEvents)); set => WriteHere(nameof(ResponsivenessEvents), value); }

        public ProcPerfCheckSnap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfCheckSnap>();
        }
    }
}