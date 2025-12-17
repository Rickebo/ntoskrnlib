using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_HEAP_SESSION_STATE")]
    public sealed class ExHeapSessionState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlpHpHeapManager HeapManager { get => ReadStructure<RtlpHpHeapManager>(nameof(HeapManager)); set => WriteStructure(nameof(HeapManager), value); }

        [Offset(14560UL)]
        public RtlHpEnvHandle PagedEnv { get => ReadStructure<RtlHpEnvHandle>(nameof(PagedEnv)); set => WriteStructure(nameof(PagedEnv), value); }

        [Offset(14576UL)]
        public IntPtr PagedHeap { get => ReadHere<IntPtr>(nameof(PagedHeap)); set => WriteHere(nameof(PagedHeap), value); }

        [Offset(14584UL)]
        public IntPtr SpecialPoolHeap { get => ReadHere<IntPtr>(nameof(SpecialPoolHeap)); set => WriteHere(nameof(SpecialPoolHeap), value); }

        public ExHeapSessionState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExHeapSessionState>();
        }
    }
}