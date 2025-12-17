using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_STD_LIST_ENTRY")]
    public sealed class _RTL_STD_LIST_ENTRY : DynamicStructure
    {
        public IntPtr Next { get; }

        public _RTL_STD_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_STD_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_STD_LIST_ENTRY.Next),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_STD_LIST_ENTRY>((mem, ptr) => new _RTL_STD_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}