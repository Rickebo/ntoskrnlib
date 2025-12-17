using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_LARGE_PAGE_NODE_COALESCE_STATE")]
    public sealed class MiLargePageNodeCoalesceState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray CandidateCount { get => ReadStructure<DynamicArray>(nameof(CandidateCount)); set => WriteStructure(nameof(CandidateCount), value); }

        [Offset(24UL)]
        [Length(3)]
        public DynamicArray NewCandidateSequence { get => ReadStructure<DynamicArray>(nameof(NewCandidateSequence)); set => WriteStructure(nameof(NewCandidateSequence), value); }

        public MiLargePageNodeCoalesceState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiLargePageNodeCoalesceState>();
        }
    }
}