using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!__WIL__WNF_STATE_NAME")]
    public sealed class __WIL__WNF_STATE_NAME : DynamicStructure
    {
        public uint[] Data { get; }

        public __WIL__WNF_STATE_NAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static __WIL__WNF_STATE_NAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(__WIL__WNF_STATE_NAME.Data),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<__WIL__WNF_STATE_NAME>((mem, ptr) => new __WIL__WNF_STATE_NAME(mem, ptr), offsets);
        }
    }
}