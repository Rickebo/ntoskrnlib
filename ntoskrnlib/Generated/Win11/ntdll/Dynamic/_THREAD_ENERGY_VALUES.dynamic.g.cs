using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_THREAD_ENERGY_VALUES")]
    public sealed class _THREAD_ENERGY_VALUES : DynamicStructure
    {
        public byte[] Cycles { get; }
        public byte[] AttributedCycles { get; }
        public byte[] WorkOnBehalfCycles { get; }
        public _TIMELINE_BITMAP CpuTimeline { get; }

        public _THREAD_ENERGY_VALUES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THREAD_ENERGY_VALUES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THREAD_ENERGY_VALUES.Cycles),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THREAD_ENERGY_VALUES.AttributedCycles),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_THREAD_ENERGY_VALUES.WorkOnBehalfCycles),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_THREAD_ENERGY_VALUES.CpuTimeline),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_THREAD_ENERGY_VALUES>((mem, ptr) => new _THREAD_ENERGY_VALUES(mem, ptr), offsets);
        }
    }
}