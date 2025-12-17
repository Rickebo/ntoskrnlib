using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KNODE_SUBNODE_SEARCH_RANKS")]
    public sealed class _KNODE_SUBNODE_SEARCH_RANKS : DynamicStructure
    {
        public byte[] Ranks { get; }

        public _KNODE_SUBNODE_SEARCH_RANKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KNODE_SUBNODE_SEARCH_RANKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KNODE_SUBNODE_SEARCH_RANKS.Ranks),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KNODE_SUBNODE_SEARCH_RANKS>((mem, ptr) => new _KNODE_SUBNODE_SEARCH_RANKS(mem, ptr), offsets);
        }
    }
}