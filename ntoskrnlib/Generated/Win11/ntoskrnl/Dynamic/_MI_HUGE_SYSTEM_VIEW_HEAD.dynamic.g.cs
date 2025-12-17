using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_HUGE_SYSTEM_VIEW_HEAD")]
    public sealed class _MI_HUGE_SYSTEM_VIEW_HEAD : DynamicStructure
    {
        public _RTL_AVL_TREE ViewRoot { get; }
        public uint ViewCount { get; }
        public int Lock { get; }

        public _MI_HUGE_SYSTEM_VIEW_HEAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_HUGE_SYSTEM_VIEW_HEAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_HUGE_SYSTEM_VIEW_HEAD.ViewRoot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_HUGE_SYSTEM_VIEW_HEAD.ViewCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_HUGE_SYSTEM_VIEW_HEAD.Lock),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_MI_HUGE_SYSTEM_VIEW_HEAD>((mem, ptr) => new _MI_HUGE_SYSTEM_VIEW_HEAD(mem, ptr), offsets);
        }
    }
}