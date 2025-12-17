using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_POOL_QUEUE_STATE")]
    public sealed class _TPP_POOL_QUEUE_STATE : DynamicStructure
    {
        public long Exchange { get; }
        public int RunningThreadGoal { get; }
        public uint PendingReleaseCount { get; }
        public uint QueueLength { get; }

        public _TPP_POOL_QUEUE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_POOL_QUEUE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_POOL_QUEUE_STATE.Exchange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_POOL_QUEUE_STATE.RunningThreadGoal),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_POOL_QUEUE_STATE.PendingReleaseCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_POOL_QUEUE_STATE.QueueLength),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_TPP_POOL_QUEUE_STATE>((mem, ptr) => new _TPP_POOL_QUEUE_STATE(mem, ptr), offsets);
        }
    }
}