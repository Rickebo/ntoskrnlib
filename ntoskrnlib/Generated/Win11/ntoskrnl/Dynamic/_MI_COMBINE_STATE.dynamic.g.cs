using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_STATE")]
    public sealed class _MI_COMBINE_STATE : DynamicStructure
    {
        public int ActiveSpinLock { get; }
        public uint CombiningThreadCount { get; }
        public _RTL_AVL_TREE ActiveThreadTree { get; }
        public ulong CommonPageCombineDomain { get; }
        public uint CommonCombineDomainAssigned { get; }
        public int CombineSequence { get; }

        public _MI_COMBINE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COMBINE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COMBINE_STATE.ActiveSpinLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COMBINE_STATE.CombiningThreadCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_COMBINE_STATE.ActiveThreadTree),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_COMBINE_STATE.CommonPageCombineDomain),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_COMBINE_STATE.CommonCombineDomainAssigned),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_COMBINE_STATE.CombineSequence),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_MI_COMBINE_STATE>((mem, ptr) => new _MI_COMBINE_STATE(mem, ptr), offsets);
        }
    }
}