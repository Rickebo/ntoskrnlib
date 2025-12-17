#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _MI_BEST_LARGE_PAGE_CANDIDATES_CONTEXT
    {
        [FieldOffset(0)]
        public uint BestCandidateCountMax;
        [FieldOffset(4)]
        public uint BestCandidateCount;
        [FieldOffset(8)]
        public uint BestCandidatesTried;
        [FieldOffset(12)]
        public uint CandidateUsed;
        [FieldOffset(16)]
        public ulong NextLargePage;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] BestCandidatesBasePage;
    }
}