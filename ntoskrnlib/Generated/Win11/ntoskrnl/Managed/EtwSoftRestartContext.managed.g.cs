using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SOFT_RESTART_CONTEXT")]
    public sealed class EtwSoftRestartContext : DynamicStructure
    {
        public EtwSoftRestartContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSoftRestartContext>();
        }
    }
}