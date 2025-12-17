using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SILO_TRACING_BLOCK")]
    public sealed class _ETW_SILO_TRACING_BLOCK : DynamicStructure
    {
        public IntPtr ProcessorBuffers { get; }
        public IntPtr EventsLoggedCount { get; }
        public IntPtr QpcDelta { get; }

        public _ETW_SILO_TRACING_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SILO_TRACING_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_SILO_TRACING_BLOCK.ProcessorBuffers),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_SILO_TRACING_BLOCK.EventsLoggedCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_SILO_TRACING_BLOCK.QpcDelta),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_ETW_SILO_TRACING_BLOCK>((mem, ptr) => new _ETW_SILO_TRACING_BLOCK(mem, ptr), offsets);
        }
    }
}