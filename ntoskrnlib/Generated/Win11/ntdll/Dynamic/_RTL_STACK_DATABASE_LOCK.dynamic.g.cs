using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_STACK_DATABASE_LOCK")]
    public sealed class _RTL_STACK_DATABASE_LOCK : DynamicStructure
    {
        public _RTL_SRWLOCK Lock { get; }

        public _RTL_STACK_DATABASE_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_STACK_DATABASE_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_STACK_DATABASE_LOCK.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_STACK_DATABASE_LOCK>((mem, ptr) => new _RTL_STACK_DATABASE_LOCK(mem, ptr), offsets);
        }
    }
}