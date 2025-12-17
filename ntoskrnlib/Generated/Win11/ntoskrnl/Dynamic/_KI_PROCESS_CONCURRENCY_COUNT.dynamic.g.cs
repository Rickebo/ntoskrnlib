using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_PROCESS_CONCURRENCY_COUNT")]
    public sealed class _KI_PROCESS_CONCURRENCY_COUNT : DynamicStructure
    {
        public uint Fraction { get; }
        public uint Count { get; }
        public uint AllFields { get; }

        public _KI_PROCESS_CONCURRENCY_COUNT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_PROCESS_CONCURRENCY_COUNT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_PROCESS_CONCURRENCY_COUNT.Fraction),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_PROCESS_CONCURRENCY_COUNT.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_PROCESS_CONCURRENCY_COUNT.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KI_PROCESS_CONCURRENCY_COUNT>((mem, ptr) => new _KI_PROCESS_CONCURRENCY_COUNT(mem, ptr), offsets);
        }
    }
}