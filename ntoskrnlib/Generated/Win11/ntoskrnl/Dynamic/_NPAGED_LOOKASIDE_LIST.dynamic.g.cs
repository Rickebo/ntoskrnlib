using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NPAGED_LOOKASIDE_LIST")]
    public sealed class _NPAGED_LOOKASIDE_LIST : DynamicStructure
    {
        public _GENERAL_LOOKASIDE L { get; }

        public _NPAGED_LOOKASIDE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NPAGED_LOOKASIDE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NPAGED_LOOKASIDE_LIST.L),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_NPAGED_LOOKASIDE_LIST>((mem, ptr) => new _NPAGED_LOOKASIDE_LIST(mem, ptr), offsets);
        }
    }
}