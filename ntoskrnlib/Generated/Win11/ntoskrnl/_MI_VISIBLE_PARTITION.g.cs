#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 5376)]
    public partial struct _MI_VISIBLE_PARTITION
    {
        [FieldOffset(0)]
        public ulong LowestPhysicalPage;
        [FieldOffset(8)]
        public ulong HighestPhysicalPage;
        [FieldOffset(16)]
        public ulong NumberOfPhysicalPages;
        [FieldOffset(24)]
        public uint NumberOfPagingFiles;
        [FieldOffset(28)]
        public byte SystemCacheInitialized;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public IntPtr[] PagingFile;
        [FieldOffset(192)]
        public ulong AvailablePages;
        [FieldOffset(256)]
        public ulong ResidentAvailablePages;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _MI_PARTITION_WORKING_SET[] PartitionWs;
        [FieldOffset(768)]
        public ulong TotalCommittedPages;
        [FieldOffset(832)]
        public ulong TotalCommittedPagesExposed;
        [FieldOffset(896)]
        public _MMPFNLIST ModifiedPageListHead;
        [FieldOffset(1024)]
        public _MMPFNLIST ModifiedNoWritePageListHead;
        [FieldOffset(1112)]
        public ulong TotalCommitLimit;
        [FieldOffset(1120)]
        public ulong TotalPagesForPagingFile;
        [FieldOffset(1128)]
        public ulong VadPhysicalPages;
        [FieldOffset(1136)]
        public ulong ProcessLockedFilePages;
        [FieldOffset(1144)]
        public ulong SharedCommit;
        [FieldOffset(1152)]
        public ulong MdlPagesAllocated;
        [FieldOffset(1160)]
        public ulong ContiguousPagesAllocated;
        [FieldOffset(1168)]
        public ulong SlabAllocatorPages;
        [FieldOffset(1176)]
        public ulong SlabAllocatorPagesUncharged;
        [FieldOffset(1184)]
        public ulong BootSlabPages;
        [FieldOffset(1192)]
        public ulong SecureKernelPagesFromNonChargedSlabs;
        [FieldOffset(1200)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] ChargeCommitmentFailures;
        [FieldOffset(1216)]
        public int PageFileTraceIndex;
        [FieldOffset(1224)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _MI_PAGEFILE_TRACES[] PageFileTraces;
    }
}