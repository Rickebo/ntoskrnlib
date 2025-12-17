using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_IDEAL_PROCESSOR_SET_BREAKPOINTS")]
    public sealed class KiIdealProcessorSetBreakpoints : DynamicStructure
    {
        [Offset(0UL)]
        public KiProcessConcurrencyCount Low { get => ReadStructure<KiProcessConcurrencyCount>(nameof(Low)); set => WriteStructure(nameof(Low), value); }

        [Offset(4UL)]
        public KiProcessConcurrencyCount High { get => ReadStructure<KiProcessConcurrencyCount>(nameof(High)); set => WriteStructure(nameof(High), value); }

        public KiIdealProcessorSetBreakpoints(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiIdealProcessorSetBreakpoints>();
        }
    }
}