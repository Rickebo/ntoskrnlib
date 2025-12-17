using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_HASH_TABLE")]
    public sealed class _RTL_HASH_TABLE : DynamicStructure
    {
        public uint EntryCount { get; }
        public uint MaskBitCount { get; }
        public uint BucketCount { get; }
        public IntPtr Buckets { get; }

        public _RTL_HASH_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HASH_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HASH_TABLE.EntryCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HASH_TABLE.MaskBitCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_HASH_TABLE.BucketCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_HASH_TABLE.Buckets),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_HASH_TABLE>((mem, ptr) => new _RTL_HASH_TABLE(mem, ptr), offsets);
        }
    }
}