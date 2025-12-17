using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PO_PROCESS_ENERGY_CONTEXT")]
    public sealed class _PO_PROCESS_ENERGY_CONTEXT : DynamicStructure
    {
        public _PO_PROCESS_ENERGY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_PROCESS_ENERGY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PO_PROCESS_ENERGY_CONTEXT>((mem, ptr) => new _PO_PROCESS_ENERGY_CONTEXT(mem, ptr), offsets);
        }
    }
}