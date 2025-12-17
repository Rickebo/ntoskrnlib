using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_JOB_NET_RATE_CONTROL")]
    public sealed class JobNetRateControl : DynamicStructure
    {
        public JobNetRateControl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<JobNetRateControl>();
        }
    }
}