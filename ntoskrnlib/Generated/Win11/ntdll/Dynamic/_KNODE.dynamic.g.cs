using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KNODE")]
    public sealed class _KNODE : DynamicStructure
    {
        public ushort NodeNumber { get; }
        public ushort PrimaryNodeNumber { get; }
        public uint ProximityId { get; }
        public ushort MaximumProcessors { get; }
        public _unnamed_tag_ Flags { get; }
        public byte GroupSeed { get; }
        public byte PrimaryGroup { get; }
        public byte[] Padding { get; }
        public _KGROUP_MASK ActiveGroups { get; }
        public byte[] SchedulerSubNodes { get; }
        public uint[] ActiveTopologyElements { get; }
        public byte[] PerformanceSearchRanks { get; }
        public byte[] EfficiencySearchRanks { get; }

        public _KNODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KNODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KNODE.NodeNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KNODE.PrimaryNodeNumber),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KNODE.ProximityId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KNODE.MaximumProcessors),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KNODE.Flags),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_KNODE.GroupSeed),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_KNODE.PrimaryGroup),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KNODE.Padding),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_KNODE.ActiveGroups),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KNODE.SchedulerSubNodes),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KNODE.ActiveTopologyElements),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KNODE.PerformanceSearchRanks),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_KNODE.EfficiencySearchRanks),
                    new ulong[]
                    {
                        340UL
                    }
                }
            };
            Register<_KNODE>((mem, ptr) => new _KNODE(mem, ptr), offsets);
        }
    }
}