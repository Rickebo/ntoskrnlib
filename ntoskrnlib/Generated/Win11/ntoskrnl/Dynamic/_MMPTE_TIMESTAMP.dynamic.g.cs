using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_TIMESTAMP")]
    public sealed class _MMPTE_TIMESTAMP : DynamicStructure
    {
        public ulong MustBeZero { get; }
        public ulong Unused { get; }
        public ulong SwizzleBit { get; }
        public ulong Protection { get; }
        public ulong Prototype { get; }
        public ulong Transition { get; }
        public ulong PageFileLow { get; }
        public ulong Reserved { get; }
        public ulong GlobalTimeStamp { get; }

        public _MMPTE_TIMESTAMP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_TIMESTAMP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_TIMESTAMP.MustBeZero),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.SwizzleBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.Transition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.PageFileLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_TIMESTAMP.GlobalTimeStamp),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_TIMESTAMP>((mem, ptr) => new _MMPTE_TIMESTAMP(mem, ptr), offsets);
        }
    }
}