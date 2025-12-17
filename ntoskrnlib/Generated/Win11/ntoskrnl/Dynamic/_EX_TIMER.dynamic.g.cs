using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_TIMER")]
    public sealed class _EX_TIMER : DynamicStructure
    {
        public _EX_TIMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_TIMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_EX_TIMER>((mem, ptr) => new _EX_TIMER(mem, ptr), offsets);
        }
    }
}