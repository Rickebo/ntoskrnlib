using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_STACK_CACHE")]
    public sealed class _ETW_STACK_CACHE : DynamicStructure
    {
        public _ETW_STACK_CACHE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_STACK_CACHE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ETW_STACK_CACHE>((mem, ptr) => new _ETW_STACK_CACHE(mem, ptr), offsets);
        }
    }
}