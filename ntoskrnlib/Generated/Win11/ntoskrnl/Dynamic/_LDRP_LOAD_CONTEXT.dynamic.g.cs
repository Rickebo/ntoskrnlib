using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LDRP_LOAD_CONTEXT")]
    public sealed class _LDRP_LOAD_CONTEXT : DynamicStructure
    {
        public _LDRP_LOAD_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LDRP_LOAD_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_LDRP_LOAD_CONTEXT>((mem, ptr) => new _LDRP_LOAD_CONTEXT(mem, ptr), offsets);
        }
    }
}