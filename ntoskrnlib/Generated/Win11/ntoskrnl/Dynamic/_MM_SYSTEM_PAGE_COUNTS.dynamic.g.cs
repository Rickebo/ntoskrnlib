using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_SYSTEM_PAGE_COUNTS")]
    public sealed class _MM_SYSTEM_PAGE_COUNTS : DynamicStructure
    {
        public uint SystemCodePage { get; }
        public uint SystemDriverPage { get; }
        public int TotalSystemCodePages { get; }
        public int TotalSystemDriverPages { get; }

        public _MM_SYSTEM_PAGE_COUNTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_SYSTEM_PAGE_COUNTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_SYSTEM_PAGE_COUNTS.SystemCodePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SYSTEM_PAGE_COUNTS.SystemDriverPage),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MM_SYSTEM_PAGE_COUNTS.TotalSystemCodePages),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MM_SYSTEM_PAGE_COUNTS.TotalSystemDriverPages),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_MM_SYSTEM_PAGE_COUNTS>((mem, ptr) => new _MM_SYSTEM_PAGE_COUNTS(mem, ptr), offsets);
        }
    }
}