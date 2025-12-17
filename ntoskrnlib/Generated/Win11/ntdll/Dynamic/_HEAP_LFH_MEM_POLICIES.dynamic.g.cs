using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_MEM_POLICIES")]
    public sealed class _HEAP_LFH_MEM_POLICIES : DynamicStructure
    {
        public uint DisableAffinity { get; }
        public uint SlowSubsegmentGrowth { get; }
        public uint Spare { get; }
        public uint AllPolicies { get; }

        public _HEAP_LFH_MEM_POLICIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_MEM_POLICIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_MEM_POLICIES.DisableAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_MEM_POLICIES.SlowSubsegmentGrowth),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_MEM_POLICIES.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_MEM_POLICIES.AllPolicies),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_MEM_POLICIES>((mem, ptr) => new _HEAP_LFH_MEM_POLICIES(mem, ptr), offsets);
        }
    }
}