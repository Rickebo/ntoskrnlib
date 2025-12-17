using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_RANGE_LIST")]
    public sealed class _RTL_RANGE_LIST : DynamicStructure
    {
        public _LIST_ENTRY ListHead { get; }
        public uint Flags { get; }
        public uint Count { get; }
        public uint Stamp { get; }

        public _RTL_RANGE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_RANGE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_RANGE_LIST.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_RANGE_LIST.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_RANGE_LIST.Count),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_RTL_RANGE_LIST.Stamp),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_RTL_RANGE_LIST>((mem, ptr) => new _RTL_RANGE_LIST(mem, ptr), offsets);
        }
    }
}