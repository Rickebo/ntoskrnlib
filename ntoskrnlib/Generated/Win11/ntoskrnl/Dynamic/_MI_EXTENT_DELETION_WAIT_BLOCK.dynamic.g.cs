using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_EXTENT_DELETION_WAIT_BLOCK")]
    public sealed class _MI_EXTENT_DELETION_WAIT_BLOCK : DynamicStructure
    {
        public IntPtr Next { get; }
        public _KGATE Gate { get; }

        public _MI_EXTENT_DELETION_WAIT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_EXTENT_DELETION_WAIT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_EXTENT_DELETION_WAIT_BLOCK.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_EXTENT_DELETION_WAIT_BLOCK.Gate),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_EXTENT_DELETION_WAIT_BLOCK>((mem, ptr) => new _MI_EXTENT_DELETION_WAIT_BLOCK(mem, ptr), offsets);
        }
    }
}