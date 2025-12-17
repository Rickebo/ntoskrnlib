using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_NODE_RANGE")]
    public sealed class _HAL_NODE_RANGE : DynamicStructure
    {
        public ulong PageFrameIndex { get; }
        public uint Node { get; }

        public _HAL_NODE_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_NODE_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_NODE_RANGE.PageFrameIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_NODE_RANGE.Node),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HAL_NODE_RANGE>((mem, ptr) => new _HAL_NODE_RANGE(mem, ptr), offsets);
        }
    }
}