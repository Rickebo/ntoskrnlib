using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_FAST_LEAF_HINT")]
    public sealed class _CM_FAST_LEAF_HINT : DynamicStructure
    {
        public byte[] Characters { get; }
        public uint FullHint { get; }

        public _CM_FAST_LEAF_HINT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_FAST_LEAF_HINT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_FAST_LEAF_HINT.Characters),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_FAST_LEAF_HINT.FullHint),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CM_FAST_LEAF_HINT>((mem, ptr) => new _CM_FAST_LEAF_HINT(mem, ptr), offsets);
        }
    }
}