using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_POOL_ENTRY")]
    public sealed class _VI_POOL_ENTRY : DynamicStructure
    {
        public _VI_POOL_PAGE_HEADER PageHeader { get; }
        public _VI_POOL_ENTRY_INUSE InUse { get; }
        public IntPtr NextFree { get; }

        public _VI_POOL_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_POOL_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_POOL_ENTRY.PageHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_POOL_ENTRY.InUse),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_POOL_ENTRY.NextFree),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_VI_POOL_ENTRY>((mem, ptr) => new _VI_POOL_ENTRY(mem, ptr), offsets);
        }
    }
}