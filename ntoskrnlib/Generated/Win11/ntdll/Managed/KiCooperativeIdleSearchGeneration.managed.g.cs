using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KI_COOPERATIVE_IDLE_SEARCH_GENERATION")]
    public sealed class KiCooperativeIdleSearchGeneration : DynamicStructure
    {
        public KiCooperativeIdleSearchGeneration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiCooperativeIdleSearchGeneration>();
        }
    }
}