#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public partial struct _VF_TARGET_VERIFIED_DRIVER_DATA
    {
        [FieldOffset(0)]
        public IntPtr SuspectDriverEntry;
        [FieldOffset(8)]
        public IntPtr WMICallback;
        [FieldOffset(16)]
        public _LIST_ENTRY EtwHandlesListHead;
        [FieldOffset(32)]
        public _unnamed_tag_ u1;
        [FieldOffset(40)]
        public ulong Signature;
        [FieldOffset(48)]
        public byte SeSigningLevel;
        [FieldOffset(64)]
        public _SLIST_HEADER PoolPageHeaders;
        [FieldOffset(80)]
        public _SLIST_HEADER PoolTrackers;
        [FieldOffset(96)]
        public _LIST_ENTRY DifPluginPerDriverDataContextHead;
        [FieldOffset(112)]
        public uint CurrentPagedPoolAllocations;
        [FieldOffset(116)]
        public uint CurrentNonPagedPoolAllocations;
        [FieldOffset(120)]
        public uint PeakPagedPoolAllocations;
        [FieldOffset(124)]
        public uint PeakNonPagedPoolAllocations;
        [FieldOffset(128)]
        public ulong PagedBytes;
        [FieldOffset(136)]
        public ulong NonPagedBytes;
        [FieldOffset(144)]
        public ulong PeakPagedBytes;
        [FieldOffset(152)]
        public ulong PeakNonPagedBytes;
        [FieldOffset(160)]
        public uint RaiseIrqls;
        [FieldOffset(164)]
        public uint AcquireSpinLocks;
        [FieldOffset(168)]
        public uint SynchronizeExecutions;
        [FieldOffset(172)]
        public uint AllocationsWithNoTag;
        [FieldOffset(176)]
        public uint AllocationsFailed;
        [FieldOffset(180)]
        public uint AllocationsFailedDeliberately;
        [FieldOffset(184)]
        public ulong LockedBytes;
        [FieldOffset(192)]
        public ulong PeakLockedBytes;
        [FieldOffset(200)]
        public ulong MappedLockedBytes;
        [FieldOffset(208)]
        public ulong PeakMappedLockedBytes;
        [FieldOffset(216)]
        public ulong MappedIoSpaceBytes;
        [FieldOffset(224)]
        public ulong PeakMappedIoSpaceBytes;
        [FieldOffset(232)]
        public ulong PagesForMdlBytes;
        [FieldOffset(240)]
        public ulong PeakPagesForMdlBytes;
        [FieldOffset(248)]
        public ulong ContiguousMemoryBytes;
        [FieldOffset(256)]
        public ulong PeakContiguousMemoryBytes;
        [FieldOffset(264)]
        public _LIST_ENTRY ContiguousMemoryListHead;
    }
}