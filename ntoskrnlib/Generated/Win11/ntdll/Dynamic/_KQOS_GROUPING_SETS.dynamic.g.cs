using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KQOS_GROUPING_SETS")]
    public sealed class _KQOS_GROUPING_SETS : DynamicStructure
    {
        public ulong SingleCoreSet { get; }
        public ulong SmtSet { get; }

        public _KQOS_GROUPING_SETS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KQOS_GROUPING_SETS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KQOS_GROUPING_SETS.SingleCoreSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KQOS_GROUPING_SETS.SmtSet),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KQOS_GROUPING_SETS>((mem, ptr) => new _KQOS_GROUPING_SETS(mem, ptr), offsets);
        }
    }
}