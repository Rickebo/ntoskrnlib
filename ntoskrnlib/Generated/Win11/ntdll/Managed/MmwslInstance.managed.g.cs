using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MMWSL_INSTANCE")]
    public sealed class MmwslInstance : DynamicStructure
    {
        public MmwslInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmwslInstance>();
        }
    }
}