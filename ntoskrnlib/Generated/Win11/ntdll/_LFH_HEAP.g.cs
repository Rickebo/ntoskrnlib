#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 3312)]
    public partial struct _LFH_HEAP
    {
        [FieldOffset(0)]
        public _RTL_SRWLOCK Lock;
        [FieldOffset(8)]
        public _LIST_ENTRY SubSegmentZones;
        [FieldOffset(24)]
        public IntPtr Heap;
        [FieldOffset(32)]
        public IntPtr NextSegmentInfoArrayAddress;
        [FieldOffset(40)]
        public IntPtr FirstUncommittedAddress;
        [FieldOffset(48)]
        public IntPtr ReservedAddressLimit;
        [FieldOffset(56)]
        public uint SegmentCreate;
        [FieldOffset(60)]
        public uint SegmentDelete;
        [FieldOffset(64)]
        public uint MinimumCacheDepth;
        [FieldOffset(68)]
        public uint CacheShiftThreshold;
        [FieldOffset(72)]
        public ulong SizeInCache;
        [FieldOffset(80)]
        public _HEAP_BUCKET_RUN_INFO RunInfo;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public _USER_MEMORY_CACHE_ENTRY[] UserBlockCache;
        [FieldOffset(672)]
        public _HEAP_LFH_MEM_POLICIES MemoryPolicies;
        [FieldOffset(676)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
        public _HEAP_BUCKET[] Buckets;
        [FieldOffset(1192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
        public IntPtr[] SegmentInfoArrays;
        [FieldOffset(2224)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
        public IntPtr[] AffinitizedInfoArrays;
        [FieldOffset(3256)]
        public IntPtr SegmentAllocator;
        [FieldOffset(3264)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _HEAP_LOCAL_DATA[] LocalData;
    }
}