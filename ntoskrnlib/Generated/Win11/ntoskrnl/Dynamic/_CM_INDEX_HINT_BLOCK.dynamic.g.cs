using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_INDEX_HINT_BLOCK")]
    public sealed class _CM_INDEX_HINT_BLOCK : DynamicStructure
    {
        public uint Count { get; }
        public uint[] HashKey { get; }

        public _CM_INDEX_HINT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_INDEX_HINT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_INDEX_HINT_BLOCK.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_INDEX_HINT_BLOCK.HashKey),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_INDEX_HINT_BLOCK>((mem, ptr) => new _CM_INDEX_HINT_BLOCK(mem, ptr), offsets);
        }
    }
}