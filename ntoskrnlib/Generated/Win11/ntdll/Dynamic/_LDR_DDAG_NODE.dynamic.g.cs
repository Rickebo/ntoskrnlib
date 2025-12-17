using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LDR_DDAG_NODE")]
    public sealed class _LDR_DDAG_NODE : DynamicStructure
    {
        public _LIST_ENTRY Modules { get; }
        public IntPtr ServiceTagList { get; }
        public uint LoadCount { get; }
        public uint LoadWhileUnloadingCount { get; }
        public uint LowestLink { get; }
        public _LDRP_CSLIST Dependencies { get; }
        public _LDRP_CSLIST IncomingDependencies { get; }
        public uint State { get; }
        public _SINGLE_LIST_ENTRY CondenseLink { get; }
        public uint PreorderNumber { get; }

        public _LDR_DDAG_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LDR_DDAG_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LDR_DDAG_NODE.Modules),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.ServiceTagList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.LoadCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.LoadWhileUnloadingCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.LowestLink),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.Dependencies),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.IncomingDependencies),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.State),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.CondenseLink),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LDR_DDAG_NODE.PreorderNumber),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_LDR_DDAG_NODE>((mem, ptr) => new _LDR_DDAG_NODE(mem, ptr), offsets);
        }
    }
}