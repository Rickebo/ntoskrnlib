using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_SCOPE_MAP_ENTRY")]
    public sealed class _WNF_SCOPE_MAP_ENTRY : DynamicStructure
    {
        public _WNF_LOCK MapEntryLock { get; }
        public _LIST_ENTRY MapEntryHead { get; }

        public _WNF_SCOPE_MAP_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_SCOPE_MAP_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_SCOPE_MAP_ENTRY.MapEntryLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_MAP_ENTRY.MapEntryHead),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_WNF_SCOPE_MAP_ENTRY>((mem, ptr) => new _WNF_SCOPE_MAP_ENTRY(mem, ptr), offsets);
        }
    }
}