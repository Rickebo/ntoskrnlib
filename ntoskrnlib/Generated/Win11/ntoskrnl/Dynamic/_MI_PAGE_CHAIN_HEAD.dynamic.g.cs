using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_CHAIN_HEAD")]
    public sealed class _MI_PAGE_CHAIN_HEAD : DynamicStructure
    {
        public IntPtr Head { get; }
        public IntPtr Tail { get; }
        public ulong NumberOfEntries { get; }

        public _MI_PAGE_CHAIN_HEAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGE_CHAIN_HEAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGE_CHAIN_HEAD.Head),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGE_CHAIN_HEAD.Tail),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGE_CHAIN_HEAD.NumberOfEntries),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MI_PAGE_CHAIN_HEAD>((mem, ptr) => new _MI_PAGE_CHAIN_HEAD(mem, ptr), offsets);
        }
    }
}