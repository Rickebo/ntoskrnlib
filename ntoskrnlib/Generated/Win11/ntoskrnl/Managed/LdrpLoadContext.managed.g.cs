using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LDRP_LOAD_CONTEXT")]
    public sealed class LdrpLoadContext : DynamicStructure
    {
        public LdrpLoadContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LdrpLoadContext>();
        }
    }
}