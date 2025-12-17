using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_STD_LIST_HEAD")]
    public sealed class _RTL_STD_LIST_HEAD : DynamicStructure
    {
        public IntPtr Next { get; }
        public _RTL_STACK_DATABASE_LOCK Lock { get; }

        public _RTL_STD_LIST_HEAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_STD_LIST_HEAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_STD_LIST_HEAD.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_STD_LIST_HEAD.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_STD_LIST_HEAD>((mem, ptr) => new _RTL_STD_LIST_HEAD(mem, ptr), offsets);
        }
    }
}