using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPROCESS_AVAILABLE_CPU_STATE")]
    public sealed class _KPROCESS_AVAILABLE_CPU_STATE : DynamicStructure
    {
        public _KPROCESS_AVAILABLE_CPU_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPROCESS_AVAILABLE_CPU_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KPROCESS_AVAILABLE_CPU_STATE>((mem, ptr) => new _KPROCESS_AVAILABLE_CPU_STATE(mem, ptr), offsets);
        }
    }
}