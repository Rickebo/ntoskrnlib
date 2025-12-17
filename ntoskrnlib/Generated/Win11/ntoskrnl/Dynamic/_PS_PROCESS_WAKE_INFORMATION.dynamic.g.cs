using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_PROCESS_WAKE_INFORMATION")]
    public sealed class _PS_PROCESS_WAKE_INFORMATION : DynamicStructure
    {
        public ulong NotificationChannel { get; }
        public uint[] WakeCounters { get; }
        public _JOBOBJECT_WAKE_FILTER WakeFilter { get; }
        public uint NoWakeCounter { get; }

        public _PS_PROCESS_WAKE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_PROCESS_WAKE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_PROCESS_WAKE_INFORMATION.NotificationChannel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_PROCESS_WAKE_INFORMATION.WakeCounters),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PS_PROCESS_WAKE_INFORMATION.WakeFilter),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PS_PROCESS_WAKE_INFORMATION.NoWakeCounter),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_PS_PROCESS_WAKE_INFORMATION>((mem, ptr) => new _PS_PROCESS_WAKE_INFORMATION(mem, ptr), offsets);
        }
    }
}