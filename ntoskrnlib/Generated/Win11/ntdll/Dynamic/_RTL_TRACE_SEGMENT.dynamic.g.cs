using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_TRACE_SEGMENT")]
    public sealed class _RTL_TRACE_SEGMENT : DynamicStructure
    {
        public uint Magic { get; }
        public IntPtr Database { get; }
        public IntPtr NextSegment { get; }
        public ulong TotalSize { get; }
        public IntPtr SegmentStart { get; }
        public IntPtr SegmentEnd { get; }
        public IntPtr SegmentFree { get; }

        public _RTL_TRACE_SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_TRACE_SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_TRACE_SEGMENT.Magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_TRACE_SEGMENT.Database),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_TRACE_SEGMENT.NextSegment),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_TRACE_SEGMENT.TotalSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_TRACE_SEGMENT.SegmentStart),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_TRACE_SEGMENT.SegmentEnd),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_TRACE_SEGMENT.SegmentFree),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_RTL_TRACE_SEGMENT>((mem, ptr) => new _RTL_TRACE_SEGMENT(mem, ptr), offsets);
        }
    }
}