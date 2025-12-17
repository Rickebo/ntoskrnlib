using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KI_RESCHEDULE_CONTEXT")]
    public sealed class KiRescheduleContext : DynamicStructure
    {
        public KiRescheduleContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiRescheduleContext>();
        }
    }
}