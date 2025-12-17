using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_HASH_TABLE_ITERATOR")]
    public sealed class _RTL_HASH_TABLE_ITERATOR : DynamicStructure
    {
        public IntPtr Hash { get; }
        public IntPtr HashEntry { get; }
        public IntPtr Bucket { get; }

        public _RTL_HASH_TABLE_ITERATOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HASH_TABLE_ITERATOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HASH_TABLE_ITERATOR.Hash),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HASH_TABLE_ITERATOR.HashEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_HASH_TABLE_ITERATOR.Bucket),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_HASH_TABLE_ITERATOR>((mem, ptr) => new _RTL_HASH_TABLE_ITERATOR(mem, ptr), offsets);
        }
    }
}