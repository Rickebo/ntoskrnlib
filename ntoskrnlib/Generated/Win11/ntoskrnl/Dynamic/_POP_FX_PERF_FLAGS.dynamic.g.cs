using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_PERF_FLAGS")]
    public sealed class _POP_FX_PERF_FLAGS : DynamicStructure
    {
        public int Value { get; }
        public uint Progress { get; }
        public uint Reserved { get; }
        public uint Synchronicity { get; }
        public uint RequestPepCompleted { get; }
        public uint RequestSucceeded { get; }
        public uint NestedCallback { get; }

        public _POP_FX_PERF_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_PERF_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_PERF_FLAGS.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_FLAGS.Progress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_FLAGS.Synchronicity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_FLAGS.RequestPepCompleted),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_FLAGS.RequestSucceeded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_FLAGS.NestedCallback),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_POP_FX_PERF_FLAGS>((mem, ptr) => new _POP_FX_PERF_FLAGS(mem, ptr), offsets);
        }
    }
}