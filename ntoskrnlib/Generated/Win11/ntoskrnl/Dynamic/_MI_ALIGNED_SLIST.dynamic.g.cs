using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ALIGNED_SLIST")]
    public sealed class _MI_ALIGNED_SLIST : DynamicStructure
    {
        public _SLIST_HEADER SList { get; }

        public _MI_ALIGNED_SLIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ALIGNED_SLIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ALIGNED_SLIST.SList),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_ALIGNED_SLIST>((mem, ptr) => new _MI_ALIGNED_SLIST(mem, ptr), offsets);
        }
    }
}