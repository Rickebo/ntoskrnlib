using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SYSPTES_HEADER")]
    public sealed class _SYSPTES_HEADER : DynamicStructure
    {
        public byte[] ListHead { get; }
        public ulong Count { get; }
        public ulong NumberOfEntries { get; }
        public ulong NumberOfEntriesPeak { get; }

        public _SYSPTES_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SYSPTES_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SYSPTES_HEADER.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYSPTES_HEADER.Count),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_SYSPTES_HEADER.NumberOfEntries),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_SYSPTES_HEADER.NumberOfEntriesPeak),
                    new ulong[]
                    {
                        272UL
                    }
                }
            };
            Register<_SYSPTES_HEADER>((mem, ptr) => new _SYSPTES_HEADER(mem, ptr), offsets);
        }
    }
}