using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LOCK")]
    public sealed class _HEAP_LOCK : DynamicStructure
    {
        public _unnamed_tag_ Lock { get; }

        public _HEAP_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LOCK.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LOCK>((mem, ptr) => new _HEAP_LOCK(mem, ptr), offsets);
        }
    }
}