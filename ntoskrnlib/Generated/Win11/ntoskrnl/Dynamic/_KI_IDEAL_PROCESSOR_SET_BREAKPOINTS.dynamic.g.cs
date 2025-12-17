using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_IDEAL_PROCESSOR_SET_BREAKPOINTS")]
    public sealed class _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS : DynamicStructure
    {
        public _KI_PROCESS_CONCURRENCY_COUNT Low { get; }
        public _KI_PROCESS_CONCURRENCY_COUNT High { get; }

        public _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_IDEAL_PROCESSOR_SET_BREAKPOINTS.Low),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_SET_BREAKPOINTS.High),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KI_IDEAL_PROCESSOR_SET_BREAKPOINTS>((mem, ptr) => new _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS(mem, ptr), offsets);
        }
    }
}