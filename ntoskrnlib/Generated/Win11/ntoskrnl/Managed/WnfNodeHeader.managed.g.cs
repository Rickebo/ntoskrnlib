using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_NODE_HEADER")]
    public sealed class WnfNodeHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort NodeTypeCode { get => ReadHere<ushort>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public ushort NodeByteSize { get => ReadHere<ushort>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        public WnfNodeHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfNodeHeader>();
        }
    }
}