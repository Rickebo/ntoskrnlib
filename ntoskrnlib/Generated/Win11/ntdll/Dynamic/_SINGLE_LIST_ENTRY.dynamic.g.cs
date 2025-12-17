using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SINGLE_LIST_ENTRY")]
    public sealed class _SINGLE_LIST_ENTRY : DynamicStructure
    {
        public IntPtr Next { get; }

        public _SINGLE_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SINGLE_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SINGLE_LIST_ENTRY.Next),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SINGLE_LIST_ENTRY>((mem, ptr) => new _SINGLE_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}