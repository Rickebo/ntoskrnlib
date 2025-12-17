using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_BARRIER")]
    public sealed class _TPP_BARRIER : DynamicStructure
    {
        public _TPP_FLAGS_COUNT Ptr { get; }
        public _RTL_SRWLOCK WaitLock { get; }
        public _TPP_ITE WaitList { get; }

        public _TPP_BARRIER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_BARRIER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_BARRIER.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_BARRIER.WaitLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TPP_BARRIER.WaitList),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_TPP_BARRIER>((mem, ptr) => new _TPP_BARRIER(mem, ptr), offsets);
        }
    }
}