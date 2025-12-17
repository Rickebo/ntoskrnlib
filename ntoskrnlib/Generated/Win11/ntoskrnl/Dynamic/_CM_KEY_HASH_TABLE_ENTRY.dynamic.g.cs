using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_HASH_TABLE_ENTRY")]
    public sealed class _CM_KEY_HASH_TABLE_ENTRY : DynamicStructure
    {
        public _EX_PUSH_LOCK Lock { get; }
        public IntPtr Owner { get; }
        public IntPtr Entry { get; }

        public _CM_KEY_HASH_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_HASH_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_HASH_TABLE_ENTRY.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_HASH_TABLE_ENTRY.Owner),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_HASH_TABLE_ENTRY.Entry),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_CM_KEY_HASH_TABLE_ENTRY>((mem, ptr) => new _CM_KEY_HASH_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}