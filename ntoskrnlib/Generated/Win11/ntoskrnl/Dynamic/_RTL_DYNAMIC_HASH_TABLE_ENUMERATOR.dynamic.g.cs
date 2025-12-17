using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR")]
    public sealed class _RTL_DYNAMIC_HASH_TABLE_ENUMERATOR : DynamicStructure
    {
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry { get; }
        public IntPtr CurEntry { get; }
        public IntPtr ChainHead { get; }
        public uint BucketIndex { get; }

        public _RTL_DYNAMIC_HASH_TABLE_ENUMERATOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DYNAMIC_HASH_TABLE_ENUMERATOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR.HashEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR.CurEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR.ChainHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR.BucketIndex),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_RTL_DYNAMIC_HASH_TABLE_ENUMERATOR>((mem, ptr) => new _RTL_DYNAMIC_HASH_TABLE_ENUMERATOR(mem, ptr), offsets);
        }
    }
}