using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_ACTIVE_PAGE_TABLE_LINKS")]
    public sealed class _MMPTE_ACTIVE_PAGE_TABLE_LINKS : DynamicStructure
    {
        public ulong Flink { get; }
        public ulong BlinkHigh { get; }

        public _MMPTE_ACTIVE_PAGE_TABLE_LINKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_ACTIVE_PAGE_TABLE_LINKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_ACTIVE_PAGE_TABLE_LINKS.Flink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_ACTIVE_PAGE_TABLE_LINKS.BlinkHigh),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_ACTIVE_PAGE_TABLE_LINKS>((mem, ptr) => new _MMPTE_ACTIVE_PAGE_TABLE_LINKS(mem, ptr), offsets);
        }
    }
}