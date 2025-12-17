using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PFN_FLAGS4")]
    public sealed class _MI_PFN_FLAGS4 : DynamicStructure
    {
        public ulong PteFrame { get; }
        public ulong ResidentPage { get; }
        public ulong ResidentPageContainsBadPages { get; }
        public ulong Unused1 { get; }
        public ulong Partition { get; }
        public ulong FileOnly { get; }
        public ulong PfnExists { get; }
        public ulong NodeFlinkHigh { get; }
        public ulong PageIdentity { get; }
        public ulong PrototypePte { get; }
        public ulong EntireField { get; }

        public _MI_PFN_FLAGS4(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PFN_FLAGS4()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PFN_FLAGS4.PteFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.ResidentPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.ResidentPageContainsBadPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.Unused1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.FileOnly),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.PfnExists),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.NodeFlinkHigh),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.PageIdentity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.PrototypePte),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS4.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_PFN_FLAGS4>((mem, ptr) => new _MI_PFN_FLAGS4(mem, ptr), offsets);
        }
    }
}