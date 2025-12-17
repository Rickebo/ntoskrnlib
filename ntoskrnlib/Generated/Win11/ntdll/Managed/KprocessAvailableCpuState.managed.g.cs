using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KPROCESS_AVAILABLE_CPU_STATE")]
    public sealed class KprocessAvailableCpuState : DynamicStructure
    {
        public KprocessAvailableCpuState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprocessAvailableCpuState>();
        }
    }
}