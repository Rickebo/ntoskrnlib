using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_EVENT_NAME_DATA")]
    public sealed class _ETW_FILTER_EVENT_NAME_DATA : DynamicStructure
    {
        public byte FilterIn { get; }
        public byte Level { get; }
        public ulong MatchAnyKeyword { get; }
        public ulong MatchAllKeyword { get; }
        public _RTL_HASH_TABLE NameTable { get; }

        public _ETW_FILTER_EVENT_NAME_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_FILTER_EVENT_NAME_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_FILTER_EVENT_NAME_DATA.FilterIn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_FILTER_EVENT_NAME_DATA.Level),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_ETW_FILTER_EVENT_NAME_DATA.MatchAnyKeyword),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_FILTER_EVENT_NAME_DATA.MatchAllKeyword),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_FILTER_EVENT_NAME_DATA.NameTable),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ETW_FILTER_EVENT_NAME_DATA>((mem, ptr) => new _ETW_FILTER_EVENT_NAME_DATA(mem, ptr), offsets);
        }
    }
}