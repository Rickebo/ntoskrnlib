using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SPECIAL_PURPOSE_MEMORY_STATE")]
    public sealed class _MI_SPECIAL_PURPOSE_MEMORY_STATE : DynamicStructure
    {
        public _LIST_ENTRY TypesList { get; }
        public _LIST_ENTRY CacheEligibleList { get; }
        public IntPtr RegularMemoryParentPartitionObject { get; }
        public IntPtr SpecialPurposeMemoryParentHandle { get; }
        public ulong[] Attributes { get; }
        public _EX_PUSH_LOCK Lock { get; }

        public _MI_SPECIAL_PURPOSE_MEMORY_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SPECIAL_PURPOSE_MEMORY_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SPECIAL_PURPOSE_MEMORY_STATE.TypesList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SPECIAL_PURPOSE_MEMORY_STATE.CacheEligibleList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SPECIAL_PURPOSE_MEMORY_STATE.RegularMemoryParentPartitionObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SPECIAL_PURPOSE_MEMORY_STATE.SpecialPurposeMemoryParentHandle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_SPECIAL_PURPOSE_MEMORY_STATE.Attributes),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SPECIAL_PURPOSE_MEMORY_STATE.Lock),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_MI_SPECIAL_PURPOSE_MEMORY_STATE>((mem, ptr) => new _MI_SPECIAL_PURPOSE_MEMORY_STATE(mem, ptr), offsets);
        }
    }
}