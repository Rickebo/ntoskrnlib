#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 5824)]
    public partial struct _MI_VISIBLE_STATE
    {
        [FieldOffset(0)]
        public _MM_PAGED_POOL_INFO PagedPoolInfo;
        [FieldOffset(24)]
        public ulong MaximumNonPagedPoolInPages;
        [FieldOffset(32)]
        public ulong SizeOfPagedPoolInPages;
        [FieldOffset(40)]
        public _MI_SYSTEM_PTE_TYPE SystemPteInfo;
        [FieldOffset(136)]
        public ulong NonPagedPoolCommit;
        [FieldOffset(144)]
        public ulong SmallNonPagedPtesCommit;
        [FieldOffset(152)]
        public ulong BootCommit;
        [FieldOffset(160)]
        public ulong SystemPageTableCommit;
        [FieldOffset(168)]
        public ulong ProcessCommit;
        [FieldOffset(176)]
        public int DriverCommit;
        [FieldOffset(180)]
        public byte PagingLevels;
        [FieldOffset(184)]
        public ulong PfnDatabaseCommit;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ulong[] TotalNodePagesInChildPartitions;
        [FieldOffset(704)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ulong[] TotalSpecialPurposeMemoryInChildPartitions;
        [FieldOffset(1728)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public _MMSUPPORT_FULL[] SystemWs;
        [FieldOffset(4608)]
        public _MMSUPPORT_SHARED SystemCacheShared;
        [FieldOffset(4736)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _MMSUPPORT_AGGREGATION[] AggregateSystemWs;
        [FieldOffset(4768)]
        public uint MapCacheFailures;
        [FieldOffset(4776)]
        public ulong PagefileHashPages;
        [FieldOffset(4784)]
        public _SYSPTES_HEADER PteHeader;
        [FieldOffset(5064)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public ulong[] SystemVaTypeCount;
        [FieldOffset(5224)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] SystemVaType;
        [FieldOffset(5480)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public _MI_SYSTEM_VA_ASSIGNMENT[] SystemVaRegions;
        [FieldOffset(5768)]
        public ulong SecurePtRoot;
    }
}