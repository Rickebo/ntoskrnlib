using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_CHPEV2_CPUAREA_INFO")]
    public sealed class _CHPEV2_CPUAREA_INFO : DynamicStructure
    {
        public _CHPEV2_CPUAREA_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CHPEV2_CPUAREA_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_CHPEV2_CPUAREA_INFO>((mem, ptr) => new _CHPEV2_CPUAREA_INFO(mem, ptr), offsets);
        }
    }
}