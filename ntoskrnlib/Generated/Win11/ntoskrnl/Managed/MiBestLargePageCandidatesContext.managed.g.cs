using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT")]
    public sealed class MiBestLargePageCandidatesContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint BestCandidateCountMax { get => ReadHere<uint>(nameof(BestCandidateCountMax)); set => WriteHere(nameof(BestCandidateCountMax), value); }

        [Offset(4UL)]
        public uint BestCandidateCount { get => ReadHere<uint>(nameof(BestCandidateCount)); set => WriteHere(nameof(BestCandidateCount), value); }

        [Offset(8UL)]
        public uint BestCandidatesTried { get => ReadHere<uint>(nameof(BestCandidatesTried)); set => WriteHere(nameof(BestCandidatesTried), value); }

        [Offset(12UL)]
        public uint CandidateUsed { get => ReadHere<uint>(nameof(CandidateUsed)); set => WriteHere(nameof(CandidateUsed), value); }

        [Offset(16UL)]
        public ulong NextLargePage { get => ReadHere<ulong>(nameof(NextLargePage)); set => WriteHere(nameof(NextLargePage), value); }

        [Offset(24UL)]
        [Length(8)]
        public DynamicArray BestCandidatesBasePage { get => ReadStructure<DynamicArray>(nameof(BestCandidatesBasePage)); set => WriteStructure(nameof(BestCandidatesBasePage), value); }

        public MiBestLargePageCandidatesContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiBestLargePageCandidatesContext>();
        }
    }
}