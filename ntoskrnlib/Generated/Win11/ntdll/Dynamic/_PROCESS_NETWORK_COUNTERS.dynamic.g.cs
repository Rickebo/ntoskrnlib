using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESS_NETWORK_COUNTERS")]
    public sealed class _PROCESS_NETWORK_COUNTERS : DynamicStructure
    {
        public ulong BytesIn { get; }
        public ulong BytesOut { get; }

        public _PROCESS_NETWORK_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_NETWORK_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_NETWORK_COUNTERS.BytesIn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_NETWORK_COUNTERS.BytesOut),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PROCESS_NETWORK_COUNTERS>((mem, ptr) => new _PROCESS_NETWORK_COUNTERS(mem, ptr), offsets);
        }
    }
}