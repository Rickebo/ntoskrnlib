using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROC_PERF_CHECK_CYCLE_SNAP")]
    public sealed class ProcPerfCheckCycleSnap : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CyclesActive { get => ReadHere<ulong>(nameof(CyclesActive)); set => WriteHere(nameof(CyclesActive), value); }

        [Offset(8UL)]
        public ulong CyclesAffinitized { get => ReadHere<ulong>(nameof(CyclesAffinitized)); set => WriteHere(nameof(CyclesAffinitized), value); }

        [Offset(16UL)]
        [Length(4)]
        public DynamicArray TaggedThreadCycles { get => ReadStructure<DynamicArray>(nameof(TaggedThreadCycles)); set => WriteStructure(nameof(TaggedThreadCycles), value); }

        [Offset(48UL)]
        public uint WorkloadClasses { get => ReadHere<uint>(nameof(WorkloadClasses)); set => WriteHere(nameof(WorkloadClasses), value); }

        [Offset(56UL)]
        [Length(1)]
        public DynamicArray ThreadTypeCycles { get => ReadStructure<DynamicArray>(nameof(ThreadTypeCycles)); set => WriteStructure(nameof(ThreadTypeCycles), value); }

        public ProcPerfCheckCycleSnap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfCheckCycleSnap>();
        }
    }
}