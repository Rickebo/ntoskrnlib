using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_BUCKET")]
    public sealed class HeapLfhBucket : DynamicStructure
    {
        [Offset(0UL)]
        public HeapLfhSubsegmentOwner State { get => ReadStructure<HeapLfhSubsegmentOwner>(nameof(State)); set => WriteStructure(nameof(State), value); }

        [Offset(56UL)]
        public ulong TotalBlockCount { get => ReadHere<ulong>(nameof(TotalBlockCount)); set => WriteHere(nameof(TotalBlockCount), value); }

        [Offset(64UL)]
        public ulong TotalSubsegmentCount { get => ReadHere<ulong>(nameof(TotalSubsegmentCount)); set => WriteHere(nameof(TotalSubsegmentCount), value); }

        [Offset(72UL)]
        public uint ReciprocalBlockSize { get => ReadHere<uint>(nameof(ReciprocalBlockSize)); set => WriteHere(nameof(ReciprocalBlockSize), value); }

        [Offset(76UL)]
        public ushort HotHeatThreshold { get => ReadHere<ushort>(nameof(HotHeatThreshold)); set => WriteHere(nameof(HotHeatThreshold), value); }

        [Offset(78UL)]
        public ushort PrivateHeatThreshold { get => ReadHere<ushort>(nameof(PrivateHeatThreshold)); set => WriteHere(nameof(PrivateHeatThreshold), value); }

        [Offset(80UL)]
        public ulong PrivSlotListLock { get => ReadHere<ulong>(nameof(PrivSlotListLock)); set => WriteHere(nameof(PrivSlotListLock), value); }

        [Offset(88UL)]
        public HeapLfhPtrrefList PrivSlotList { get => ReadStructure<HeapLfhPtrrefList>(nameof(PrivSlotList)); set => WriteStructure(nameof(PrivSlotList), value); }

        [Offset(92UL)]
        public byte CompactionNeeded { get => ReadHere<byte>(nameof(CompactionNeeded)); set => WriteHere(nameof(CompactionNeeded), value); }

        [Offset(93UL)]
        [Length(7)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        [Offset(104UL)]
        public HeapAffinityMgr AffinityMgr { get => ReadStructure<HeapAffinityMgr>(nameof(AffinityMgr)); set => WriteStructure(nameof(AffinityMgr), value); }

        public HeapLfhBucket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhBucket>();
        }
    }
}