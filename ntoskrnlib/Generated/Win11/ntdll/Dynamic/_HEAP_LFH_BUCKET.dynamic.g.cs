using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_BUCKET")]
    public sealed class _HEAP_LFH_BUCKET : DynamicStructure
    {
        public _HEAP_LFH_SUBSEGMENT_OWNER State { get; }
        public ulong TotalBlockCount { get; }
        public ulong TotalSubsegmentCount { get; }
        public uint ReciprocalBlockSize { get; }
        public ushort HotHeatThreshold { get; }
        public ushort PrivateHeatThreshold { get; }
        public ulong PrivSlotListLock { get; }
        public _HEAP_LFH_PTRREF_LIST PrivSlotList { get; }
        public byte CompactionNeeded { get; }
        public byte[] Spare { get; }
        public _HEAP_AFFINITY_MGR AffinityMgr { get; }

        public _HEAP_LFH_BUCKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_BUCKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_BUCKET.State),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.TotalBlockCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.TotalSubsegmentCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.ReciprocalBlockSize),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.HotHeatThreshold),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.PrivateHeatThreshold),
                    new ulong[]
                    {
                        78UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.PrivSlotListLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.PrivSlotList),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.CompactionNeeded),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.Spare),
                    new ulong[]
                    {
                        93UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BUCKET.AffinityMgr),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_HEAP_LFH_BUCKET>((mem, ptr) => new _HEAP_LFH_BUCKET(mem, ptr), offsets);
        }
    }
}