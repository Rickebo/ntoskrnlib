using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KI_COOPERATIVE_IDLE_SEARCH_GENERATION")]
    public sealed class _KI_COOPERATIVE_IDLE_SEARCH_GENERATION : DynamicStructure
    {
        public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_COOPERATIVE_IDLE_SEARCH_GENERATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KI_COOPERATIVE_IDLE_SEARCH_GENERATION>((mem, ptr) => new _KI_COOPERATIVE_IDLE_SEARCH_GENERATION(mem, ptr), offsets);
        }
    }
}