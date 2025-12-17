using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSWAPPABLE_PAGE_REF_COUNT")]
    public sealed class _KSWAPPABLE_PAGE_REF_COUNT : DynamicStructure
    {
        public ulong Value { get; }
        public ulong Resident { get; }
        public ulong RefCount { get; }

        public _KSWAPPABLE_PAGE_REF_COUNT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSWAPPABLE_PAGE_REF_COUNT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSWAPPABLE_PAGE_REF_COUNT.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSWAPPABLE_PAGE_REF_COUNT.Resident),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSWAPPABLE_PAGE_REF_COUNT.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KSWAPPABLE_PAGE_REF_COUNT>((mem, ptr) => new _KSWAPPABLE_PAGE_REF_COUNT(mem, ptr), offsets);
        }
    }
}