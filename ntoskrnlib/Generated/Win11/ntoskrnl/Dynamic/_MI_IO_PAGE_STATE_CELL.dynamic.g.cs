using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_IO_PAGE_STATE_CELL")]
    public sealed class _MI_IO_PAGE_STATE_CELL : DynamicStructure
    {
        public _RTL_AVL_TREE PfnRoot { get; }
        public ulong UnmappedNodeCount { get; }
        public ulong UnmappedHugeIoSpaceNodeCount { get; }
        public ulong TotalNodeCount { get; }
        public ulong ResumePageForDeleteScans { get; }

        public _MI_IO_PAGE_STATE_CELL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_IO_PAGE_STATE_CELL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_IO_PAGE_STATE_CELL.PfnRoot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE_CELL.UnmappedNodeCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE_CELL.UnmappedHugeIoSpaceNodeCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE_CELL.TotalNodeCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_IO_PAGE_STATE_CELL.ResumePageForDeleteScans),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_MI_IO_PAGE_STATE_CELL>((mem, ptr) => new _MI_IO_PAGE_STATE_CELL(mem, ptr), offsets);
        }
    }
}