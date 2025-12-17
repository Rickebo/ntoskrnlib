using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_BLOCK_BASE")]
    public sealed class _MI_COMBINE_BLOCK_BASE : DynamicStructure
    {
        public IntPtr Next { get; }
        public uint NumberOfActiveBlocks { get; }
        public IntPtr Pcs { get; }

        public _MI_COMBINE_BLOCK_BASE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COMBINE_BLOCK_BASE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COMBINE_BLOCK_BASE.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COMBINE_BLOCK_BASE.NumberOfActiveBlocks),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_COMBINE_BLOCK_BASE.Pcs),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MI_COMBINE_BLOCK_BASE>((mem, ptr) => new _MI_COMBINE_BLOCK_BASE(mem, ptr), offsets);
        }
    }
}