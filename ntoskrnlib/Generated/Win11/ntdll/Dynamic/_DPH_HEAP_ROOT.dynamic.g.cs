using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DPH_HEAP_ROOT")]
    public sealed class _DPH_HEAP_ROOT : DynamicStructure
    {
        public uint Signature { get; }
        public uint HeapFlags { get; }
        public IntPtr HeapCritSect { get; }
        public uint nRemoteLockAcquired { get; }
        public IntPtr pVirtualStorageListHead { get; }
        public IntPtr pVirtualStorageListTail { get; }
        public uint nVirtualStorageRanges { get; }
        public ulong nVirtualStorageBytes { get; }
        public _RTL_AVL_TABLE BusyNodesTable { get; }
        public IntPtr NodeToAllocate { get; }
        public uint nBusyAllocations { get; }
        public ulong nBusyAllocationBytesCommitted { get; }
        public IntPtr pFreeAllocationListHead { get; }
        public IntPtr pFreeAllocationListTail { get; }
        public uint nFreeAllocations { get; }
        public ulong nFreeAllocationBytesCommitted { get; }
        public _LIST_ENTRY AvailableAllocationHead { get; }
        public uint nAvailableAllocations { get; }
        public ulong nAvailableAllocationBytesCommitted { get; }
        public IntPtr pUnusedNodeListHead { get; }
        public IntPtr pUnusedNodeListTail { get; }
        public uint nUnusedNodes { get; }
        public ulong nBusyAllocationBytesAccessible { get; }
        public IntPtr pNodePoolListHead { get; }
        public IntPtr pNodePoolListTail { get; }
        public uint nNodePools { get; }
        public ulong nNodePoolBytes { get; }
        public _LIST_ENTRY NextHeap { get; }
        public uint ExtraFlags { get; }
        public uint Seed { get; }
        public IntPtr NormalHeap { get; }
        public IntPtr CreateStackTrace { get; }
        public IntPtr FirstThread { get; }

        public _DPH_HEAP_ROOT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DPH_HEAP_ROOT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DPH_HEAP_ROOT.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.HeapFlags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.HeapCritSect),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nRemoteLockAcquired),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pVirtualStorageListHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pVirtualStorageListTail),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nVirtualStorageRanges),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nVirtualStorageBytes),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.BusyNodesTable),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.NodeToAllocate),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nBusyAllocations),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nBusyAllocationBytesCommitted),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pFreeAllocationListHead),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pFreeAllocationListTail),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nFreeAllocations),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nFreeAllocationBytesCommitted),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.AvailableAllocationHead),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nAvailableAllocations),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nAvailableAllocationBytesCommitted),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pUnusedNodeListHead),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pUnusedNodeListTail),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nUnusedNodes),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nBusyAllocationBytesAccessible),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pNodePoolListHead),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.pNodePoolListTail),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nNodePools),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.nNodePoolBytes),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.NextHeap),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.ExtraFlags),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.Seed),
                    new ulong[]
                    {
                        332UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.NormalHeap),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.CreateStackTrace),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_DPH_HEAP_ROOT.FirstThread),
                    new ulong[]
                    {
                        352UL
                    }
                }
            };
            Register<_DPH_HEAP_ROOT>((mem, ptr) => new _DPH_HEAP_ROOT(mem, ptr), offsets);
        }
    }
}