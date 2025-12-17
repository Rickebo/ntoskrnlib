using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_FILTER_LEVEL_KW")]
    public sealed class _EVENT_FILTER_LEVEL_KW : DynamicStructure
    {
        public ulong MatchAnyKeyword { get; }
        public ulong MatchAllKeyword { get; }
        public byte Level { get; }
        public byte FilterIn { get; }

        public _EVENT_FILTER_LEVEL_KW(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_FILTER_LEVEL_KW()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_FILTER_LEVEL_KW.MatchAnyKeyword),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_LEVEL_KW.MatchAllKeyword),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_LEVEL_KW.Level),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EVENT_FILTER_LEVEL_KW.FilterIn),
                    new ulong[]
                    {
                        17UL
                    }
                }
            };
            Register<_EVENT_FILTER_LEVEL_KW>((mem, ptr) => new _EVENT_FILTER_LEVEL_KW(mem, ptr), offsets);
        }
    }
}