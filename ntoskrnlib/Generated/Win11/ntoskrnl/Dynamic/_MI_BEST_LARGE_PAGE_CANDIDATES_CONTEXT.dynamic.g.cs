using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT")]
    public sealed class _MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT : DynamicStructure
    {
        public uint BestCandidateCountMax { get; }
        public uint BestCandidateCount { get; }
        public uint BestCandidatesTried { get; }
        public uint CandidateUsed { get; }
        public ulong NextLargePage { get; }
        public ulong[] BestCandidatesBasePage { get; }

        public _MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT.BestCandidateCountMax),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT.BestCandidateCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT.BestCandidatesTried),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT.CandidateUsed),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT.NextLargePage),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT.BestCandidatesBasePage),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT>((mem, ptr) => new _MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT(mem, ptr), offsets);
        }
    }
}