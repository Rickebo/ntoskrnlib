using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_SUBSECTION")]
    public sealed class _MMPTE_SUBSECTION : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong Unused0 { get; }
        public ulong OnStandbyLookaside { get; }
        public ulong SwizzleBit { get; }
        public ulong Protection { get; }
        public ulong Prototype { get; }
        public ulong ColdPage { get; }
        public ulong Unused2 { get; }
        public ulong ExecutePrivilege { get; }
        public long SubsectionAddress { get; }

        public _MMPTE_SUBSECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_SUBSECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_SUBSECTION.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.Unused0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.OnStandbyLookaside),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.SwizzleBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.ColdPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.Unused2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.ExecutePrivilege),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_SUBSECTION.SubsectionAddress),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_SUBSECTION>((mem, ptr) => new _MMPTE_SUBSECTION(mem, ptr), offsets);
        }
    }
}