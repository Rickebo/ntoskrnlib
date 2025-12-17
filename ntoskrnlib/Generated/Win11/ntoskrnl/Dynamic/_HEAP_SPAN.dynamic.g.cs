using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_SPAN")]
    public sealed class _HEAP_SPAN : DynamicStructure
    {
        public IntPtr Address { get; }
        public ulong Size { get; }

        public _HEAP_SPAN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_SPAN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_SPAN.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SPAN.Size),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_SPAN>((mem, ptr) => new _HEAP_SPAN(mem, ptr), offsets);
        }
    }
}