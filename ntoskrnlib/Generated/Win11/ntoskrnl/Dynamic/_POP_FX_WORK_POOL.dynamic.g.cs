using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_POOL")]
    public sealed class _POP_FX_WORK_POOL : DynamicStructure
    {
        public IntPtr Plugin { get; }
        public ulong EmergencyWorkQueueLock { get; }
        public _LIST_ENTRY EmergencyWorkQueue { get; }
        public byte[] WorkPoolQueues { get; }
        public int WorkItemStatus { get; }
        public byte[] WorkItems { get; }
        public byte[] PoolWorkerThreads { get; }

        public _POP_FX_WORK_POOL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_WORK_POOL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_WORK_POOL.Plugin),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL.EmergencyWorkQueueLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL.EmergencyWorkQueue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL.WorkPoolQueues),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL.WorkItemStatus),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL.WorkItems),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_FX_WORK_POOL.PoolWorkerThreads),
                    new ulong[]
                    {
                        264UL
                    }
                }
            };
            Register<_POP_FX_WORK_POOL>((mem, ptr) => new _POP_FX_WORK_POOL(mem, ptr), offsets);
        }
    }
}