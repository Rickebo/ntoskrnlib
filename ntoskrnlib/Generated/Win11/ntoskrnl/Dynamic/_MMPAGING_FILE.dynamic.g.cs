using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPAGING_FILE")]
    public sealed class _MMPAGING_FILE : DynamicStructure
    {
        public uint Size { get; }
        public uint MaximumSize { get; }
        public uint MinimumSize { get; }
        public uint FreeSpace { get; }
        public uint PeakUsage { get; }
        public uint FreeReservationSpace { get; }
        public IntPtr File { get; }
        public IntPtr Entry { get; }
        public uint NumberOfModWriterEntries { get; }
        public _SLIST_HEADER PfnsToFree { get; }
        public _UNICODE_STRING PageFileName { get; }
        public IntPtr Bitmaps { get; }
        public uint AllocationBitmapHint { get; }
        public uint LargestAllocationCluster { get; }
        public uint RefreshAllocationCluster { get; }
        public uint LastRefreshAllocationCluster { get; }
        public uint ReservedClusterSizeAggregate { get; }
        public uint ToBeEvictedHint { get; }
        public uint MaximumRunLengthInBitmaps { get; }
        public _RTL_RB_TREE BitmapsCacheLengthTree { get; }
        public _RTL_RB_TREE BitmapsCacheLocationTree { get; }
        public _LIST_ENTRY BitmapsCacheFreeList { get; }
        public IntPtr BitmapsCacheEntries { get; }
        public uint ToBeEvictedCount { get; }
        public uint HybridPriority { get; }
        public ushort PageFileNumber { get; }
        public ushort WsSwapPagefile { get; }
        public ushort NoReservations { get; }
        public ushort VirtualStorePagefile { get; }
        public ushort SwapSupported { get; }
        public ushort NodeInserted { get; }
        public ushort StackNotified { get; }
        public ushort BackedBySCM { get; }
        public ushort SpecialPurposeMemory { get; }
        public ushort Spare0 { get; }
        public byte AdriftMdls { get; }
        public byte Spare1 { get; }
        public byte IgnoreReservations { get; }
        public byte Spare2 { get; }
        public uint PageHashPages { get; }
        public uint PageHashPagesPeak { get; }
        public IntPtr PageHash { get; }
        public IntPtr FileHandle { get; }
        public int SpinLock { get; }
        public _RTL_AVL_TREE FlowThroughReadRoot { get; }
        public IntPtr Partition { get; }
        public _RTL_BALANCED_NODE FileObjectNode { get; }
        public _RTL_RB_TREE ExtentsTree { get; }

        public _MMPAGING_FILE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPAGING_FILE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPAGING_FILE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.MaximumSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.MinimumSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.FreeSpace),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PeakUsage),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.FreeReservationSpace),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.File),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.Entry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.NumberOfModWriterEntries),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PfnsToFree),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PageFileName),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.Bitmaps),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.AllocationBitmapHint),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.LargestAllocationCluster),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.RefreshAllocationCluster),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.LastRefreshAllocationCluster),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.ReservedClusterSizeAggregate),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.ToBeEvictedHint),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.MaximumRunLengthInBitmaps),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.BitmapsCacheLengthTree),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.BitmapsCacheLocationTree),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.BitmapsCacheFreeList),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.BitmapsCacheEntries),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.ToBeEvictedCount),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.HybridPriority),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PageFileNumber),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.WsSwapPagefile),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.NoReservations),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.VirtualStorePagefile),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.SwapSupported),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.NodeInserted),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.StackNotified),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.BackedBySCM),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.SpecialPurposeMemory),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.Spare0),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.AdriftMdls),
                    new ulong[]
                    {
                        174UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.Spare1),
                    new ulong[]
                    {
                        174UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.IgnoreReservations),
                    new ulong[]
                    {
                        175UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.Spare2),
                    new ulong[]
                    {
                        175UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PageHashPages),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PageHashPagesPeak),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.PageHash),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.FileHandle),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.SpinLock),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.FlowThroughReadRoot),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.Partition),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.FileObjectNode),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_MMPAGING_FILE.ExtentsTree),
                    new ulong[]
                    {
                        224UL
                    }
                }
            };
            Register<_MMPAGING_FILE>((mem, ptr) => new _MMPAGING_FILE(mem, ptr), offsets);
        }
    }
}