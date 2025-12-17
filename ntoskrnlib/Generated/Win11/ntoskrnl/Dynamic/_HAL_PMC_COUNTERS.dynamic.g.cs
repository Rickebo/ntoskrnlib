using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_PMC_COUNTERS")]
    public sealed class _HAL_PMC_COUNTERS : DynamicStructure
    {
        public _HAL_PMC_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_PMC_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_HAL_PMC_COUNTERS>((mem, ptr) => new _HAL_PMC_COUNTERS(mem, ptr), offsets);
        }
    }
}