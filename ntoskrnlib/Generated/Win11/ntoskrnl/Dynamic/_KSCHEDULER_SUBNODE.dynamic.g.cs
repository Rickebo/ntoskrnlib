using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSCHEDULER_SUBNODE")]
    public sealed class _KSCHEDULER_SUBNODE : DynamicStructure
    {
        public ulong SubNodeLock { get; }
        public ulong IdleNonParkedCpuSet { get; }
        public ulong IdleCpuSet { get; }
        public ulong IdleSmtSet { get; }
        public ulong IdleModuleSet { get; }
        public ulong[] IdleIsolationUnitSet { get; }
        public ulong NonPairedSmtSet { get; }
        public ulong ThreadQosGroupingSet { get; }
        public ulong[] Spare1 { get; }
        public ulong DeepIdleSet { get; }
        public ulong IdleConstrainedSet { get; }
        public ulong NonParkedSet { get; }
        public ulong ParkRequestSet { get; }
        public ulong SoftParkRequestSet { get; }
        public ulong ForceParkRequestSet { get; }
        public ulong NonIsrTargetedSet { get; }
        public int ParkLock { get; }
        public byte ProcessSeed { get; }
        public byte[] Spare5 { get; }
        public _GROUP_AFFINITY Affinity { get; }
        public byte[] AffinityFill { get; }
        public ushort ParentNodeNumber { get; }
        public ushort SubNodeNumber { get; }
        public ushort Spare { get; }
        public ulong SiblingMask { get; }
        public ulong SharedReadyQueueMask { get; }
        public ulong StrideMask { get; }
        public ulong LLCLeaders { get; }
        public uint Lowest { get; }
        public uint Highest { get; }
        public _flags Flags { get; }
        public byte WorkloadClasses { get; }
        public IntPtr HeteroSets { get; }
        public IntPtr PerformanceRanks { get; }
        public IntPtr EfficiencyRanks { get; }
        public ulong[] Spare6 { get; }
        public ulong[] PpmConfiguredQosSets { get; }
        public ulong Spare7 { get; }
        public _KQOS_GROUPING_SETS PpmQosGroupingSets { get; }
        public ulong[] Spare8 { get; }
        public ulong StealableLocalReadyQueues { get; }
        public ulong StealableSharedReadyQueues { get; }
        public ulong StealableStandbyThreads { get; }
        public ulong[] Spare9 { get; }
        public _KRANK_LIST SoftParkRanks { get; }
        public _KRANK_LIST CoreShareCounts { get; }
        public _KRANK_LIST ModuleShareCounts { get; }
        public _KRANK_LIST ThreadQosGroupingCoreShareCounts { get; }
        public _KRANK_LIST ThreadQosGroupingModuleShareCounts { get; }

        public _KSCHEDULER_SUBNODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSCHEDULER_SUBNODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSCHEDULER_SUBNODE.SubNodeLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.IdleNonParkedCpuSet),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.IdleCpuSet),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.IdleSmtSet),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.IdleModuleSet),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.IdleIsolationUnitSet),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.NonPairedSmtSet),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ThreadQosGroupingSet),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare1),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.DeepIdleSet),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.IdleConstrainedSet),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.NonParkedSet),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ParkRequestSet),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.SoftParkRequestSet),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ForceParkRequestSet),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.NonIsrTargetedSet),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ParkLock),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ProcessSeed),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare5),
                    new ulong[]
                    {
                        125UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Affinity),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.AffinityFill),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ParentNodeNumber),
                    new ulong[]
                    {
                        138UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.SubNodeNumber),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare),
                    new ulong[]
                    {
                        142UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.SiblingMask),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.SharedReadyQueueMask),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.StrideMask),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.LLCLeaders),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Lowest),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Highest),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Flags),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.WorkloadClasses),
                    new ulong[]
                    {
                        185UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.HeteroSets),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.PerformanceRanks),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.EfficiencyRanks),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare6),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.PpmConfiguredQosSets),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare7),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.PpmQosGroupingSets),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare8),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.StealableLocalReadyQueues),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.StealableSharedReadyQueues),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.StealableStandbyThreads),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.Spare9),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.SoftParkRanks),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.CoreShareCounts),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ModuleShareCounts),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ThreadQosGroupingCoreShareCounts),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_KSCHEDULER_SUBNODE.ThreadQosGroupingModuleShareCounts),
                    new ulong[]
                    {
                        704UL
                    }
                }
            };
            Register<_KSCHEDULER_SUBNODE>((mem, ptr) => new _KSCHEDULER_SUBNODE(mem, ptr), offsets);
        }
    }
}