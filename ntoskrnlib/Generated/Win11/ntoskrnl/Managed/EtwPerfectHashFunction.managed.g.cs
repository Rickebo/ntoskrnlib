using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PERFECT_HASH_FUNCTION")]
    public sealed class EtwPerfectHashFunction : DynamicStructure
    {
        public EtwPerfectHashFunction(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwPerfectHashFunction>();
        }
    }
}