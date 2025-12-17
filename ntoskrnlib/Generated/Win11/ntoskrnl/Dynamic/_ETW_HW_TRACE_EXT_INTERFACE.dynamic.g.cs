using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_HW_TRACE_EXT_INTERFACE")]
    public sealed class _ETW_HW_TRACE_EXT_INTERFACE : DynamicStructure
    {
        public IntPtr StartProcessorTraceOnEachCore { get; }
        public IntPtr StopProcessorTraceOnEachCore { get; }
        public IntPtr LogProcessorTraceOnCurrentCore { get; }

        public _ETW_HW_TRACE_EXT_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_HW_TRACE_EXT_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_HW_TRACE_EXT_INTERFACE.StartProcessorTraceOnEachCore),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_HW_TRACE_EXT_INTERFACE.StopProcessorTraceOnEachCore),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_HW_TRACE_EXT_INTERFACE.LogProcessorTraceOnCurrentCore),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_ETW_HW_TRACE_EXT_INTERFACE>((mem, ptr) => new _ETW_HW_TRACE_EXT_INTERFACE(mem, ptr), offsets);
        }
    }
}