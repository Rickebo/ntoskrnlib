using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_QUEUE")]
    public sealed class _TPP_QUEUE : DynamicStructure
    {
        public _LIST_ENTRY Queue { get; }
        public _RTL_SRWLOCK Lock { get; }

        public _TPP_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_QUEUE.Queue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_QUEUE.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_TPP_QUEUE>((mem, ptr) => new _TPP_QUEUE(mem, ptr), offsets);
        }
    }
}