using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_STACK_TRACE_ENTRY")]
    public sealed class _RTL_STACK_TRACE_ENTRY : DynamicStructure
    {
        public _RTL_STD_LIST_ENTRY HashChain { get; }
        public ushort TraceCount { get; }
        public ushort BlockDepth { get; }
        public ushort IndexHigh { get; }
        public ushort Index { get; }
        public ushort Depth { get; }
        public byte[] BackTrace { get; }
        public _SLIST_ENTRY FreeChain { get; }

        public _RTL_STACK_TRACE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_STACK_TRACE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.HashChain),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.TraceCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.BlockDepth),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.IndexHigh),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.Index),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.Depth),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.BackTrace),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_STACK_TRACE_ENTRY.FreeChain),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_STACK_TRACE_ENTRY>((mem, ptr) => new _RTL_STACK_TRACE_ENTRY(mem, ptr), offsets);
        }
    }
}