using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_LIST")]
    public sealed class _MMPTE_LIST : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong OneEntry { get; }
        public ulong filler0 { get; }
        public ulong SwizzleBit { get; }
        public ulong Protection { get; }
        public ulong Prototype { get; }
        public ulong Transition { get; }
        public ulong filler1 { get; }
        public ulong NextEntry { get; }

        public _MMPTE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_LIST.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.OneEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.filler0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.SwizzleBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.Transition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.filler1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_LIST.NextEntry),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_LIST>((mem, ptr) => new _MMPTE_LIST(mem, ptr), offsets);
        }
    }
}