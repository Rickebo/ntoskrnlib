using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_JOB_NOTIFICATION_INFORMATION")]
    public sealed class JobNotificationInformation : DynamicStructure
    {
        public JobNotificationInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<JobNotificationInformation>();
        }
    }
}