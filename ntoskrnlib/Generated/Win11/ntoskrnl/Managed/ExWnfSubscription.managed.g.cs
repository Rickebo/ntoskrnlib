using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_WNF_SUBSCRIPTION")]
    public sealed class ExWnfSubscription : DynamicStructure
    {
        public ExWnfSubscription(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExWnfSubscription>();
        }
    }
}