using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT_OWNER")]
    public sealed class _HEAP_LFH_SUBSEGMENT_OWNER : DynamicStructure
    {
        public byte IsBucket { get; }
        public byte BucketIndex { get; }
        public byte SlotCount { get; }
        public byte AvailableSubsegmentCount { get; }
        public ushort BucketRef { get; }
        public ushort PrivateSlotMapRef { get; }
        public ushort HeatMapRef { get; }
        public _SINGLE_LIST_ENTRY OwnerFreeList { get; }
        public ushort Spare { get; }
        public ulong Lock { get; }
        public _SINGLE_LIST_ENTRY SlotStandbyEntry { get; }
        public _HEAP_LFH_PTRREF_LIST PrivSlotListEntry { get; }
        public uint OwnerThreadId { get; }
        public _LIST_ENTRY AvailableSubsegmentList { get; }
        public _LIST_ENTRY FullSubsegmentList { get; }

        public _HEAP_LFH_SUBSEGMENT_OWNER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_SUBSEGMENT_OWNER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.IsBucket),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.BucketIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.SlotCount),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.AvailableSubsegmentCount),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.BucketRef),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.PrivateSlotMapRef),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.HeatMapRef),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.OwnerFreeList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.Spare),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.SlotStandbyEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.PrivSlotListEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.OwnerThreadId),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.AvailableSubsegmentList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_OWNER.FullSubsegmentList),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_HEAP_LFH_SUBSEGMENT_OWNER>((mem, ptr) => new _HEAP_LFH_SUBSEGMENT_OWNER(mem, ptr), offsets);
        }
    }
}