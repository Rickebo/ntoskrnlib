using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK")]
    public sealed class KiIdealProcessorAssignmentBlock : DynamicStructure
    {
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