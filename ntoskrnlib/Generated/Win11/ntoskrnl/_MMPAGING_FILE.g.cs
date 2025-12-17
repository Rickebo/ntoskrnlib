#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _MMPAGING_FILE
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(4)]
        public uint MaximumSize;
        [FieldOffset(8)]
        public uint MinimumSize;
        [FieldOffset(12)]
        public uint FreeSpace;
        [FieldOffset(16)]
        public uint PeakUsage;
        [FieldOffset(20)]
        public uint FreeReservationSpace;
        [FieldOffset(24)]
        public IntPtr File;
        [FieldOffset(32)]
        public IntPtr Entry;
        [FieldOffset(40)]
        public uint NumberOfModWriterEntries;
        [FieldOffset(48)]
        public _SLIST_HEADER PfnsToFree;
        [FieldOffset(64)]
        public _UNICODE_STRING PageFileName;
        [FieldOffset(80)]
        public IntPtr Bitmaps;
        [FieldOffset(88)]
        public uint AllocationBitmapHint;
        [FieldOffset(92)]
        public uint LargestAllocationCluster;
        [FieldOffset(96)]
        public uint RefreshAllocationCluster;
        [FieldOffset(100)]
        public uint LastRefreshAllocationCluster;
        [FieldOffset(104)]
        public uint ReservedClusterSizeAggregate;
        [FieldOffset(104)]
        public uint ToBeEvictedHint;
        [FieldOffset(108)]
        public uint MaximumRunLengthInBitmaps;
        [FieldOffset(112)]
        public _RTL_RB_TREE BitmapsCacheLengthTree;
        [FieldOffset(128)]
        public _RTL_RB_TREE BitmapsCacheLocationTree;
        [FieldOffset(144)]
        public _LIST_ENTRY BitmapsCacheFreeList;
        [FieldOffset(160)]
        public IntPtr BitmapsCacheEntries;
        [FieldOffset(168)]
        public uint ToBeEvictedCount;
        [FieldOffset(168)]
        public uint HybridPriority;
        [FieldOffset(172)]
        public ushort PageFileNumber;
        [FieldOffset(172)]
        public ushort WsSwapPagefile;
        [FieldOffset(172)]
        public ushort NoReservations;
        [FieldOffset(172)]
        public ushort VirtualStorePagefile;
        [FieldOffset(172)]
        public ushort SwapSupported;
        [FieldOffset(172)]
        public ushort NodeInserted;
        [FieldOffset(172)]
        public ushort StackNotified;
        [FieldOffset(172)]
        public ushort BackedBySCM;
        [FieldOffset(172)]
        public ushort SpecialPurposeMemory;
        [FieldOffset(172)]
        public ushort Spare0;
        [FieldOffset(174)]
        public byte AdriftMdls;
        [FieldOffset(174)]
        public byte Spare1;
        [FieldOffset(175)]
        public byte IgnoreReservations;
        [FieldOffset(175)]
        public byte Spare2;
        [FieldOffset(176)]
        public uint PageHashPages;
        [FieldOffset(180)]
        public uint PageHashPagesPeak;
        [FieldOffset(184)]
        public IntPtr PageHash;
        [FieldOffset(192)]
        public IntPtr FileHandle;
        [FieldOffset(200)]
        public int SpinLock;
        [FieldOffset(208)]
        public _RTL_AVL_TREE FlowThroughReadRoot;
        [FieldOffset(216)]
        public IntPtr Partition;
        [FieldOffset(224)]
        public _RTL_BALANCED_NODE FileObjectNode;
        [FieldOffset(224)]
        public _RTL_RB_TREE ExtentsTree;
    }
}