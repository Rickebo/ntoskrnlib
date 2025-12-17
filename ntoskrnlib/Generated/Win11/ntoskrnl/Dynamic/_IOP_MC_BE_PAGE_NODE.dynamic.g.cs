using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOP_MC_BE_PAGE_NODE")]
    public sealed class _IOP_MC_BE_PAGE_NODE : DynamicStructure
    {
        public _RTL_BALANCED_NODE Node { get; }
        public uint PageIndex { get; }

        public _IOP_MC_BE_PAGE_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOP_MC_BE_PAGE_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOP_MC_BE_PAGE_NODE.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_MC_BE_PAGE_NODE.PageIndex),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_IOP_MC_BE_PAGE_NODE>((mem, ptr) => new _IOP_MC_BE_PAGE_NODE(mem, ptr), offsets);
        }
    }
}