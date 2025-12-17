using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOP_MC_BE_PAGE_NODE")]
    public sealed class IopMcBePageNode : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        [Offset(24UL)]
        public uint PageIndex { get => ReadHere<uint>(nameof(PageIndex)); set => WriteHere(nameof(PageIndex), value); }

        public IopMcBePageNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IopMcBePageNode>();
        }
    }
}