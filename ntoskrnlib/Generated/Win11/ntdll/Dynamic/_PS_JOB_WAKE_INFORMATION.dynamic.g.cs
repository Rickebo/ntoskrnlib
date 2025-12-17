using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_JOB_WAKE_INFORMATION")]
    public sealed class _PS_JOB_WAKE_INFORMATION : DynamicStructure
    {
        public ulong NotificationChannel { get; }
        public ulong[] WakeCounters { get; }
        public ulong NoWakeCounter { get; }

        public _PS_JOB_WAKE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_JOB_WAKE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_JOB_WAKE_INFORMATION.NotificationChannel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_JOB_WAKE_INFORMATION.WakeCounters),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PS_JOB_WAKE_INFORMATION.NoWakeCounter),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_PS_JOB_WAKE_INFORMATION>((mem, ptr) => new _PS_JOB_WAKE_INFORMATION(mem, ptr), offsets);
        }
    }
}