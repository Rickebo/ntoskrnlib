using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SID_AND_ATTRIBUTES_HASH")]
    public sealed class _SID_AND_ATTRIBUTES_HASH : DynamicStructure
    {
        public uint SidCount { get; }
        public IntPtr SidAttr { get; }
        public ulong[] Hash { get; }

        public _SID_AND_ATTRIBUTES_HASH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SID_AND_ATTRIBUTES_HASH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SID_AND_ATTRIBUTES_HASH.SidCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SID_AND_ATTRIBUTES_HASH.SidAttr),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SID_AND_ATTRIBUTES_HASH.Hash),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SID_AND_ATTRIBUTES_HASH>((mem, ptr) => new _SID_AND_ATTRIBUTES_HASH(mem, ptr), offsets);
        }
    }
}