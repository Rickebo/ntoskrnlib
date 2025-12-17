using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KNODE_SUBNODE_SEARCH_RANKS")]
    public sealed class KnodeSubnodeSearchRanks : DynamicStructure
    {
        [Offset(0UL)]
        [Length(32)]
        public DynamicArray Ranks { get => ReadStructure<DynamicArray>(nameof(Ranks)); set => WriteStructure(nameof(Ranks), value); }

        public KnodeSubnodeSearchRanks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KnodeSubnodeSearchRanks>();
        }
    }
}