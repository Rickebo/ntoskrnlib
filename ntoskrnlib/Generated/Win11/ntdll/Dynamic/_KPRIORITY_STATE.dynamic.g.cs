using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPRIORITY_STATE")]
    public sealed class _KPRIORITY_STATE : DynamicStructure
    {
        public _KPRIORITY_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRIORITY_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KPRIORITY_STATE>((mem, ptr) => new _KPRIORITY_STATE(mem, ptr), offsets);
        }
    }
}