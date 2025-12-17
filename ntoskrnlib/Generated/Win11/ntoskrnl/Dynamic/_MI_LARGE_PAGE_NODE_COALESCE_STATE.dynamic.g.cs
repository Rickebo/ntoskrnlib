using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_LARGE_PAGE_NODE_COALESCE_STATE")]
    public sealed class _MI_LARGE_PAGE_NODE_COALESCE_STATE : DynamicStructure
    {
        public long[] CandidateCount { get; }
        public ulong[] NewCandidateSequence { get; }

        public _MI_LARGE_PAGE_NODE_COALESCE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_LARGE_PAGE_NODE_COALESCE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_LARGE_PAGE_NODE_COALESCE_STATE.CandidateCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_LARGE_PAGE_NODE_COALESCE_STATE.NewCandidateSequence),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_LARGE_PAGE_NODE_COALESCE_STATE>((mem, ptr) => new _MI_LARGE_PAGE_NODE_COALESCE_STATE(mem, ptr), offsets);
        }
    }
}