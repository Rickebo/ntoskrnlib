using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_INDEX")]
    public sealed class _CM_INDEX : DynamicStructure
    {
        public uint Cell { get; }
        public _CM_FAST_LEAF_HINT NameHint { get; }
        public _CM_COMPONENT_HASH HashKey { get; }

        public _CM_INDEX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_INDEX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_INDEX.Cell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_INDEX.NameHint),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_INDEX.HashKey),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_INDEX>((mem, ptr) => new _CM_INDEX(mem, ptr), offsets);
        }
    }
}