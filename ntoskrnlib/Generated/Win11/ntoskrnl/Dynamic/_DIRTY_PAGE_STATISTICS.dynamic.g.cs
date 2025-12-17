using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DIRTY_PAGE_STATISTICS")]
    public sealed class _DIRTY_PAGE_STATISTICS : DynamicStructure
    {
        public ulong DirtyPages { get; }
        public ulong DirtyPagesLastScan { get; }
        public uint DirtyPagesScheduledLastScan { get; }

        public _DIRTY_PAGE_STATISTICS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DIRTY_PAGE_STATISTICS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DIRTY_PAGE_STATISTICS.DirtyPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_STATISTICS.DirtyPagesLastScan),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_STATISTICS.DirtyPagesScheduledLastScan),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DIRTY_PAGE_STATISTICS>((mem, ptr) => new _DIRTY_PAGE_STATISTICS(mem, ptr), offsets);
        }
    }
}