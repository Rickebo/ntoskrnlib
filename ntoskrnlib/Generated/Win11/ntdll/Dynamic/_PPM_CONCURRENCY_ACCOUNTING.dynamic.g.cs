using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_CONCURRENCY_ACCOUNTING")]
    public sealed class _PPM_CONCURRENCY_ACCOUNTING : DynamicStructure
    {
        public ulong Lock { get; }
        public uint Processors { get; }
        public uint ActiveProcessors { get; }
        public ulong LastUpdateTime { get; }
        public ulong TotalTime { get; }
        public ulong[] IdleIntervalStats { get; }
        public ulong[] AccumulatedTime { get; }

        public _PPM_CONCURRENCY_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_CONCURRENCY_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.Processors),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.ActiveProcessors),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.LastUpdateTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.TotalTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.IdleIntervalStats),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_CONCURRENCY_ACCOUNTING.AccumulatedTime),
                    new ulong[]
                    {
                        328UL
                    }
                }
            };
            Register<_PPM_CONCURRENCY_ACCOUNTING>((mem, ptr) => new _PPM_CONCURRENCY_ACCOUNTING(mem, ptr), offsets);
        }
    }
}