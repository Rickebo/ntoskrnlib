using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_NODE_HEADER")]
    public sealed class _WNF_NODE_HEADER : DynamicStructure
    {
        public ushort NodeTypeCode { get; }
        public ushort NodeByteSize { get; }

        public _WNF_NODE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_NODE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_NODE_HEADER.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_NODE_HEADER.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_WNF_NODE_HEADER>((mem, ptr) => new _WNF_NODE_HEADER(mem, ptr), offsets);
        }
    }
}