using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KFORCE_PARK_DUTY_CYCLE_DATA")]
    public sealed class KforceParkDutyCycleData : DynamicStructure
    {
        public KforceParkDutyCycleData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KforceParkDutyCycleData>();
        }
    }
}