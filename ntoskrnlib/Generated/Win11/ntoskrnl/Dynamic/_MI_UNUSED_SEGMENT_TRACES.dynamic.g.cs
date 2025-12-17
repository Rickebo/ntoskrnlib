using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_UNUSED_SEGMENT_TRACES")]
    public sealed class _MI_UNUSED_SEGMENT_TRACES : DynamicStructure
    {
        public ulong ElapsedTime { get; }
        public ulong PagesMoved { get; }
        public ulong PagesFlushed { get; }
        public uint NumberOfThreads { get; }

        public _MI_UNUSED_SEGMENT_TRACES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_UNUSED_SEGMENT_TRACES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_UNUSED_SEGMENT_TRACES.ElapsedTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_UNUSED_SEGMENT_TRACES.PagesMoved),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_UNUSED_SEGMENT_TRACES.PagesFlushed),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_UNUSED_SEGMENT_TRACES.NumberOfThreads),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_UNUSED_SEGMENT_TRACES>((mem, ptr) => new _MI_UNUSED_SEGMENT_TRACES(mem, ptr), offsets);
        }
    }
}