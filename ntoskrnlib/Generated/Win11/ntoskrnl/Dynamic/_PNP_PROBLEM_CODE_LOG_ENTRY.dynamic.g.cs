using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_PROBLEM_CODE_LOG_ENTRY")]
    public sealed class _PNP_PROBLEM_CODE_LOG_ENTRY : DynamicStructure
    {
        public _LARGE_INTEGER Timestamp { get; }
        public uint Operation { get; }
        public uint ProblemCode { get; }
        public int ProblemStatus { get; }

        public _PNP_PROBLEM_CODE_LOG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_PROBLEM_CODE_LOG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_PROBLEM_CODE_LOG_ENTRY.Timestamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_PROBLEM_CODE_LOG_ENTRY.Operation),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_PROBLEM_CODE_LOG_ENTRY.ProblemCode),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PNP_PROBLEM_CODE_LOG_ENTRY.ProblemStatus),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PNP_PROBLEM_CODE_LOG_ENTRY>((mem, ptr) => new _PNP_PROBLEM_CODE_LOG_ENTRY(mem, ptr), offsets);
        }
    }
}