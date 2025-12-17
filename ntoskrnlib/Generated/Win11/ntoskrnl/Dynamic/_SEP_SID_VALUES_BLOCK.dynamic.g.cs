using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_SID_VALUES_BLOCK")]
    public sealed class _SEP_SID_VALUES_BLOCK : DynamicStructure
    {
        public uint BlockLength { get; }
        public long ReferenceCount { get; }
        public uint SidCount { get; }
        public ulong SidValuesStart { get; }

        public _SEP_SID_VALUES_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_SID_VALUES_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_SID_VALUES_BLOCK.BlockLength),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_SID_VALUES_BLOCK.ReferenceCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_SID_VALUES_BLOCK.SidCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEP_SID_VALUES_BLOCK.SidValuesStart),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_SEP_SID_VALUES_BLOCK>((mem, ptr) => new _SEP_SID_VALUES_BLOCK(mem, ptr), offsets);
        }
    }
}