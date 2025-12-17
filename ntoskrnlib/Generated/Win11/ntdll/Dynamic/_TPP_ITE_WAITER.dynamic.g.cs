using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_ITE_WAITER")]
    public sealed class _TPP_ITE_WAITER : DynamicStructure
    {
        public IntPtr Next { get; }
        public IntPtr ThreadId { get; }

        public _TPP_ITE_WAITER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_ITE_WAITER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_ITE_WAITER.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_ITE_WAITER.ThreadId),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TPP_ITE_WAITER>((mem, ptr) => new _TPP_ITE_WAITER(mem, ptr), offsets);
        }
    }
}