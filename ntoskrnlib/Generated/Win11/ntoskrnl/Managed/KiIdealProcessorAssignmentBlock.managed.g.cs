using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK")]
    public sealed class KiIdealProcessorAssignmentBlock : DynamicStructure
    {
        [Offset(0UL)]
        public KiProcessConcurrencyCount ExpectedConcurrencyCount { get => ReadStructure<KiProcessConcurrencyCount>(nameof(ExpectedConcurrencyCount)); set => WriteStructure(nameof(ExpectedConcurrencyCount), value); }

        [Offset(4UL)]
        public KiIdealProcessorSetBreakpoints Breakpoints { get => ReadStructure<KiIdealProcessorSetBreakpoints>(nameof(Breakpoints)); set => WriteStructure(nameof(Breakpoints), value); }

        [Offset(12UL)]
        public UnnamedTag AssignmentFlags { get => ReadStructure<UnnamedTag>(nameof(AssignmentFlags)); set => WriteStructure(nameof(AssignmentFlags), value); }

        [Offset(16UL)]
        [Length(32)]
        public DynamicArray ThreadSeed { get => ReadStructure<DynamicArray>(nameof(ThreadSeed)); set => WriteStructure(nameof(ThreadSeed), value); }

        [Offset(80UL)]
        [Length(32)]
        public DynamicArray IdealProcessor { get => ReadStructure<DynamicArray>(nameof(IdealProcessor)); set => WriteStructure(nameof(IdealProcessor), value); }

        [Offset(144UL)]
        [Length(32)]
        public DynamicArray IdealNode { get => ReadStructure<DynamicArray>(nameof(IdealNode)); set => WriteStructure(nameof(IdealNode), value); }

        [Offset(208UL)]
        public KaffinityEx IdealProcessorSets { get => ReadStructure<KaffinityEx>(nameof(IdealProcessorSets)); set => WriteStructure(nameof(IdealProcessorSets), value); }

        public KiIdealProcessorAssignmentBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiIdealProcessorAssignmentBlock>();
        }
    }
}