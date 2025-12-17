using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LOCAL_SEGMENT_INFO")]
    public sealed class _HEAP_LOCAL_SEGMENT_INFO : DynamicStructure
    {
        public IntPtr LocalData { get; }
        public IntPtr ActiveSubsegment { get; }
        public byte[] CachedItems { get; }
        public _SLIST_HEADER SListHeader { get; }
        public _HEAP_BUCKET_COUNTERS Counters { get; }
        public uint LastOpSequence { get; }
        public ushort BucketIndex { get; }
        public ushort LastUsed { get; }
        public ushort NoThrashCount { get; }

        public _HEAP_LOCAL_SEGMENT_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LOCAL_SEGMENT_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.LocalData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.ActiveSubsegment),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.CachedItems),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.SListHeader),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.Counters),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.LastOpSequence),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.BucketIndex),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.LastUsed),
                    new ulong[]
                    {
                        174UL
                    }
                },
                {
                    nameof(_HEAP_LOCAL_SEGMENT_INFO.NoThrashCount),
                    new ulong[]
                    {
                        176UL
                    }
                }
            };
            Register<_HEAP_LOCAL_SEGMENT_INFO>((mem, ptr) => new _HEAP_LOCAL_SEGMENT_INFO(mem, ptr), offsets);
        }
    }
}