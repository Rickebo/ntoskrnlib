using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_AFFINITY_MGR")]
    public sealed class _HEAP_AFFINITY_MGR : DynamicStructure
    {
        public sbyte MapInProgress { get; }
        public sbyte ContentionCount { get; }
        public byte ContentionCountLimit { get; }
        public byte ConservativeAffinity { get; }
        public ulong LastContentionTime { get; }

        public _HEAP_AFFINITY_MGR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_AFFINITY_MGR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_AFFINITY_MGR.MapInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_AFFINITY_MGR.ContentionCount),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_HEAP_AFFINITY_MGR.ContentionCountLimit),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_AFFINITY_MGR.ConservativeAffinity),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_HEAP_AFFINITY_MGR.LastContentionTime),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_AFFINITY_MGR>((mem, ptr) => new _HEAP_AFFINITY_MGR(mem, ptr), offsets);
        }
    }
}