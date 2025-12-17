using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_REMOVAL_REQUESTED_PAGE")]
    public sealed class _MI_REMOVAL_REQUESTED_PAGE : DynamicStructure
    {
        public _RTL_BALANCED_NODE TreeNode { get; }
        public _LIST_ENTRY Link { get; }
        public IntPtr Pfn { get; }

        public _MI_REMOVAL_REQUESTED_PAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_REMOVAL_REQUESTED_PAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_REMOVAL_REQUESTED_PAGE.TreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REMOVAL_REQUESTED_PAGE.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REMOVAL_REQUESTED_PAGE.Pfn),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_REMOVAL_REQUESTED_PAGE>((mem, ptr) => new _MI_REMOVAL_REQUESTED_PAGE(mem, ptr), offsets);
        }
    }
}