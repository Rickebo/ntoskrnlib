using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PAYLOAD_FILTER")]
    public sealed class _ETW_PAYLOAD_FILTER : DynamicStructure
    {
        public int RefCount { get; }
        public _AGGREGATED_PAYLOAD_FILTER PayloadFilter { get; }

        public _ETW_PAYLOAD_FILTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PAYLOAD_FILTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_PAYLOAD_FILTER.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_PAYLOAD_FILTER.PayloadFilter),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ETW_PAYLOAD_FILTER>((mem, ptr) => new _ETW_PAYLOAD_FILTER(mem, ptr), offsets);
        }
    }
}