using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_HP_SEG_ALLOC_POLICY")]
    public sealed class _RTL_HP_SEG_ALLOC_POLICY : DynamicStructure
    {
        public ulong MinLargePages { get; }
        public ulong MaxLargePages { get; }
        public byte MinUtilization { get; }

        public _RTL_HP_SEG_ALLOC_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HP_SEG_ALLOC_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HP_SEG_ALLOC_POLICY.MinLargePages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HP_SEG_ALLOC_POLICY.MaxLargePages),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_HP_SEG_ALLOC_POLICY.MinUtilization),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_HP_SEG_ALLOC_POLICY>((mem, ptr) => new _RTL_HP_SEG_ALLOC_POLICY(mem, ptr), offsets);
        }
    }
}