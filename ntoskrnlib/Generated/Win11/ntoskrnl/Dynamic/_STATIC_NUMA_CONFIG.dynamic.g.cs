using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STATIC_NUMA_CONFIG")]
    public sealed class _STATIC_NUMA_CONFIG : DynamicStructure
    {
        public IntPtr ProcessorLocalId { get; }
        public IntPtr ProcessorUid { get; }
        public IntPtr ProcessorProximity { get; }
        public IntPtr ProximityId { get; }
        public IntPtr OrigProximityId { get; }
        public IntPtr NodeCapacity { get; }
        public IntPtr NodeDistance { get; }
        public uint NodeCount { get; }
        public uint ProcessorCount { get; }
        public uint AllocatedNodeCount { get; }
        public uint AllocatedProcCount { get; }

        public _STATIC_NUMA_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STATIC_NUMA_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STATIC_NUMA_CONFIG.ProcessorLocalId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.ProcessorUid),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.ProcessorProximity),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.ProximityId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.OrigProximityId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.NodeCapacity),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.NodeDistance),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.NodeCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.ProcessorCount),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.AllocatedNodeCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_STATIC_NUMA_CONFIG.AllocatedProcCount),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_STATIC_NUMA_CONFIG>((mem, ptr) => new _STATIC_NUMA_CONFIG(mem, ptr), offsets);
        }
    }
}