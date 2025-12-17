using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_TRACE_BLOCK")]
    public sealed class _RTL_TRACE_BLOCK : DynamicStructure
    {
        public uint Magic { get; }
        public uint Count { get; }
        public uint Size { get; }
        public ulong UserCount { get; }
        public ulong UserSize { get; }
        public IntPtr UserContext { get; }
        public IntPtr Next { get; }
        public IntPtr Trace { get; }

        public _RTL_TRACE_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_TRACE_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_TRACE_BLOCK.Magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.UserCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.UserSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.UserContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.Next),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_TRACE_BLOCK.Trace),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_RTL_TRACE_BLOCK>((mem, ptr) => new _RTL_TRACE_BLOCK(mem, ptr), offsets);
        }
    }
}