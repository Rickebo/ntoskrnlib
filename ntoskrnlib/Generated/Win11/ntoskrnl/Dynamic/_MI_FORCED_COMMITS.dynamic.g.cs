using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_FORCED_COMMITS")]
    public sealed class _MI_FORCED_COMMITS : DynamicStructure
    {
        public uint Regular { get; }
        public uint Wrap { get; }

        public _MI_FORCED_COMMITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_FORCED_COMMITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_FORCED_COMMITS.Regular),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FORCED_COMMITS.Wrap),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_MI_FORCED_COMMITS>((mem, ptr) => new _MI_FORCED_COMMITS(mem, ptr), offsets);
        }
    }
}