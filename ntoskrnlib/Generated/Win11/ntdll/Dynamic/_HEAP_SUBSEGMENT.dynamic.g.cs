using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_SUBSEGMENT")]
    public sealed class _HEAP_SUBSEGMENT : DynamicStructure
    {
        public IntPtr LocalInfo { get; }
        public IntPtr UserBlocks { get; }
        public _SLIST_HEADER DelayFreeList { get; }
        public _INTERLOCK_SEQ AggregateExchg { get; }
        public ushort BlockSize { get; }
        public ushort Flags { get; }
        public ushort BlockCount { get; }
        public byte SizeIndex { get; }
        public byte AffinityIndex { get; }
        public uint[] Alignment { get; }
        public uint Lock { get; }
        public _SINGLE_LIST_ENTRY SFreeListEntry { get; }

        public _HEAP_SUBSEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_SUBSEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_SUBSEGMENT.LocalInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.UserBlocks),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.DelayFreeList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.AggregateExchg),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.BlockSize),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.Flags),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.BlockCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.SizeIndex),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.AffinityIndex),
                    new ulong[]
                    {
                        43UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.Alignment),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.Lock),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HEAP_SUBSEGMENT.SFreeListEntry),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_HEAP_SUBSEGMENT>((mem, ptr) => new _HEAP_SUBSEGMENT(mem, ptr), offsets);
        }
    }
}