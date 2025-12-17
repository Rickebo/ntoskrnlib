using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_SEG_CONTEXT")]
    public sealed class _HEAP_SEG_CONTEXT : DynamicStructure
    {
        public ulong SegmentMask { get; }
        public byte UnitShift { get; }
        public byte PagesPerUnitShift { get; }
        public byte FirstDescriptorIndex { get; }
        public byte CachedCommitSoftShift { get; }
        public byte CachedCommitHighShift { get; }
        public _unnamed_tag_ Flags { get; }
        public uint MaxAllocationSize { get; }
        public short OlpStatsOffset { get; }
        public short MemStatsOffset { get; }
        public IntPtr LfhContext { get; }
        public IntPtr VsContext { get; }
        public RTL_HP_ENV_HANDLE EnvHandle { get; }
        public IntPtr Heap { get; }
        public ulong SegmentLock { get; }
        public _LIST_ENTRY SegmentListHead { get; }
        public ulong SegmentCount { get; }
        public _RTL_RB_TREE FreePageRanges { get; }
        public ulong FreeSegmentListLock { get; }
        public byte[] FreeSegmentList { get; }

        public _HEAP_SEG_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_SEG_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_SEG_CONTEXT.SegmentMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.UnitShift),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.PagesPerUnitShift),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.FirstDescriptorIndex),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.CachedCommitSoftShift),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.CachedCommitHighShift),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.Flags),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.MaxAllocationSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.OlpStatsOffset),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.MemStatsOffset),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.LfhContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.VsContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.EnvHandle),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.Heap),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.SegmentLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.SegmentListHead),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.SegmentCount),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.FreePageRanges),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.FreeSegmentListLock),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HEAP_SEG_CONTEXT.FreeSegmentList),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_HEAP_SEG_CONTEXT>((mem, ptr) => new _HEAP_SEG_CONTEXT(mem, ptr), offsets);
        }
    }
}