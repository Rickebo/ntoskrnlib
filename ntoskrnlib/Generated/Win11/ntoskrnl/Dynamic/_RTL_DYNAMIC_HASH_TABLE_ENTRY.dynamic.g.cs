using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_DYNAMIC_HASH_TABLE_ENTRY")]
    public sealed class _RTL_DYNAMIC_HASH_TABLE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Linkage { get; }
        public ulong Signature { get; }

        public _RTL_DYNAMIC_HASH_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DYNAMIC_HASH_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_ENTRY.Linkage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_ENTRY.Signature),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_DYNAMIC_HASH_TABLE_ENTRY>((mem, ptr) => new _RTL_DYNAMIC_HASH_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}