using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ETW_SILODRIVERSTATE")]
    public sealed class EtwSilodriverstate : DynamicStructure
    {
        public EtwSilodriverstate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSilodriverstate>();
        }
    }
}