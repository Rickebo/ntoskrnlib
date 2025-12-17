using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_PROCESS_ENERGY_CONTEXT")]
    public sealed class PoProcessEnergyContext : DynamicStructure
    {
        public PoProcessEnergyContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoProcessEnergyContext>();
        }
    }
}