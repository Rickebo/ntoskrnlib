using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPRCB_TRACEPOINT_LOG")]
    public sealed class _KPRCB_TRACEPOINT_LOG : DynamicStructure
    {
        public _KPRCB_TRACEPOINT_LOG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB_TRACEPOINT_LOG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KPRCB_TRACEPOINT_LOG>((mem, ptr) => new _KPRCB_TRACEPOINT_LOG(mem, ptr), offsets);
        }
    }
}