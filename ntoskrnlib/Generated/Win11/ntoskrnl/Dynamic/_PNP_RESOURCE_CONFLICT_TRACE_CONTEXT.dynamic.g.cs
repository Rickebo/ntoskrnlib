using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT")]
    public sealed class _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT : DynamicStructure
    {
        public byte ResourceType { get; }
        public uint AlternativeCount { get; }
        public IntPtr ResourceRequests { get; }
        public IntPtr ArbiterInstance { get; }

        public _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT.ResourceType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT.AlternativeCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT.ResourceRequests),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT.ArbiterInstance),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT>((mem, ptr) => new _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT(mem, ptr), offsets);
        }
    }
}