using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_PID")]
    public sealed class _ETW_FILTER_PID : DynamicStructure
    {
        public uint Count { get; }
        public uint[] Pids { get; }

        public _ETW_FILTER_PID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_FILTER_PID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_FILTER_PID.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_FILTER_PID.Pids),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_ETW_FILTER_PID>((mem, ptr) => new _ETW_FILTER_PID(mem, ptr), offsets);
        }
    }
}