using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMINPAGE_SUPPORT_FLOW_THROUGH")]
    public sealed class MminpageSupportFlowThrough : DynamicStructure
    {
        [Offset(0UL)]
        [Length(1)]
        public DynamicArray Page { get => ReadStructure<DynamicArray>(nameof(Page)); set => WriteStructure(nameof(Page), value); }

        [Offset(8UL)]
        public IntPtr InitialInPageSupport { get => ReadHere<IntPtr>(nameof(InitialInPageSupport)); set => WriteHere(nameof(InitialInPageSupport), value); }

        [Offset(16UL)]
        public IntPtr PagingFile { get => ReadHere<IntPtr>(nameof(PagingFile)); set => WriteHere(nameof(PagingFile), value); }

        [Offset(24UL)]
        public uint PageFileOffset { get => ReadHere<uint>(nameof(PageFileOffset)); set => WriteHere(nameof(PageFileOffset), value); }

        [Offset(32UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        public MminpageSupportFlowThrough(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MminpageSupportFlowThrough>();
        }
    }
}