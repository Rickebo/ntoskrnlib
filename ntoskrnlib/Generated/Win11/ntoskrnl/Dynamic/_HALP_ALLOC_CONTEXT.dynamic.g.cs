using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_ALLOC_CONTEXT")]
    public sealed class _HALP_ALLOC_CONTEXT : DynamicStructure
    {
        public _LIST_ENTRY BufferList { get; }
        public ulong Lock { get; }

        public _HALP_ALLOC_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_ALLOC_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_ALLOC_CONTEXT.BufferList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_ALLOC_CONTEXT.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HALP_ALLOC_CONTEXT>((mem, ptr) => new _HALP_ALLOC_CONTEXT(mem, ptr), offsets);
        }
    }
}