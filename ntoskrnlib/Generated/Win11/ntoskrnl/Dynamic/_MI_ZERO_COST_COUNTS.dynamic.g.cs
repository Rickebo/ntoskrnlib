using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ZERO_COST_COUNTS")]
    public sealed class _MI_ZERO_COST_COUNTS : DynamicStructure
    {
        public ulong NativeSum { get; }
        public ulong AlternateSum { get; }

        public _MI_ZERO_COST_COUNTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ZERO_COST_COUNTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ZERO_COST_COUNTS.NativeSum),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ZERO_COST_COUNTS.AlternateSum),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_ZERO_COST_COUNTS>((mem, ptr) => new _MI_ZERO_COST_COUNTS(mem, ptr), offsets);
        }
    }
}