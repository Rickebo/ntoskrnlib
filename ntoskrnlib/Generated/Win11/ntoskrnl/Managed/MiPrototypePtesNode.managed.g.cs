using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PROTOTYPE_PTES_NODE")]
    public sealed class MiPrototypePtesNode : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        [Offset(24UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        public MiPrototypePtesNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPrototypePtesNode>();
        }
    }
}