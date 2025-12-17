using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK")]
    public sealed class _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK : DynamicStructure
    {
        public _KI_PROCESS_CONCURRENCY_COUNT ExpectedConcurrencyCount { get; }
        public _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS Breakpoints { get; }
        public _unnamed_tag_ AssignmentFlags { get; }
        public ushort[] ThreadSeed { get; }
        public ushort[] IdealProcessor { get; }
        public ushort[] IdealNode { get; }
        public _KAFFINITY_EX IdealProcessorSets { get; }

        public _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.ExpectedConcurrencyCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.Breakpoints),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.AssignmentFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.ThreadSeed),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.IdealProcessor),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.IdealNode),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK.IdealProcessorSets),
                    new ulong[]
                    {
                        208UL
                    }
                }
            };
            Register<_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK>((mem, ptr) => new _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK(mem, ptr), offsets);
        }
    }
}