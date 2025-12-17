using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_IDLE_ACCOUNTING")]
    public sealed class ProcIdleAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public uint StateCount { get => ReadHere<uint>(nameof(StateCount)); set => WriteHere(nameof(StateCount), value); }

        [Offset(4UL)]
        public uint TotalTransitions { get => ReadHere<uint>(nameof(TotalTransitions)); set => WriteHere(nameof(TotalTransitions), value); }

        [Offset(8UL)]
        public uint ResetCount { get => ReadHere<uint>(nameof(ResetCount)); set => WriteHere(nameof(ResetCount), value); }

        [Offset(12UL)]
        public uint AbortCount { get => ReadHere<uint>(nameof(AbortCount)); set => WriteHere(nameof(AbortCount), value); }

        [Offset(16UL)]
        public ulong StartTime { get => ReadHere<ulong>(nameof(StartTime)); set => WriteHere(nameof(StartTime), value); }

        [Offset(24UL)]
        public ulong PriorIdleTime { get => ReadHere<ulong>(nameof(PriorIdleTime)); set => WriteHere(nameof(PriorIdleTime), value); }

        [Offset(32UL)]
        public uint TimeUnit { get => ReadHere<uint>(nameof(TimeUnit)); set => WriteHere(nameof(TimeUnit), value); }

        [Offset(40UL)]
        [Length(1)]
        public DynamicArray State { get => ReadStructure<DynamicArray>(nameof(State)); set => WriteStructure(nameof(State), value); }

        public ProcIdleAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcIdleAccounting>();
        }
    }
}