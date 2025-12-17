#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 752)]
    public partial struct _STACK_TRACE_DATABASE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 104)]
        public sbyte[] Reserved;
        [FieldOffset(0)]
        public _RTL_STACK_DATABASE_LOCK Lock;
        [FieldOffset(104)]
        public IntPtr Reserved2;
        [FieldOffset(112)]
        public ulong PeakHashCollisionListLength;
        [FieldOffset(120)]
        public IntPtr LowerMemoryStart;
        [FieldOffset(128)]
        public byte PreCommitted;
        [FieldOffset(129)]
        public byte DumpInProgress;
        [FieldOffset(136)]
        public IntPtr CommitBase;
        [FieldOffset(144)]
        public IntPtr CurrentLowerCommitLimit;
        [FieldOffset(152)]
        public IntPtr CurrentUpperCommitLimit;
        [FieldOffset(160)]
        public IntPtr NextFreeLowerMemory;
        [FieldOffset(168)]
        public IntPtr NextFreeUpperMemory;
        [FieldOffset(176)]
        public uint NumberOfEntriesLookedUp;
        [FieldOffset(180)]
        public uint NumberOfEntriesAdded;
        [FieldOffset(184)]
        public IntPtr EntryIndexArray;
        [FieldOffset(192)]
        public uint NumberOfEntriesAllocated;
        [FieldOffset(196)]
        public uint NumberOfEntriesAvailable;
        [FieldOffset(200)]
        public uint NumberOfAllocationFailures;
        [FieldOffset(208)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _SLIST_HEADER[] FreeLists;
        [FieldOffset(720)]
        public uint NumberOfBuckets;
        [FieldOffset(728)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _RTL_STD_LIST_HEAD[] Buckets;
    }
}