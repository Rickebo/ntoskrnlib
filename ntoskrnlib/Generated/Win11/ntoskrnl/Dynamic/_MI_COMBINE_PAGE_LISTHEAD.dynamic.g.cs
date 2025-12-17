using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_PAGE_LISTHEAD")]
    public sealed class _MI_COMBINE_PAGE_LISTHEAD : DynamicStructure
    {
        public _RTL_AVL_TREE Table { get; }
        public int Lock { get; }

        public _MI_COMBINE_PAGE_LISTHEAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COMBINE_PAGE_LISTHEAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COMBINE_PAGE_LISTHEAD.Table),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COMBINE_PAGE_LISTHEAD.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_COMBINE_PAGE_LISTHEAD>((mem, ptr) => new _MI_COMBINE_PAGE_LISTHEAD(mem, ptr), offsets);
        }
    }
}