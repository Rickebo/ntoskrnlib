using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_SOFTWARE")]
    public sealed class _MMPTE_SOFTWARE : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong PageFileReserved { get; }
        public ulong PageFileAllocated { get; }
        public ulong ColdPage { get; }
        public ulong SwizzleBit { get; }
        public ulong Protection { get; }
        public ulong Prototype { get; }
        public ulong Transition { get; }
        public ulong PageFileLow { get; }
        public ulong UsedPageTableEntries { get; }
        public ulong ShadowStack { get; }
        public ulong OnStandbyLookaside { get; }
        public ulong Unused { get; }
        public ulong PageFileHigh { get; }

        public _MMPTE_SOFTWARE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_SOFTWARE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_SOFTWARE.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.PageFileReserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.PageFileAllocated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.ColdPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.SwizzleBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.Transition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.PageFileLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.UsedPageTableEntries),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.ShadowStack),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.OnStandbyLookaside),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SOFTWARE.PageFileHigh),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_SOFTWARE>((mem, ptr) => new _MMPTE_SOFTWARE(mem, ptr), offsets);
        }
    }
}