using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSCB")]
    public sealed class _KSCB : DynamicStructure
    {
        public ulong GenerationCycles { get; }
        public ulong MinQuotaCycleTarget { get; }
        public ulong MaxQuotaCycleTarget { get; }
        public ulong RankCycleTarget { get; }
        public ulong LongTermCycles { get; }
        public ulong LastReportedCycles { get; }
        public ulong OverQuotaHistory { get; }
        public ulong ReadyTime { get; }
        public ulong InsertTime { get; }
        public _LIST_ENTRY PerProcessorList { get; }
        public _RTL_BALANCED_NODE QueueNode { get; }
        public ushort Inserted { get; }
        public ushort MaxOverQuota { get; }
        public ushort MinOverQuota { get; }
        public ushort RankBias { get; }
        public ushort UnconstrainedMaxQuota { get; }
        public ushort UnconstrainedMinQuota { get; }
        public ushort ShareRankOwner { get; }
        public ushort PerProcHardCap { get; }
        public ushort Referenced { get; }
        public ushort PrcbLockFlags { get; }
        public byte Depth { get; }
        public byte Pad1 { get; }
        public uint OwningProcessorIndex { get; }
        public ushort ReadySummary { get; }
        public ushort Pad2 { get; }
        public uint Rank { get; }
        public IntPtr ShareRank { get; }
        public uint OwnerShareRank { get; }
        public byte[] ReadyListHead { get; }
        public _RTL_RB_TREE ChildScbQueue { get; }
        public IntPtr Parent { get; }
        public IntPtr Root { get; }
        public _SINGLE_LIST_ENTRY TracingListEntry { get; }

        public _KSCB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSCB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSCB.GenerationCycles),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSCB.MinQuotaCycleTarget),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSCB.MaxQuotaCycleTarget),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSCB.RankCycleTarget),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSCB.LongTermCycles),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KSCB.LastReportedCycles),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KSCB.OverQuotaHistory),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KSCB.ReadyTime),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KSCB.InsertTime),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KSCB.PerProcessorList),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KSCB.QueueNode),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KSCB.Inserted),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.MaxOverQuota),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.MinOverQuota),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.RankBias),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.UnconstrainedMaxQuota),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.UnconstrainedMinQuota),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.ShareRankOwner),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.PerProcHardCap),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.Referenced),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.PrcbLockFlags),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSCB.Depth),
                    new ulong[]
                    {
                        114UL
                    }
                },
                {
                    nameof(_KSCB.Pad1),
                    new ulong[]
                    {
                        115UL
                    }
                },
                {
                    nameof(_KSCB.OwningProcessorIndex),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KSCB.ReadySummary),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KSCB.Pad2),
                    new ulong[]
                    {
                        122UL
                    }
                },
                {
                    nameof(_KSCB.Rank),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_KSCB.ShareRank),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KSCB.OwnerShareRank),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KSCB.ReadyListHead),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KSCB.ChildScbQueue),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_KSCB.Parent),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_KSCB.Root),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_KSCB.TracingListEntry),
                    new ulong[]
                    {
                        432UL
                    }
                }
            };
            Register<_KSCB>((mem, ptr) => new _KSCB(mem, ptr), offsets);
        }
    }
}