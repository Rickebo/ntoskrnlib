using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_STATE")]
    public sealed class MiPartitionState : DynamicStructure
    {
        [Offset(0UL)]
        public int PartitionLock { get => ReadHere<int>(nameof(PartitionLock)); set => WriteHere(nameof(PartitionLock), value); }

        [Offset(8UL)]
        public ExPushLock PartitionIdLock { get => ReadStructure<ExPushLock>(nameof(PartitionIdLock)); set => WriteStructure(nameof(PartitionIdLock), value); }

        [Offset(16UL)]
        public ulong InitialPartitionIdBits { get => ReadHere<ulong>(nameof(InitialPartitionIdBits)); set => WriteHere(nameof(InitialPartitionIdBits), value); }

        [Offset(24UL)]
        public ListEntry PartitionList { get => ReadStructure<ListEntry>(nameof(PartitionList)); set => WriteStructure(nameof(PartitionList), value); }

        [Offset(40UL)]
        public IntPtr PartitionIdBitmap { get => ReadHere<IntPtr>(nameof(PartitionIdBitmap)); set => WriteHere(nameof(PartitionIdBitmap), value); }

        [Offset(48UL)]
        public RtlBitmap InitialPartitionIdBitmap { get => ReadStructure<RtlBitmap>(nameof(InitialPartitionIdBitmap)); set => WriteStructure(nameof(InitialPartitionIdBitmap), value); }

        [Offset(64UL)]
        [Length(1)]
        public DynamicArray TempPartitionPointers { get => ReadStructure<DynamicArray>(nameof(TempPartitionPointers)); set => WriteStructure(nameof(TempPartitionPointers), value); }

        [Offset(72UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(80UL)]
        public uint CrossPartitionDenials { get => ReadHere<uint>(nameof(CrossPartitionDenials)); set => WriteHere(nameof(CrossPartitionDenials), value); }

        [Offset(84UL)]
        public byte MultiplePartitionsExist { get => ReadHere<byte>(nameof(MultiplePartitionsExist)); set => WriteHere(nameof(MultiplePartitionsExist), value); }

        [Offset(88UL)]
        public IntPtr ExtendedPartitionStart { get => ReadHere<IntPtr>(nameof(ExtendedPartitionStart)); set => WriteHere(nameof(ExtendedPartitionStart), value); }

        [Offset(96UL)]
        public ulong ExtendedPartitionBytes { get => ReadHere<ulong>(nameof(ExtendedPartitionBytes)); set => WriteHere(nameof(ExtendedPartitionBytes), value); }

        [Offset(104UL)]
        public ulong ChildPartitionBytes { get => ReadHere<ulong>(nameof(ChildPartitionBytes)); set => WriteHere(nameof(ChildPartitionBytes), value); }

        [Offset(112UL)]
        public RtlBitmapEx HugeIoPfnBitMap { get => ReadStructure<RtlBitmapEx>(nameof(HugeIoPfnBitMap)); set => WriteStructure(nameof(HugeIoPfnBitMap), value); }

        [Offset(128UL)]
        public IntPtr HugePfnDatabase { get => ReadHere<IntPtr>(nameof(HugePfnDatabase)); set => WriteHere(nameof(HugePfnDatabase), value); }

        [Offset(136UL)]
        public IntPtr HugePfnLockArray { get => ReadHere<IntPtr>(nameof(HugePfnLockArray)); set => WriteHere(nameof(HugePfnLockArray), value); }

        [Offset(192UL)]
        public int HugeRangesLock { get => ReadHere<int>(nameof(HugeRangesLock)); set => WriteHere(nameof(HugeRangesLock), value); }

        public MiPartitionState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionState>();
        }
    }
}