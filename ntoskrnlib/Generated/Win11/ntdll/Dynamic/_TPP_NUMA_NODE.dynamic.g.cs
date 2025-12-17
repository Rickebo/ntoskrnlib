using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_NUMA_NODE")]
    public sealed class _TPP_NUMA_NODE : DynamicStructure
    {
        public int WorkerCount { get; }

        public _TPP_NUMA_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_NUMA_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_NUMA_NODE.WorkerCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TPP_NUMA_NODE>((mem, ptr) => new _TPP_NUMA_NODE(mem, ptr), offsets);
        }
    }
}