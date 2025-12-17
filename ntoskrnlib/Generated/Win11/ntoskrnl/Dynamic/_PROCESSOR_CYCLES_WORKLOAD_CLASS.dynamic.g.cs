using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_CYCLES_WORKLOAD_CLASS")]
    public sealed class _PROCESSOR_CYCLES_WORKLOAD_CLASS : DynamicStructure
    {
        public uint Count { get; }
        public ulong[] ProcessorCyclesClass { get; }

        public _PROCESSOR_CYCLES_WORKLOAD_CLASS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_CYCLES_WORKLOAD_CLASS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_CYCLES_WORKLOAD_CLASS.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_CYCLES_WORKLOAD_CLASS.ProcessorCyclesClass),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PROCESSOR_CYCLES_WORKLOAD_CLASS>((mem, ptr) => new _PROCESSOR_CYCLES_WORKLOAD_CLASS(mem, ptr), offsets);
        }
    }
}