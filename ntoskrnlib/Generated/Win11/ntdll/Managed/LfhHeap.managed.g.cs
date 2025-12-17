using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LFH_HEAP")]
    public sealed class LfhHeap : DynamicStructure
    {
        [Offset(0UL)]
        public RtlSrwlock Lock { get => ReadStructure<RtlSrwlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public ListEntry SubSegmentZones { get => ReadStructure<ListEntry>(nameof(SubSegmentZones)); set => WriteStructure(nameof(SubSegmentZones), value); }

        [Offset(24UL)]
        public IntPtr Heap { get => ReadHere<IntPtr>(nameof(Heap)); set => WriteHere(nameof(Heap), value); }

        [Offset(32UL)]
        public IntPtr NextSegmentInfoArrayAddress { get => ReadHere<IntPtr>(nameof(NextSegmentInfoArrayAddress)); set => WriteHere(nameof(NextSegmentInfoArrayAddress), value); }

        [Offset(40UL)]
        public IntPtr FirstUncommittedAddress { get => ReadHere<IntPtr>(nameof(FirstUncommittedAddress)); set => WriteHere(nameof(FirstUncommittedAddress), value); }

        [Offset(48UL)]
        public IntPtr ReservedAddressLimit { get => ReadHere<IntPtr>(nameof(ReservedAddressLimit)); set => WriteHere(nameof(ReservedAddressLimit), value); }

        [Offset(56UL)]
        public uint SegmentCreate { get => ReadHere<uint>(nameof(SegmentCreate)); set => WriteHere(nameof(SegmentCreate), value); }

        [Offset(60UL)]
        public uint SegmentDelete { get => ReadHere<uint>(nameof(SegmentDelete)); set => WriteHere(nameof(SegmentDelete), value); }

        [Offset(64UL)]
        public uint MinimumCacheDepth { get => ReadHere<uint>(nameof(MinimumCacheDepth)); set => WriteHere(nameof(MinimumCacheDepth), value); }

        [Offset(68UL)]
        public uint CacheShiftThreshold { get => ReadHere<uint>(nameof(CacheShiftThreshold)); set => WriteHere(nameof(CacheShiftThreshold), value); }

        [Offset(72UL)]
        public ulong SizeInCache { get => ReadHere<ulong>(nameof(SizeInCache)); set => WriteHere(nameof(SizeInCache), value); }

        [Offset(80UL)]
        public HeapBucketRunInfo RunInfo { get => ReadStructure<HeapBucketRunInfo>(nameof(RunInfo)); set => WriteStructure(nameof(RunInfo), value); }

        [Offset(96UL)]
        [Length(12)]
        public DynamicArray UserBlockCache { get => ReadStructure<DynamicArray>(nameof(UserBlockCache)); set => WriteStructure(nameof(UserBlockCache), value); }

        [Offset(672UL)]
        public HeapLfhMemPolicies MemoryPolicies { get => ReadStructure<HeapLfhMemPolicies>(nameof(MemoryPolicies)); set => WriteStructure(nameof(MemoryPolicies), value); }

        [Offset(676UL)]
        [Length(129)]
        public DynamicArray Buckets { get => ReadStructure<DynamicArray>(nameof(Buckets)); set => WriteStructure(nameof(Buckets), value); }

        [Offset(1192UL)]
        [Length(129)]
        public DynamicArray SegmentInfoArrays { get => ReadStructure<DynamicArray>(nameof(SegmentInfoArrays)); set => WriteStructure(nameof(SegmentInfoArrays), value); }

        [Offset(2224UL)]
        [Length(129)]
        public DynamicArray AffinitizedInfoArrays { get => ReadStructure<DynamicArray>(nameof(AffinitizedInfoArrays)); set => WriteStructure(nameof(AffinitizedInfoArrays), value); }

        [Offset(3256UL)]
        public IntPtr SegmentAllocator { get => ReadHere<IntPtr>(nameof(SegmentAllocator)); set => WriteHere(nameof(SegmentAllocator), value); }

        [Offset(3264UL)]
        [Length(1)]
        public DynamicArray LocalData { get => ReadStructure<DynamicArray>(nameof(LocalData)); set => WriteStructure(nameof(LocalData), value); }

        public LfhHeap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LfhHeap>();
        }
    }
}