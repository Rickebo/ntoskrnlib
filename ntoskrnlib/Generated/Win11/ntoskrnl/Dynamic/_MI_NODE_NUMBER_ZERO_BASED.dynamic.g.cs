using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_NODE_NUMBER_ZERO_BASED")]
    public sealed class _MI_NODE_NUMBER_ZERO_BASED : DynamicStructure
    {
        public uint ZeroBased { get; }

        public _MI_NODE_NUMBER_ZERO_BASED(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_NODE_NUMBER_ZERO_BASED()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_NODE_NUMBER_ZERO_BASED.ZeroBased),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_NODE_NUMBER_ZERO_BASED>((mem, ptr) => new _MI_NODE_NUMBER_ZERO_BASED(mem, ptr), offsets);
        }
    }
}