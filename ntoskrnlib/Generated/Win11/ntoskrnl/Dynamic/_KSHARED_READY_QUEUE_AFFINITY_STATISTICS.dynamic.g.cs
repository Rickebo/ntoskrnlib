using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSHARED_READY_QUEUE_AFFINITY_STATISTICS")]
    public sealed class _KSHARED_READY_QUEUE_AFFINITY_STATISTICS : DynamicStructure
    {
        public ulong AffinitySummary { get; }

        public _KSHARED_READY_QUEUE_AFFINITY_STATISTICS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSHARED_READY_QUEUE_AFFINITY_STATISTICS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSHARED_READY_QUEUE_AFFINITY_STATISTICS.AffinitySummary),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KSHARED_READY_QUEUE_AFFINITY_STATISTICS>((mem, ptr) => new _KSHARED_READY_QUEUE_AFFINITY_STATISTICS(mem, ptr), offsets);
        }
    }
}