using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TP_POOL")]
    public sealed class _TP_POOL : DynamicStructure
    {
        public _TP_POOL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_POOL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_TP_POOL>((mem, ptr) => new _TP_POOL(mem, ptr), offsets);
        }
    }
}