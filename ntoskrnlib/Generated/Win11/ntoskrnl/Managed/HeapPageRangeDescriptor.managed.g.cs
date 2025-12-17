using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_PAGE_RANGE_DESCRIPTOR")]
    public sealed class HeapPageRangeDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode TreeNode { get => ReadStructure<RtlBalancedNode>(nameof(TreeNode)); set => WriteStructure(nameof(TreeNode), value); }

        [Offset(0UL)]
        public uint TreeSignature { get => ReadHere<uint>(nameof(TreeSignature)); set => WriteHere(nameof(TreeSignature), value); }

        [Offset(4UL)]
        public uint UnusedBytes { get => ReadHere<uint>(nameof(UnusedBytes)); set => WriteHere(nameof(UnusedBytes), value); }

        [Offset(8UL)]
        public ushort ExtraPresent { get => ReadHere<ushort>(nameof(ExtraPresent)); set => WriteHere(nameof(ExtraPresent), value); }

        [Offset(8UL)]
        public ushort Spare0 { get => ReadHere<ushort>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(24UL)]
        public byte RangeFlags { get => ReadHere<byte>(nameof(RangeFlags)); set => WriteHere(nameof(RangeFlags), value); }

        [Offset(25UL)]
        public byte CommittedPageCount { get => ReadHere<byte>(nameof(CommittedPageCount)); set => WriteHere(nameof(CommittedPageCount), value); }

        [Offset(26UL)]
        public byte UnitOffset { get => ReadHere<byte>(nameof(UnitOffset)); set => WriteHere(nameof(UnitOffset), value); }

        [Offset(27UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(28UL)]
        public HeapDescriptorKey Key { get => ReadStructure<HeapDescriptorKey>(nameof(Key)); set => WriteStructure(nameof(Key), value); }

        [Offset(28UL)]
        [Length(3)]
        public DynamicArray Align { get => ReadStructure<DynamicArray>(nameof(Align)); set => WriteStructure(nameof(Align), value); }

        [Offset(31UL)]
        public byte UnitSize { get => ReadHere<byte>(nameof(UnitSize)); set => WriteHere(nameof(UnitSize), value); }

        public HeapPageRangeDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapPageRangeDescriptor>();
        }
    }
}