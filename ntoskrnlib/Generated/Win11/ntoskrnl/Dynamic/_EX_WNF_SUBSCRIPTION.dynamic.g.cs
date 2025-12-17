using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_WNF_SUBSCRIPTION")]
    public sealed class _EX_WNF_SUBSCRIPTION : DynamicStructure
    {
        public _EX_WNF_SUBSCRIPTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_WNF_SUBSCRIPTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_EX_WNF_SUBSCRIPTION>((mem, ptr) => new _EX_WNF_SUBSCRIPTION(mem, ptr), offsets);
        }
    }
}