using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SLIST_HEADER")]
    public sealed class _SLIST_HEADER : DynamicStructure
    {
        public ulong Alignment { get; }
        public ulong Region { get; }
        public _unnamed_tag_ HeaderX64 { get; }

        public _SLIST_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SLIST_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SLIST_HEADER.Alignment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SLIST_HEADER.Region),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SLIST_HEADER.HeaderX64),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SLIST_HEADER>((mem, ptr) => new _SLIST_HEADER(mem, ptr), offsets);
        }
    }
}