#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial struct _MI_PAGING_IO_STATE
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE PageFileHead;
        [FieldOffset(8)]
        public int PageFileHeadSpinLock;
        [FieldOffset(12)]
        public _MI_PAGEFILE_METADATA_LAYOUT PageFileMetadata;
        [FieldOffset(20)]
        public int PrefetchSeekThreshold;
        [FieldOffset(24)]
        public uint InPageSinglePages;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _SLIST_HEADER[] InPageSupportSListHead;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _SLIST_HEADER[] ReservedInPageSupportSListHead;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] InPageSupportSListMinimum;
        [FieldOffset(104)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] FirstReservedInPageBlock;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] LastReservedInPageBlock;
        [FieldOffset(136)]
        public IntPtr ReservedPtes;
        [FieldOffset(144)]
        public int ReservedPtesLock;
        [FieldOffset(148)]
        public uint ReservedPtesBitBuffer;
        [FieldOffset(152)]
        public int DelayPageFaults;
        [FieldOffset(156)]
        public byte MdlsAdjusted;
        [FieldOffset(160)]
        public int NumberOfFailedStoreReads;
    }
}