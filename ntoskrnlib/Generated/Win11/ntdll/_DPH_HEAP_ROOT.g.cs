#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 360)]
    public partial struct _DPH_HEAP_ROOT
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint HeapFlags;
        [FieldOffset(8)]
        public IntPtr HeapCritSect;
        [FieldOffset(16)]
        public uint nRemoteLockAcquired;
        [FieldOffset(24)]
        public IntPtr pVirtualStorageListHead;
        [FieldOffset(32)]
        public IntPtr pVirtualStorageListTail;
        [FieldOffset(40)]
        public uint nVirtualStorageRanges;
        [FieldOffset(48)]
        public ulong nVirtualStorageBytes;
        [FieldOffset(56)]
        public _RTL_AVL_TABLE BusyNodesTable;
        [FieldOffset(160)]
        public IntPtr NodeToAllocate;
        [FieldOffset(168)]
        public uint nBusyAllocations;
        [FieldOffset(176)]
        public ulong nBusyAllocationBytesCommitted;
        [FieldOffset(184)]
        public IntPtr pFreeAllocationListHead;
        [FieldOffset(192)]
        public IntPtr pFreeAllocationListTail;
        [FieldOffset(200)]
        public uint nFreeAllocations;
        [FieldOffset(208)]
        public ulong nFreeAllocationBytesCommitted;
        [FieldOffset(216)]
        public _LIST_ENTRY AvailableAllocationHead;
        [FieldOffset(232)]
        public uint nAvailableAllocations;
        [FieldOffset(240)]
        public ulong nAvailableAllocationBytesCommitted;
        [FieldOffset(248)]
        public IntPtr pUnusedNodeListHead;
        [FieldOffset(256)]
        public IntPtr pUnusedNodeListTail;
        [FieldOffset(264)]
        public uint nUnusedNodes;
        [FieldOffset(272)]
        public ulong nBusyAllocationBytesAccessible;
        [FieldOffset(280)]
        public IntPtr pNodePoolListHead;
        [FieldOffset(288)]
        public IntPtr pNodePoolListTail;
        [FieldOffset(296)]
        public uint nNodePools;
        [FieldOffset(304)]
        public ulong nNodePoolBytes;
        [FieldOffset(312)]
        public _LIST_ENTRY NextHeap;
        [FieldOffset(328)]
        public uint ExtraFlags;
        [FieldOffset(332)]
        public uint Seed;
        [FieldOffset(336)]
        public IntPtr NormalHeap;
        [FieldOffset(344)]
        public IntPtr CreateStackTrace;
        [FieldOffset(352)]
        public IntPtr FirstThread;
    }
}