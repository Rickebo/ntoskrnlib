using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LFH_BLOCK_ZONE")]
    public sealed class _LFH_BLOCK_ZONE : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public int NextIndex { get; }

        public _LFH_BLOCK_ZONE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LFH_BLOCK_ZONE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LFH_BLOCK_ZONE.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LFH_BLOCK_ZONE.NextIndex),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_LFH_BLOCK_ZONE>((mem, ptr) => new _LFH_BLOCK_ZONE(mem, ptr), offsets);
        }
    }
}