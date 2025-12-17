using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRACE_ENABLE_INFO")]
    public sealed class _TRACE_ENABLE_INFO : DynamicStructure
    {
        public uint IsEnabled { get; }
        public byte Level { get; }
        public byte Reserved1 { get; }
        public ushort LoggerId { get; }
        public uint EnableProperty { get; }
        public uint Reserved2 { get; }
        public ulong MatchAnyKeyword { get; }
        public ulong MatchAllKeyword { get; }

        public _TRACE_ENABLE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRACE_ENABLE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRACE_ENABLE_INFO.IsEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.Level),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.Reserved1),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.LoggerId),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.EnableProperty),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.Reserved2),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.MatchAnyKeyword),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRACE_ENABLE_INFO.MatchAllKeyword),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_TRACE_ENABLE_INFO>((mem, ptr) => new _TRACE_ENABLE_INFO(mem, ptr), offsets);
        }
    }
}