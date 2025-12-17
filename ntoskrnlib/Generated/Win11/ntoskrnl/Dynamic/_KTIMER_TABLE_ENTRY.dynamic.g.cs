using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER_TABLE_ENTRY")]
    public sealed class _KTIMER_TABLE_ENTRY : DynamicStructure
    {
        public ulong Lock { get; }
        public _LIST_ENTRY Entry { get; }
        public _ULARGE_INTEGER Time { get; }

        public _KTIMER_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER_TABLE_ENTRY.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER_TABLE_ENTRY.Entry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KTIMER_TABLE_ENTRY.Time),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_KTIMER_TABLE_ENTRY>((mem, ptr) => new _KTIMER_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}