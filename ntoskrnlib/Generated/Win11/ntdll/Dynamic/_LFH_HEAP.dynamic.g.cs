using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LFH_HEAP")]
    public sealed class _LFH_HEAP : DynamicStructure
    {
        public _RTL_SRWLOCK Lock { get; }
        public _LIST_ENTRY SubSegmentZones { get; }
        public IntPtr Heap { get; }
        public IntPtr NextSegmentInfoArrayAddress { get; }
        public IntPtr FirstUncommittedAddress { get; }
        public IntPtr ReservedAddressLimit { get; }
        public uint SegmentCreate { get; }
        public uint SegmentDelete { get; }
        public uint MinimumCacheDepth { get; }
        public uint CacheShiftThreshold { get; }
        public ulong SizeInCache { get; }
        public _HEAP_BUCKET_RUN_INFO RunInfo { get; }
        public byte[] UserBlockCache { get; }
        public _HEAP_LFH_MEM_POLICIES MemoryPolicies { get; }
        public byte[] Buckets { get; }
        public byte[] SegmentInfoArrays { get; }
        public byte[] AffinitizedInfoArrays { get; }
        public IntPtr SegmentAllocator { get; }
        public byte[] LocalData { get; }

        public _LFH_HEAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LFH_HEAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LFH_HEAP.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LFH_HEAP.SubSegmentZones),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LFH_HEAP.Heap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LFH_HEAP.NextSegmentInfoArrayAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LFH_HEAP.FirstUncommittedAddress),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LFH_HEAP.ReservedAddressLimit),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LFH_HEAP.SegmentCreate),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LFH_HEAP.SegmentDelete),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_LFH_HEAP.MinimumCacheDepth),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LFH_HEAP.CacheShiftThreshold),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_LFH_HEAP.SizeInCache),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_LFH_HEAP.RunInfo),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_LFH_HEAP.UserBlockCache),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_LFH_HEAP.MemoryPolicies),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_LFH_HEAP.Buckets),
                    new ulong[]
                    {
                        676UL
                    }
                },
                {
                    nameof(_LFH_HEAP.SegmentInfoArrays),
                    new ulong[]
                    {
                        1192UL
                    }
                },
                {
                    nameof(_LFH_HEAP.AffinitizedInfoArrays),
                    new ulong[]
                    {
                        2224UL
                    }
                },
                {
                    nameof(_LFH_HEAP.SegmentAllocator),
                    new ulong[]
                    {
                        3256UL
                    }
                },
                {
                    nameof(_LFH_HEAP.LocalData),
                    new ulong[]
                    {
                        3264UL
                    }
                }
            };
            Register<_LFH_HEAP>((mem, ptr) => new _LFH_HEAP(mem, ptr), offsets);
        }
    }
}