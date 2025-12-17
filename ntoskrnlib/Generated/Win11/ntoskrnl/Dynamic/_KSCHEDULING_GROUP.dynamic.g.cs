using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSCHEDULING_GROUP")]
    public sealed class _KSCHEDULING_GROUP : DynamicStructure
    {
        public _KSCHEDULING_GROUP_POLICY Policy { get; }
        public uint RelativeWeight { get; }
        public uint ChildMinRate { get; }
        public uint ChildMinWeight { get; }
        public uint ChildTotalWeight { get; }
        public ulong QueryHistoryTimeStamp { get; }
        public long NotificationCycles { get; }
        public long MaxQuotaLimitCycles { get; }
        public long MaxQuotaCyclesRemaining { get; }
        public _LIST_ENTRY SchedulingGroupList { get; }
        public _LIST_ENTRY Sibling { get; }
        public IntPtr NotificationDpc { get; }
        public _LIST_ENTRY ChildList { get; }
        public IntPtr Parent { get; }
        public byte[] PerProcessor { get; }

        public _KSCHEDULING_GROUP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSCHEDULING_GROUP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSCHEDULING_GROUP.Policy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.RelativeWeight),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.ChildMinRate),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.ChildMinWeight),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.ChildTotalWeight),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.QueryHistoryTimeStamp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.NotificationCycles),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.MaxQuotaLimitCycles),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.MaxQuotaCyclesRemaining),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.SchedulingGroupList),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.Sibling),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.NotificationDpc),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.ChildList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.Parent),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP.PerProcessor),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_KSCHEDULING_GROUP>((mem, ptr) => new _KSCHEDULING_GROUP(mem, ptr), offsets);
        }
    }
}