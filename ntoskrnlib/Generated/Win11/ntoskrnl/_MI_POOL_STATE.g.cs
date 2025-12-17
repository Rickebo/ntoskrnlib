#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 448)]
    public partial struct _MI_POOL_STATE
    {
        [FieldOffset(0)]
        public ulong MaximumNonPagedPoolThreshold;
        [FieldOffset(8)]
        public ulong AllocatedNonPagedPool;
        [FieldOffset(16)]
        public ulong AllocatedSecureNonPagedPool;
        [FieldOffset(24)]
        public uint HighEventSets;
        [FieldOffset(28)]
        public byte HighEventSetsValid;
        [FieldOffset(32)]
        public ulong LowPagedPoolThreshold;
        [FieldOffset(40)]
        public ulong HighPagedPoolThreshold;
        [FieldOffset(48)]
        public int PermittedFaultsLock;
        [FieldOffset(56)]
        public _RTL_AVL_TREE PermittedFaultsTree;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _MI_ACCESS_VIOLATION_RANGE[] PermittedFaultsInitialNode;
        [FieldOffset(144)]
        public ulong TotalPagedPoolQuota;
        [FieldOffset(152)]
        public ulong TotalNonPagedPoolQuota;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_CACHE_ALIGNED_ARRAY[] PagedPoolWorkingSetLockArray;
    }
}