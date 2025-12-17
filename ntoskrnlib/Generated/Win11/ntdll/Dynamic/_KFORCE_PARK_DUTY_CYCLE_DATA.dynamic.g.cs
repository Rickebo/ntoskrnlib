using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KFORCE_PARK_DUTY_CYCLE_DATA")]
    public sealed class _KFORCE_PARK_DUTY_CYCLE_DATA : DynamicStructure
    {
        public _KFORCE_PARK_DUTY_CYCLE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KFORCE_PARK_DUTY_CYCLE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KFORCE_PARK_DUTY_CYCLE_DATA>((mem, ptr) => new _KFORCE_PARK_DUTY_CYCLE_DATA(mem, ptr), offsets);
        }
    }
}