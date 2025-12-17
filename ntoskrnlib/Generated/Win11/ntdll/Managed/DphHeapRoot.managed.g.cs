using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DPH_HEAP_ROOT")]
    public sealed class DphHeapRoot : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint HeapFlags { get => ReadHere<uint>(nameof(HeapFlags)); set => WriteHere(nameof(HeapFlags), value); }

        [Offset(8UL)]
        public IntPtr HeapCritSect { get => ReadHere<IntPtr>(nameof(HeapCritSect)); set => WriteHere(nameof(HeapCritSect), value); }

        [Offset(16UL)]
        public uint nRemoteLockAcquired { get => ReadHere<uint>(nameof(nRemoteLockAcquired)); set => WriteHere(nameof(nRemoteLockAcquired), value); }

        [Offset(24UL)]
        public IntPtr pVirtualStorageListHead { get => ReadHere<IntPtr>(nameof(pVirtualStorageListHead)); set => WriteHere(nameof(pVirtualStorageListHead), value); }

        [Offset(32UL)]
        public IntPtr pVirtualStorageListTail { get => ReadHere<IntPtr>(nameof(pVirtualStorageListTail)); set => WriteHere(nameof(pVirtualStorageListTail), value); }

        [Offset(40UL)]
        public uint nVirtualStorageRanges { get => ReadHere<uint>(nameof(nVirtualStorageRanges)); set => WriteHere(nameof(nVirtualStorageRanges), value); }

        [Offset(48UL)]
        public ulong nVirtualStorageBytes { get => ReadHere<ulong>(nameof(nVirtualStorageBytes)); set => WriteHere(nameof(nVirtualStorageBytes), value); }

        [Offset(56UL)]
        public RtlAvlTable BusyNodesTable { get => ReadStructure<RtlAvlTable>(nameof(BusyNodesTable)); set => WriteStructure(nameof(BusyNodesTable), value); }

        [Offset(160UL)]
        public IntPtr NodeToAllocate { get => ReadHere<IntPtr>(nameof(NodeToAllocate)); set => WriteHere(nameof(NodeToAllocate), value); }

        [Offset(168UL)]
        public uint nBusyAllocations { get => ReadHere<uint>(nameof(nBusyAllocations)); set => WriteHere(nameof(nBusyAllocations), value); }

        [Offset(176UL)]
        public ulong nBusyAllocationBytesCommitted { get => ReadHere<ulong>(nameof(nBusyAllocationBytesCommitted)); set => WriteHere(nameof(nBusyAllocationBytesCommitted), value); }

        [Offset(184UL)]
        public IntPtr pFreeAllocationListHead { get => ReadHere<IntPtr>(nameof(pFreeAllocationListHead)); set => WriteHere(nameof(pFreeAllocationListHead), value); }

        [Offset(192UL)]
        public IntPtr pFreeAllocationListTail { get => ReadHere<IntPtr>(nameof(pFreeAllocationListTail)); set => WriteHere(nameof(pFreeAllocationListTail), value); }

        [Offset(200UL)]
        public uint nFreeAllocations { get => ReadHere<uint>(nameof(nFreeAllocations)); set => WriteHere(nameof(nFreeAllocations), value); }

        [Offset(208UL)]
        public ulong nFreeAllocationBytesCommitted { get => ReadHere<ulong>(nameof(nFreeAllocationBytesCommitted)); set => WriteHere(nameof(nFreeAllocationBytesCommitted), value); }

        [Offset(216UL)]
        public ListEntry AvailableAllocationHead { get => ReadStructure<ListEntry>(nameof(AvailableAllocationHead)); set => WriteStructure(nameof(AvailableAllocationHead), value); }

        [Offset(232UL)]
        public uint nAvailableAllocations { get => ReadHere<uint>(nameof(nAvailableAllocations)); set => WriteHere(nameof(nAvailableAllocations), value); }

        [Offset(240UL)]
        public ulong nAvailableAllocationBytesCommitted { get => ReadHere<ulong>(nameof(nAvailableAllocationBytesCommitted)); set => WriteHere(nameof(nAvailableAllocationBytesCommitted), value); }

        [Offset(248UL)]
        public IntPtr pUnusedNodeListHead { get => ReadHere<IntPtr>(nameof(pUnusedNodeListHead)); set => WriteHere(nameof(pUnusedNodeListHead), value); }

        [Offset(256UL)]
        public IntPtr pUnusedNodeListTail { get => ReadHere<IntPtr>(nameof(pUnusedNodeListTail)); set => WriteHere(nameof(pUnusedNodeListTail), value); }

        [Offset(264UL)]
        public uint nUnusedNodes { get => ReadHere<uint>(nameof(nUnusedNodes)); set => WriteHere(nameof(nUnusedNodes), value); }

        [Offset(272UL)]
        public ulong nBusyAllocationBytesAccessible { get => ReadHere<ulong>(nameof(nBusyAllocationBytesAccessible)); set => WriteHere(nameof(nBusyAllocationBytesAccessible), value); }

        [Offset(280UL)]
        public IntPtr pNodePoolListHead { get => ReadHere<IntPtr>(nameof(pNodePoolListHead)); set => WriteHere(nameof(pNodePoolListHead), value); }

        [Offset(288UL)]
        public IntPtr pNodePoolListTail { get => ReadHere<IntPtr>(nameof(pNodePoolListTail)); set => WriteHere(nameof(pNodePoolListTail), value); }

        [Offset(296UL)]
        public uint nNodePools { get => ReadHere<uint>(nameof(nNodePools)); set => WriteHere(nameof(nNodePools), value); }

        [Offset(304UL)]
        public ulong nNodePoolBytes { get => ReadHere<ulong>(nameof(nNodePoolBytes)); set => WriteHere(nameof(nNodePoolBytes), value); }

        [Offset(312UL)]
        public ListEntry NextHeap { get => ReadStructure<ListEntry>(nameof(NextHeap)); set => WriteStructure(nameof(NextHeap), value); }

        [Offset(328UL)]
        public uint ExtraFlags { get => ReadHere<uint>(nameof(ExtraFlags)); set => WriteHere(nameof(ExtraFlags), value); }

        [Offset(332UL)]
        public uint Seed { get => ReadHere<uint>(nameof(Seed)); set => WriteHere(nameof(Seed), value); }

        [Offset(336UL)]
        public IntPtr NormalHeap { get => ReadHere<IntPtr>(nameof(NormalHeap)); set => WriteHere(nameof(NormalHeap), value); }

        [Offset(344UL)]
        public IntPtr CreateStackTrace { get => ReadHere<IntPtr>(nameof(CreateStackTrace)); set => WriteHere(nameof(CreateStackTrace), value); }

        [Offset(352UL)]
        public IntPtr FirstThread { get => ReadHere<IntPtr>(nameof(FirstThread)); set => WriteHere(nameof(FirstThread), value); }

        public DphHeapRoot(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DphHeapRoot>();
        }
    }
}