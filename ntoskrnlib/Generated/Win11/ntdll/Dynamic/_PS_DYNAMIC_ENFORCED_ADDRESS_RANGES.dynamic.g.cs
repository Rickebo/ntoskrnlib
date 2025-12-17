using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_DYNAMIC_ENFORCED_ADDRESS_RANGES")]
    public sealed class _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES : DynamicStructure
    {
        public _RTL_AVL_TREE Tree { get; }
        public _EX_PUSH_LOCK Lock { get; }

        public _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_DYNAMIC_ENFORCED_ADDRESS_RANGES.Tree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_DYNAMIC_ENFORCED_ADDRESS_RANGES.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PS_DYNAMIC_ENFORCED_ADDRESS_RANGES>((mem, ptr) => new _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES(mem, ptr), offsets);
        }
    }
}