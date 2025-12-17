using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMCLONE_BLOCK")]
    public sealed class _MMCLONE_BLOCK : DynamicStructure
    {
        public _MMPTE ProtoPte { get; }
        public ulong CrossPartitionReferences { get; }
        public _MI_CLONE_BLOCK_FLAGS u1 { get; }
        public ulong UseCount { get; }

        public _MMCLONE_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMCLONE_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMCLONE_BLOCK.ProtoPte),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMCLONE_BLOCK.CrossPartitionReferences),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMCLONE_BLOCK.u1),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMCLONE_BLOCK.UseCount),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MMCLONE_BLOCK>((mem, ptr) => new _MMCLONE_BLOCK(mem, ptr), offsets);
        }
    }
}