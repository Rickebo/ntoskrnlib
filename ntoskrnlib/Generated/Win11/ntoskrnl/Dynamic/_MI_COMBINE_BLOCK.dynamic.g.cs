using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_BLOCK")]
    public sealed class _MI_COMBINE_BLOCK : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }
        public ulong HashValue { get; }
        public _MMCLONE_BLOCK Clone { get; }
        public ulong CombineDomain { get; }

        public _MI_COMBINE_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COMBINE_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COMBINE_BLOCK.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COMBINE_BLOCK.HashValue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_COMBINE_BLOCK.Clone),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_COMBINE_BLOCK.CombineDomain),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_COMBINE_BLOCK>((mem, ptr) => new _MI_COMBINE_BLOCK(mem, ptr), offsets);
        }
    }
}