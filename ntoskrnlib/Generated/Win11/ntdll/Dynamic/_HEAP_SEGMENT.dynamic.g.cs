using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_SEGMENT")]
    public sealed class _HEAP_SEGMENT : DynamicStructure
    {
        public _HEAP_ENTRY Entry { get; }
        public uint SegmentSignature { get; }
        public uint SegmentFlags { get; }
        public _LIST_ENTRY SegmentListEntry { get; }
        public IntPtr Heap { get; }
        public IntPtr BaseAddress { get; }
        public uint NumberOfPages { get; }
        public IntPtr FirstEntry { get; }
        public IntPtr LastValidEntry { get; }
        public uint NumberOfUnCommittedPages { get; }
        public uint NumberOfUnCommittedRanges { get; }
        public ushort SegmentAllocatorBackTraceIndex { get; }
        public ushort Reserved { get; }
        public _LIST_ENTRY UCRSegmentList { get; }

        public _HEAP_SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_SEGMENT.Entry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.SegmentSignature),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.SegmentFlags),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.SegmentListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.Heap),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.BaseAddress),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.NumberOfPages),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.FirstEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.LastValidEntry),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.NumberOfUnCommittedPages),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.NumberOfUnCommittedRanges),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.SegmentAllocatorBackTraceIndex),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.Reserved),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT.UCRSegmentList),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_HEAP_SEGMENT>((mem, ptr) => new _HEAP_SEGMENT(mem, ptr), offsets);
        }
    }
}