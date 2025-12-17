#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 528)]
    public partial struct _MI_PARTITION_STORES
    {
        [FieldOffset(0)]
        public _unnamed_tag_ WriteAllStoreSwapPages;
        [FieldOffset(4)]
        public uint VirtualPageFileNumber;
        [FieldOffset(8)]
        public uint ReadClusterSizeMax;
        [FieldOffset(12)]
        public uint MaximumPagefileSize;
        [FieldOffset(16)]
        public uint EvictFlushRequestCount;
        [FieldOffset(20)]
        public uint ModifiedWriteDisableCount;
        [FieldOffset(24)]
        public uint WriteIssueFailures;
        [FieldOffset(28)]
        public uint WritesOutstanding;
        [FieldOffset(32)]
        public uint VirtualPagefileMaximumIncreaseFailed;
        [FieldOffset(40)]
        public _KTIMER VirtualPagefileIncreaseRetryTimer;
        [FieldOffset(104)]
        public IntPtr RundownWrites;
        [FieldOffset(112)]
        public int EvictFlushLock;
        [FieldOffset(120)]
        public IntPtr EvictionThread;
        [FieldOffset(128)]
        public _KEVENT EvictEvent;
        [FieldOffset(152)]
        public _KEVENT EvictThreadExitEvent;
        [FieldOffset(176)]
        public _SLIST_HEADER WriteSupportSListHead;
        [FieldOffset(192)]
        public _KEVENT EvictFlushCompleteEvent;
        [FieldOffset(216)]
        public IntPtr WriteIssueFailedBitmap;
        [FieldOffset(224)]
        public IntPtr WritePageInformation;
        [FieldOffset(232)]
        public _KAFFINITY_EX AffinityEx;
        [FieldOffset(496)]
        public IntPtr StoreProcess;
        [FieldOffset(504)]
        public int MemoryConditionsLock;
        [FieldOffset(508)]
        public uint DeleteStoredPages;
        [FieldOffset(508)]
        public uint DiscardPoisonedPages;
        [FieldOffset(508)]
        public uint Spare;
        [FieldOffset(512)]
        public uint DiscardedPoisonedPages;
        [FieldOffset(520)]
        public ulong LastDiscardedPage;
    }
}