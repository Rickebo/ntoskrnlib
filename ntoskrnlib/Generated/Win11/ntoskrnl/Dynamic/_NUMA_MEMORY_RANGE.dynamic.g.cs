using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NUMA_MEMORY_RANGE")]
    public sealed class _NUMA_MEMORY_RANGE : DynamicStructure
    {
        public uint ProximityId { get; }
        public ulong BasePage { get; }
        public ulong EndPage { get; }

        public _NUMA_MEMORY_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NUMA_MEMORY_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NUMA_MEMORY_RANGE.ProximityId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NUMA_MEMORY_RANGE.BasePage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NUMA_MEMORY_RANGE.EndPage),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NUMA_MEMORY_RANGE>((mem, ptr) => new _NUMA_MEMORY_RANGE(mem, ptr), offsets);
        }
    }
}