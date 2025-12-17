using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_JOB_NET_RATE_CONTROL")]
    public sealed class _JOB_NET_RATE_CONTROL : DynamicStructure
    {
        public _JOB_NET_RATE_CONTROL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _JOB_NET_RATE_CONTROL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_JOB_NET_RATE_CONTROL>((mem, ptr) => new _JOB_NET_RATE_CONTROL(mem, ptr), offsets);
        }
    }
}