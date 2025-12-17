using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT")]
    public sealed class KiCooperativeIdleSearchContext : DynamicStructure
    {
        public KiCooperativeIdleSearchContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiCooperativeIdleSearchContext>();
        }
    }
}