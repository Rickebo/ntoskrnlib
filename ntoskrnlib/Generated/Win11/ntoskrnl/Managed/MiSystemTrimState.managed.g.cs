using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_TRIM_STATE")]
    public sealed class MiSystemTrimState : DynamicStructure
    {
        [Offset(0UL)]
        public int ExpansionLock { get => ReadHere<int>(nameof(ExpansionLock)); set => WriteHere(nameof(ExpansionLock), value); }

        [Offset(4UL)]
        public int TrimInProgressCount { get => ReadHere<int>(nameof(TrimInProgressCount)); set => WriteHere(nameof(TrimInProgressCount), value); }

        [Offset(8UL)]
        public Kevent PeriodicWorkingSetEvent { get => ReadStructure<Kevent>(nameof(PeriodicWorkingSetEvent)); set => WriteStructure(nameof(PeriodicWorkingSetEvent), value); }

        [Offset(32UL)]
        public MiVerifierTrimState Verifier { get => ReadStructure<MiVerifierTrimState>(nameof(Verifier)); set => WriteStructure(nameof(Verifier), value); }

        [Offset(64UL)]
        [Length(4)]
        public DynamicArray TrimAllPageFaultCount { get => ReadStructure<DynamicArray>(nameof(TrimAllPageFaultCount)); set => WriteStructure(nameof(TrimAllPageFaultCount), value); }

        [Offset(80UL)]
        public IntPtr EmptyAllThread { get => ReadHere<IntPtr>(nameof(EmptyAllThread)); set => WriteHere(nameof(EmptyAllThread), value); }

        [Offset(88UL)]
        public uint FaultedInSystemPage { get => ReadHere<uint>(nameof(FaultedInSystemPage)); set => WriteHere(nameof(FaultedInSystemPage), value); }

        public MiSystemTrimState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemTrimState>();
        }
    }
}