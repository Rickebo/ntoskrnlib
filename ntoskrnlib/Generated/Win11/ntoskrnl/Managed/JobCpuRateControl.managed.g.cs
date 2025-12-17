using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_JOB_CPU_RATE_CONTROL")]
    public sealed class JobCpuRateControl : DynamicStructure
    {
        public JobCpuRateControl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<JobCpuRateControl>();
        }
    }
}