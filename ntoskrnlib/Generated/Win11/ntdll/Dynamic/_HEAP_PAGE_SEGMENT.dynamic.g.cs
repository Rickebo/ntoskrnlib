using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_PAGE_SEGMENT")]
    public sealed class _HEAP_PAGE_SEGMENT : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public ulong Signature { get; }
        public IntPtr SegmentCommitState { get; }
        public byte UnusedWatermark { get; }
        public byte[] DescArray { get; }

        public _HEAP_PAGE_SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_PAGE_SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_PAGE_SEGMENT.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_SEGMENT.Signature),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_SEGMENT.SegmentCommitState),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_SEGMENT.UnusedWatermark),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_PAGE_SEGMENT.DescArray),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_PAGE_SEGMENT>((mem, ptr) => new _HEAP_PAGE_SEGMENT(mem, ptr), offsets);
        }
    }
}