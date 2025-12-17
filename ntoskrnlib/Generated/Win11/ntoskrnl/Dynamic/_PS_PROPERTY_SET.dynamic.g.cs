using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_PROPERTY_SET")]
    public sealed class _PS_PROPERTY_SET : DynamicStructure
    {
        public _LIST_ENTRY ListHead { get; }
        public ulong Lock { get; }

        public _PS_PROPERTY_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_PROPERTY_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_PROPERTY_SET.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_PROPERTY_SET.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PS_PROPERTY_SET>((mem, ptr) => new _PS_PROPERTY_SET(mem, ptr), offsets);
        }
    }
}