using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SLIST_ENTRY")]
    public sealed class _SLIST_ENTRY : DynamicStructure
    {
        public IntPtr Next { get; }

        public _SLIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SLIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SLIST_ENTRY.Next),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SLIST_ENTRY>((mem, ptr) => new _SLIST_ENTRY(mem, ptr), offsets);
        }
    }
}