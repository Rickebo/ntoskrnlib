using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_STACK_TRACE_BLOCK")]
    public sealed class _ETW_STACK_TRACE_BLOCK : DynamicStructure
    {
        public _ETW_APC_POOL ApcPool { get; }
        public int StackCaptureAttemptCount { get; }
        public int StackExpansionFailureCount { get; }

        public _ETW_STACK_TRACE_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_STACK_TRACE_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_STACK_TRACE_BLOCK.ApcPool),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_STACK_TRACE_BLOCK.StackCaptureAttemptCount),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_ETW_STACK_TRACE_BLOCK.StackExpansionFailureCount),
                    new ulong[]
                    {
                        196UL
                    }
                }
            };
            Register<_ETW_STACK_TRACE_BLOCK>((mem, ptr) => new _ETW_STACK_TRACE_BLOCK(mem, ptr), offsets);
        }
    }
}