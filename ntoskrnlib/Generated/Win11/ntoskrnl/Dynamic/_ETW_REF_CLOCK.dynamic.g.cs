using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_REF_CLOCK")]
    public sealed class _ETW_REF_CLOCK : DynamicStructure
    {
        public _LARGE_INTEGER StartTime { get; }
        public _LARGE_INTEGER StartPerfClock { get; }

        public _ETW_REF_CLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_REF_CLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_REF_CLOCK.StartTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_REF_CLOCK.StartPerfClock),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ETW_REF_CLOCK>((mem, ptr) => new _ETW_REF_CLOCK(mem, ptr), offsets);
        }
    }
}