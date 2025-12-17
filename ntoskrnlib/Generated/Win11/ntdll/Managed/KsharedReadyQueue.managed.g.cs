using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSHARED_READY_QUEUE")]
    public sealed class KsharedReadyQueue : DynamicStructure
    {
        public KsharedReadyQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsharedReadyQueue>();
        }
    }
}