using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_VS_DELAY_FREE_CONTEXT")]
    public sealed class _HEAP_VS_DELAY_FREE_CONTEXT : DynamicStructure
    {
        public _SLIST_HEADER ListHead { get; }

        public _HEAP_VS_DELAY_FREE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_DELAY_FREE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_DELAY_FREE_CONTEXT.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_VS_DELAY_FREE_CONTEXT>((mem, ptr) => new _HEAP_VS_DELAY_FREE_CONTEXT(mem, ptr), offsets);
        }
    }
}