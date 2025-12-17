using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_COUNTERS")]
    public sealed class _ETW_COUNTERS : DynamicStructure
    {
        public int GuidCount { get; }
        public int[] PoolUsage { get; }
        public int SessionCount { get; }

        public _ETW_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_COUNTERS.GuidCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_COUNTERS.PoolUsage),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETW_COUNTERS.SessionCount),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_ETW_COUNTERS>((mem, ptr) => new _ETW_COUNTERS(mem, ptr), offsets);
        }
    }
}