#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 480)]
    public partial struct _MI_PARTITION_CORE
    {
        [FieldOffset(0)]
        public ushort PartitionId;
        [FieldOffset(4)]
        public _MI_PARTITION_FLAGS Flags;
        [FieldOffset(8)]
        public uint Signature;
        [FieldOffset(12)]
        public byte MemoryConfigurationChanged;
        [FieldOffset(16)]
        public IntPtr NodeInformation;
        [FieldOffset(24)]
        public _RTL_AVL_TREE PageRoot;
        [FieldOffset(32)]
        public IntPtr MemoryNodeRuns;
        [FieldOffset(40)]
        public _WORK_QUEUE_ITEM PfnUnmapWorkItem;
        [FieldOffset(72)]
        public ulong PfnUnmapCount;
        [FieldOffset(80)]
        public IntPtr MemoryRuns;
        [FieldOffset(88)]
        public _KEVENT ExitEvent;
        [FieldOffset(112)]
        public _KEVENT ConductorNeededEvent;
        [FieldOffset(136)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public IntPtr[] SystemThreadHandles;
        [FieldOffset(184)]
        public IntPtr PartitionObject;
        [FieldOffset(192)]
        public _EX_PUSH_LOCK DynamicMemoryPushLock;
        [FieldOffset(200)]
        public int DynamicMemoryLock;
        [FieldOffset(204)]
        public byte PfnUnmapActive;
        [FieldOffset(208)]
        public _KEVENT TemporaryMemoryEvent;
        [FieldOffset(232)]
        public IntPtr RootDirectory;
        [FieldOffset(240)]
        public IntPtr KernelObjectsDirectory;
        [FieldOffset(248)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public IntPtr[] MemoryEvents;
        [FieldOffset(336)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public IntPtr[] MemoryEventHandles;
        [FieldOffset(424)]
        public ulong TotalHugeIoRanges;
        [FieldOffset(432)]
        public ulong NonChargedSecurePages;
        [FieldOffset(448)]
        public _SLIST_HEADER FreeKernelShadowStackCacheEntries;
        [FieldOffset(464)]
        public ulong KernelShadowStackPages;
    }
}