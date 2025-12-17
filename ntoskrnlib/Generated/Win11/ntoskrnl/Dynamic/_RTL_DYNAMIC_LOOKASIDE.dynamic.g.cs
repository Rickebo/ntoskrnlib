using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_DYNAMIC_LOOKASIDE")]
    public sealed class _RTL_DYNAMIC_LOOKASIDE : DynamicStructure
    {
        public ulong EnabledBucketBitmap { get; }
        public uint BucketCount { get; }
        public uint ActiveBucketCount { get; }
        public byte[] Buckets { get; }

        public _RTL_DYNAMIC_LOOKASIDE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DYNAMIC_LOOKASIDE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DYNAMIC_LOOKASIDE.EnabledBucketBitmap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_LOOKASIDE.BucketCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_LOOKASIDE.ActiveBucketCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_LOOKASIDE.Buckets),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_RTL_DYNAMIC_LOOKASIDE>((mem, ptr) => new _RTL_DYNAMIC_LOOKASIDE(mem, ptr), offsets);
        }
    }
}