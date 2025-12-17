using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LARGE_ALLOC_DATA")]
    public sealed class HeapLargeAllocData : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode TreeNode { get => ReadStructure<RtlBalancedNode>(nameof(TreeNode)); set => WriteStructure(nameof(TreeNode), value); }

        [Offset(24UL)]
        public ulong VirtualAddress { get => ReadHere<ulong>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(24UL)]
        public ulong UnusedBytes { get => ReadHere<ulong>(nameof(UnusedBytes)); set => WriteHere(nameof(UnusedBytes), value); }

        [Offset(32UL)]
        public ulong ExtraPresent { get => ReadHere<ulong>(nameof(ExtraPresent)); set => WriteHere(nameof(ExtraPresent), value); }

        [Offset(32UL)]
        public ulong GuardPageCount { get => ReadHere<ulong>(nameof(GuardPageCount)); set => WriteHere(nameof(GuardPageCount), value); }

        [Offset(32UL)]
        public ulong GuardPageAlignment { get => ReadHere<ulong>(nameof(GuardPageAlignment)); set => WriteHere(nameof(GuardPageAlignment), value); }

        [Offset(32UL)]
        public ulong Spare { get => ReadHere<ulong>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(32UL)]
        public ulong AllocatedPages { get => ReadHere<ulong>(nameof(AllocatedPages)); set => WriteHere(nameof(AllocatedPages), value); }

        public HeapLargeAllocData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLargeAllocData>();
        }
    }
}