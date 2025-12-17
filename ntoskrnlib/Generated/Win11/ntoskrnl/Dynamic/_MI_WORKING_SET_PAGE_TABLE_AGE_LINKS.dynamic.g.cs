using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS")]
    public sealed class _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS : DynamicStructure
    {
        public int Lock { get; }
        public uint EntryCount { get; }
        public IntPtr Flink { get; }
        public IntPtr Blink { get; }

        public _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS.EntryCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS.Flink),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS.Blink),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MI_WORKING_SET_PAGE_TABLE_AGE_LINKS>((mem, ptr) => new _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS(mem, ptr), offsets);
        }
    }
}