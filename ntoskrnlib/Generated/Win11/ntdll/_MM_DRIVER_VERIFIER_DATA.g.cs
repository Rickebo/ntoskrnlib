#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct _MM_DRIVER_VERIFIER_DATA
    {
        [FieldOffset(0)]
        public uint Level;
        [FieldOffset(4)]
        public uint RaiseIrqls;
        [FieldOffset(8)]
        public uint AcquireSpinLocks;
        [FieldOffset(12)]
        public uint SynchronizeExecutions;
        [FieldOffset(16)]
        public uint AllocationsAttempted;
        [FieldOffset(20)]
        public uint AllocationsSucceeded;
        [FieldOffset(24)]
        public uint AllocationsSucceededSpecialPool;
        [FieldOffset(28)]
        public uint AllocationsWithNoTag;
        [FieldOffset(32)]
        public uint TrimRequests;
        [FieldOffset(36)]
        public uint Trims;
        [FieldOffset(40)]
        public uint AllocationsFailed;
        [FieldOffset(44)]
        public uint AllocationsFailedDeliberately;
        [FieldOffset(48)]
        public uint AllocationFreed;
        [FieldOffset(52)]
        public uint Loads;
        [FieldOffset(56)]
        public uint Unloads;
        [FieldOffset(60)]
        public uint UnTrackedPool;
        [FieldOffset(64)]
        public uint UserTrims;
        [FieldOffset(68)]
        public uint CurrentPagedPoolAllocations;
        [FieldOffset(72)]
        public uint CurrentNonPagedPoolAllocations;
        [FieldOffset(76)]
        public uint PeakPagedPoolAllocations;
        [FieldOffset(80)]
        public uint PeakNonPagedPoolAllocations;
        [FieldOffset(88)]
        public ulong PagedBytes;
        [FieldOffset(96)]
        public ulong NonPagedBytes;
        [FieldOffset(104)]
        public ulong PeakPagedBytes;
        [FieldOffset(112)]
        public ulong PeakNonPagedBytes;
        [FieldOffset(120)]
        public uint BurstAllocationsFailedDeliberately;
        [FieldOffset(124)]
        public uint SessionTrims;
        [FieldOffset(128)]
        public uint OptionChanges;
        [FieldOffset(132)]
        public uint VerifyMode;
        [FieldOffset(136)]
        public _UNICODE_STRING PreviousBucketName;
    }
}