using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SEARCH_MEMORY")]
    public sealed class _DBGKD_SEARCH_MEMORY : DynamicStructure
    {
        public ulong SearchAddress { get; }
        public ulong FoundAddress { get; }
        public ulong SearchLength { get; }
        public uint PatternLength { get; }

        public _DBGKD_SEARCH_MEMORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SEARCH_MEMORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SEARCH_MEMORY.SearchAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_SEARCH_MEMORY.FoundAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_SEARCH_MEMORY.SearchLength),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_SEARCH_MEMORY.PatternLength),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DBGKD_SEARCH_MEMORY>((mem, ptr) => new _DBGKD_SEARCH_MEMORY(mem, ptr), offsets);
        }
    }
}