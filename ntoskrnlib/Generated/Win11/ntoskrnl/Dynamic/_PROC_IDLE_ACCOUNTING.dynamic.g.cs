using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_IDLE_ACCOUNTING")]
    public sealed class _PROC_IDLE_ACCOUNTING : DynamicStructure
    {
        public uint StateCount { get; }
        public uint TotalTransitions { get; }
        public uint ResetCount { get; }
        public uint AbortCount { get; }
        public ulong StartTime { get; }
        public ulong PriorIdleTime { get; }
        public uint TimeUnit { get; }
        public byte[] State { get; }

        public _PROC_IDLE_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_IDLE_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_IDLE_ACCOUNTING.StateCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.TotalTransitions),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.ResetCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.AbortCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.StartTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.PriorIdleTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.TimeUnit),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_IDLE_ACCOUNTING.State),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_PROC_IDLE_ACCOUNTING>((mem, ptr) => new _PROC_IDLE_ACCOUNTING(mem, ptr), offsets);
        }
    }
}