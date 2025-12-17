using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WNF_SCOPE_MAP")]
    public sealed class _WNF_SCOPE_MAP : DynamicStructure
    {
        public _WNF_SCOPE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_SCOPE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_WNF_SCOPE_MAP>((mem, ptr) => new _WNF_SCOPE_MAP(mem, ptr), offsets);
        }
    }
}