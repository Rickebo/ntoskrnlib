using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_BLOCK_SLIST")]
    public sealed class _HEAP_LFH_BLOCK_SLIST : DynamicStructure
    {
        public ushort Next { get; }

        public _HEAP_LFH_BLOCK_SLIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_BLOCK_SLIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_BLOCK_SLIST.Next),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_BLOCK_SLIST>((mem, ptr) => new _HEAP_LFH_BLOCK_SLIST(mem, ptr), offsets);
        }
    }
}