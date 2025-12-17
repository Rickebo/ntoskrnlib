using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SOFT_RESTART_CONTEXT")]
    public sealed class _ETW_SOFT_RESTART_CONTEXT : DynamicStructure
    {
        public _ETW_SOFT_RESTART_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SOFT_RESTART_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ETW_SOFT_RESTART_CONTEXT>((mem, ptr) => new _ETW_SOFT_RESTART_CONTEXT(mem, ptr), offsets);
        }
    }
}