using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MEMORY_ALLOCATION_DESCRIPTOR")]
    public sealed class MemoryAllocationDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(0UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        [Offset(24UL)]
        public uint MemoryType { get => ReadHere<uint>(nameof(MemoryType)); set => WriteHere(nameof(MemoryType), value); }

        [Offset(32UL)]
        public ulong BasePage { get => ReadHere<ulong>(nameof(BasePage)); set => WriteHere(nameof(BasePage), value); }

        [Offset(40UL)]
        public ulong PageCount { get => ReadHere<ulong>(nameof(PageCount)); set => WriteHere(nameof(PageCount), value); }

        public MemoryAllocationDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MemoryAllocationDescriptor>();
        }
    }
}