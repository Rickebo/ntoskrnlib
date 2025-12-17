using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_FEEDBACK_COUNTER")]
    public sealed class _PROC_FEEDBACK_COUNTER : DynamicStructure
    {
        public IntPtr InstantaneousRead { get; }
        public IntPtr DifferentialRead { get; }
        public ulong LastActualCount { get; }
        public ulong LastReferenceCount { get; }
        public uint CachedValue { get; }
        public byte Affinitized { get; }
        public byte Differential { get; }
        public byte DiscardIdleTime { get; }
        public uint Scaling { get; }
        public ulong Context { get; }

        public _PROC_FEEDBACK_COUNTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_FEEDBACK_COUNTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_FEEDBACK_COUNTER.InstantaneousRead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.DifferentialRead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.LastActualCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.LastReferenceCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.CachedValue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.Affinitized),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.Differential),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.DiscardIdleTime),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.Scaling),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PROC_FEEDBACK_COUNTER.Context),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_PROC_FEEDBACK_COUNTER>((mem, ptr) => new _PROC_FEEDBACK_COUNTER(mem, ptr), offsets);
        }
    }
}