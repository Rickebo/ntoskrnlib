#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_PAGE_COMBINE_STATISTICS
    {
        [FieldOffset(0)]
        public ulong PagesScannedActive;
        [FieldOffset(8)]
        public ulong PagesScannedStandby;
        [FieldOffset(16)]
        public ulong PagesCombined;
        [FieldOffset(24)]
        public uint CombineScanCount;
        [FieldOffset(28)]
        public int CombinedBlocksInUse;
        [FieldOffset(32)]
        public int SumCombinedBlocksReferenceCount;
        [FieldOffset(36)]
        public uint NonSlabPagesUsedForInPage;
    }
}