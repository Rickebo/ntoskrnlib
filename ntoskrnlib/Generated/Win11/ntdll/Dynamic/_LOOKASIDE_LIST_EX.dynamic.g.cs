using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LOOKASIDE_LIST_EX")]
    public sealed class _LOOKASIDE_LIST_EX : DynamicStructure
    {
        public _GENERAL_LOOKASIDE_POOL L { get; }

        public _LOOKASIDE_LIST_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOOKASIDE_LIST_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOOKASIDE_LIST_EX.L),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_LOOKASIDE_LIST_EX>((mem, ptr) => new _LOOKASIDE_LIST_EX(mem, ptr), offsets);
        }
    }
}