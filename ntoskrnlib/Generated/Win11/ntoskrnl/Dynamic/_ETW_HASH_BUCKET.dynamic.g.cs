using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_HASH_BUCKET")]
    public sealed class _ETW_HASH_BUCKET : DynamicStructure
    {
        public byte[] ListHead { get; }
        public _EX_PUSH_LOCK BucketLock { get; }

        public _ETW_HASH_BUCKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_HASH_BUCKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_HASH_BUCKET.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_HASH_BUCKET.BucketLock),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_ETW_HASH_BUCKET>((mem, ptr) => new _ETW_HASH_BUCKET(mem, ptr), offsets);
        }
    }
}