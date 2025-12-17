using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KPRCB_TRACEPOINT_LOG")]
    public sealed class KprcbTracepointLog : DynamicStructure
    {
        public KprcbTracepointLog(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprcbTracepointLog>();
        }
    }
}