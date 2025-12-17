using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT")]
    public sealed class _MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT : DynamicStructure
    {
        public _KEVENT CandidatesExistEvent { get; }
        public ulong InProgressBitmapIndex { get; }
        public int DemandCoalesceAttempted { get; }
        public int DemandCoalesceTimedOut { get; }
        public int DemandCoalesceTimedOutCSwitch { get; }
        public int DemandCoalesceSucceeded { get; }

        public _MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT.CandidatesExistEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT.InProgressBitmapIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT.DemandCoalesceAttempted),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT.DemandCoalesceTimedOut),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT.DemandCoalesceTimedOutCSwitch),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT.DemandCoalesceSucceeded),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT>((mem, ptr) => new _MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT(mem, ptr), offsets);
        }
    }
}