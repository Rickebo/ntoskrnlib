using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SYSTEMTIME")]
    public sealed class _ETW_SYSTEMTIME : DynamicStructure
    {
        public ushort Year { get; }
        public ushort Month { get; }
        public ushort DayOfWeek { get; }
        public ushort Day { get; }
        public ushort Hour { get; }
        public ushort Minute { get; }
        public ushort Second { get; }
        public ushort Milliseconds { get; }

        public _ETW_SYSTEMTIME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SYSTEMTIME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_SYSTEMTIME.Year),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.Month),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.DayOfWeek),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.Day),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.Hour),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.Minute),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.Second),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ETW_SYSTEMTIME.Milliseconds),
                    new ulong[]
                    {
                        14UL
                    }
                }
            };
            Register<_ETW_SYSTEMTIME>((mem, ptr) => new _ETW_SYSTEMTIME(mem, ptr), offsets);
        }
    }
}