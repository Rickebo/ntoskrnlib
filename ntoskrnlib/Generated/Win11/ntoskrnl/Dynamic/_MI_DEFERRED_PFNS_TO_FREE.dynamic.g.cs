using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DEFERRED_PFNS_TO_FREE")]
    public sealed class _MI_DEFERRED_PFNS_TO_FREE : DynamicStructure
    {
        public _LIST_ENTRY ListHead { get; }
        public ulong NumberOfPages { get; }
        public uint TbFlushStamp { get; }

        public _MI_DEFERRED_PFNS_TO_FREE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DEFERRED_PFNS_TO_FREE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DEFERRED_PFNS_TO_FREE.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DEFERRED_PFNS_TO_FREE.NumberOfPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_DEFERRED_PFNS_TO_FREE.TbFlushStamp),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_DEFERRED_PFNS_TO_FREE>((mem, ptr) => new _MI_DEFERRED_PFNS_TO_FREE(mem, ptr), offsets);
        }
    }
}