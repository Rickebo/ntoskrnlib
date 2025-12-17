using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_HASH_ENTRY")]
    public sealed class _RTL_HASH_ENTRY : DynamicStructure
    {
        public _SINGLE_LIST_ENTRY BucketLink { get; }
        public ulong Key { get; }

        public _RTL_HASH_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HASH_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HASH_ENTRY.BucketLink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HASH_ENTRY.Key),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_HASH_ENTRY>((mem, ptr) => new _RTL_HASH_ENTRY(mem, ptr), offsets);
        }
    }
}