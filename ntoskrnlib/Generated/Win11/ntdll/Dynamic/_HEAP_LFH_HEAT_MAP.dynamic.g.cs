using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_HEAT_MAP")]
    public sealed class _HEAP_LFH_HEAT_MAP : DynamicStructure
    {
        public ushort[] Counts { get; }
        public uint LastDecayPeriod { get; }

        public _HEAP_LFH_HEAT_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_HEAT_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_HEAT_MAP.Counts),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_HEAT_MAP.LastDecayPeriod),
                    new ulong[]
                    {
                        252UL
                    }
                }
            };
            Register<_HEAP_LFH_HEAT_MAP>((mem, ptr) => new _HEAP_LFH_HEAT_MAP(mem, ptr), offsets);
        }
    }
}