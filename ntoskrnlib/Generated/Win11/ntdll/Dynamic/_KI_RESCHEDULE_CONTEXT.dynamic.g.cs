using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KI_RESCHEDULE_CONTEXT")]
    public sealed class _KI_RESCHEDULE_CONTEXT : DynamicStructure
    {
        public _KI_RESCHEDULE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_RESCHEDULE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KI_RESCHEDULE_CONTEXT>((mem, ptr) => new _KI_RESCHEDULE_CONTEXT(mem, ptr), offsets);
        }
    }
}