using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!__WIL__WNF_TYPE_ID")]
    public sealed class __WIL__WNF_TYPE_ID : DynamicStructure
    {
        public _GUID TypeId { get; }

        public __WIL__WNF_TYPE_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static __WIL__WNF_TYPE_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(__WIL__WNF_TYPE_ID.TypeId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<__WIL__WNF_TYPE_ID>((mem, ptr) => new __WIL__WNF_TYPE_ID(mem, ptr), offsets);
        }
    }
}