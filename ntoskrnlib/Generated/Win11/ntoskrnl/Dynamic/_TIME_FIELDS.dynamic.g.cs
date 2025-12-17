using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TIME_FIELDS")]
    public sealed class _TIME_FIELDS : DynamicStructure
    {
        public short Year { get; }
        public short Month { get; }
        public short Day { get; }
        public short Hour { get; }
        public short Minute { get; }
        public short Second { get; }
        public short Milliseconds { get; }
        public short Weekday { get; }

        public _TIME_FIELDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TIME_FIELDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TIME_FIELDS.Year),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Month),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Day),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Hour),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Minute),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Second),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Milliseconds),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_TIME_FIELDS.Weekday),
                    new ulong[]
                    {
                        14UL
                    }
                }
            };
            Register<_TIME_FIELDS>((mem, ptr) => new _TIME_FIELDS(mem, ptr), offsets);
        }
    }
}