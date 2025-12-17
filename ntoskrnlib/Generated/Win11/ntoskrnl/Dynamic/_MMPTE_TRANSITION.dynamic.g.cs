using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_TRANSITION")]
    public sealed class _MMPTE_TRANSITION : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong Write { get; }
        public ulong OnStandbyLookaside { get; }
        public ulong IoTracker { get; }
        public ulong SwizzleBit { get; }
        public ulong Protection { get; }
        public ulong Prototype { get; }
        public ulong Transition { get; }
        public ulong PageFrameNumber { get; }
        public ulong Unused { get; }

        public _MMPTE_TRANSITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_TRANSITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_TRANSITION.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.Write),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.OnStandbyLookaside),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.IoTracker),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.SwizzleBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.Transition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.PageFrameNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TRANSITION.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_TRANSITION>((mem, ptr) => new _MMPTE_TRANSITION(mem, ptr), offsets);
        }
    }
}