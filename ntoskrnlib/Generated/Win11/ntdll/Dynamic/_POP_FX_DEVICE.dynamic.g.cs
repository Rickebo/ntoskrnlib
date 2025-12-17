using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_POP_FX_DEVICE")]
    public sealed class _POP_FX_DEVICE : DynamicStructure
    {
        public _POP_FX_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_POP_FX_DEVICE>((mem, ptr) => new _POP_FX_DEVICE(mem, ptr), offsets);
        }
    }
}